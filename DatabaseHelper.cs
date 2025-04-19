using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy
{
    public static class DatabaseHelper
    {
        static string connectionString = "Data Source=accounting.db;Version=3;";
        public static DataTable LoadTransactionsForMonth(int year, int month)
        {
            DataTable dt = new DataTable();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT * FROM Transactions
            WHERE strftime('%Y', Date) = @Year AND strftime('%m', Date) = @Month
            ORDER BY Date DESC";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Year", year.ToString());
                    cmd.Parameters.AddWithValue("@Month", month.ToString("D2"));

                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static void AddTransaction(DateTime date, string desc, string category, string type, double amount)
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
        public static DataTable LoadTransactions()
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

        public static (double income, double expense) GetTotalsForMonth(int year, int month)
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
        public static void DeleteTransaction(int id)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Transactions WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
