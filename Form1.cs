using System.Data;
using System.Data.SQLite;
namespace BudgetBuddy
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=accounting.db;Version=3;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dbPath = "Data Source=accounting.db;Version=3;";
            if (!File.Exists("accounting.db"))
            {
                SQLiteConnection.CreateFile("accounting.db");
                using (var conn = new SQLiteConnection(dbPath))
                {
                    conn.Open();
                    string createTableQuery = @"
            CREATE TABLE Transactions (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Date TEXT NOT NULL,
                Description TEXT,
                Category TEXT,
                Type TEXT CHECK(Type IN ('Income', 'Expense')),
                Amount REAL NOT NULL
            );
        ";
                    SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadDashboard();
            LoadTransactionTable();
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.CustomFormat = "MMMM yyyy";
            dtpMonth.ShowUpDown = true;

        }
        void LoadDashboard()
        {
            var (income, expense) = GetTotalsForMonth(
                dtpMonth.Value.Year, dtpMonth.Value.Month);

            lblIncome.Text = $"Total Income: ${income:F2}";
            lblExpense.Text = $"Total Expenses: ${expense:F2}";
            lblBalance.Text = $"Balance: ${(income - expense):F2}";
        }
        void LoadTransactionTable()
        {
            dgvTransactions.DataSource = LoadTransactionsForMonth(
                dtpMonth.Value.Year, dtpMonth.Value.Month);
        }
        DataTable LoadTransactionsForMonth(int year, int month)
        {
            DataTable dt = new DataTable();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT * FROM Transactions
            WHERE strftime('%Y', Date) = @Year
              AND strftime('%m', Date) = @Month
            ORDER BY Date DESC";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Year", year.ToString());
                    cmd.Parameters.AddWithValue("@Month", month.ToString("D2")); // pad with 0
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        void AddTransaction(DateTime date, string desc, string category, string type, double amount)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Transactions (Date, Description, Category, Type, Amount) " +
                               "VALUES (@Date, @Description, @Category, @Type, @Amount)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Description", desc);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        DataTable LoadTransactions()
        {
            DataTable dt = new DataTable();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Transactions ORDER BY Date DESC";
                using (var da = new SQLiteDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        (double income, double expense) GetTotalsForMonth(int year, int month)
        {
            double income = 0, expense = 0;

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT Type, SUM(Amount) AS Total
            FROM Transactions
            WHERE strftime('%Y', Date) = @Year AND strftime('%m', Date) = @Month
            GROUP BY Type";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Year", year.ToString());
                    cmd.Parameters.AddWithValue("@Month", month.ToString("D2"));

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string type = reader.GetString(0);
                            double total = reader.IsDBNull(1) ? 0 : reader.GetDouble(1);

                            if (type == "Income") income = total;
                            else if (type == "Expense") expense = total;
                        }
                    }
                }
            }

            return (income, expense);
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            var form = new AddTransactionForm();
            form.ShowDialog();
            LoadDashboard();
            LoadTransactionTable();
        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvTransactions.SelectedRows[0].Cells["Id"].Value);
                DatabaseHelper.DeleteTransaction(id);
                LoadDashboard();
                LoadTransactionTable();
            }
        }

        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            LoadDashboard();
            LoadTransactionTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IncomeStatementForm incomeStatementForm = new IncomeStatementForm(dgvTransactions);
            incomeStatementForm.Show();
        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
