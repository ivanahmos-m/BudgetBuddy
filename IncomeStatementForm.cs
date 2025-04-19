using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy
{
    public partial class IncomeStatementForm : Form
    {
        public IncomeStatementForm(DataGridView dvgTransactions)
        {
            InitializeComponent();

            lvIncomeStatement.Items.Clear();
            lvIncomeStatement.Groups.Clear();

            // Define ListView groups
            var incomeGroup = new ListViewGroup("Income", HorizontalAlignment.Left);
            var expenseGroup = new ListViewGroup("Expenses", HorizontalAlignment.Left);
            lvIncomeStatement.Groups.Add(incomeGroup);
            lvIncomeStatement.Groups.Add(expenseGroup);

            // Totals
            double totalIncome = 0;
            double totalExpenses = 0;

            // Loop through Form1's dvgTransactions
            foreach (DataGridViewRow row in dvgTransactions.Rows)
            {
                if (row.IsNewRow) continue;

                string type = row.Cells["Type"].Value?.ToString();
                string category = row.Cells["Category"].Value?.ToString();
                double amount = 0;

                if (row.Cells["Amount"].Value != null && double.TryParse(row.Cells["Amount"].Value.ToString(), out amount))
                {
                    var item = new ListViewItem(category);
                    item.SubItems.Add(amount.ToString("C2")); // "C2" formats it as currency

                    // Add to correct group
                    if (type == "Income")
                    {
                        item.Group = incomeGroup;
                        totalIncome += amount;
                    }
                    else if (type == "Expense")
                    {
                        item.Group = expenseGroup;
                        totalExpenses += amount;
                    }

                    lvIncomeStatement.Items.Add(item);
                }
            }

            // Totals
            double netProfit = totalIncome - totalExpenses;
            lblTotalIncome.Text = "Total Revenue: " + totalIncome.ToString("C2");
            lblTotalExpense.Text = "Total Expenses: " + totalExpenses.ToString("C2");
            lblNetProfit.Text = "Net Profit: " + netProfit.ToString("C2");
            lvIncomeStatement.Refresh();
        }

        private void IncomeStatementForm_Load(object sender, EventArgs e)
        {

        }

        private void IncomeStatementForm_Load_1(object sender, EventArgs e)
        {

        }

    }
}
