using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetBuddy
{
    public partial class AddTransactionForm : Form
    {
        public AddTransactionForm()
        {
            InitializeComponent();
        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {
            cmbType.Items.Add("Income");
            cmbType.Items.Add("Expense");
            cmbType.SelectedIndex = 0; // default to Income

            LoadCategories(); // populate category box
        }
        void LoadCategories()
        {
            cmbCategory.Items.Clear();

            if (cmbType.SelectedItem?.ToString() == "Income")
            {
                cmbCategory.Items.AddRange(new string[]
                {
            "Product Sales",
            "Service Income",
            "Client Payment",
            "Investment Income",
            "Refund Received",
            "Other"
                });
            }
            else // Expense
            {
                cmbCategory.Items.AddRange(new string[]
                {
            "Inventory Purchase",
            "Office Supplies",
            "Rent",
            "Utilities",
            "Marketing & Ads",
            "Employee Salaries",
            "Software Subscriptions",
            "Travel & Transport",
            "Client Refund",
            "Other"
                });
            }

            cmbCategory.SelectedIndex = 0;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            DatabaseHelper.AddTransaction(
        dtpDate.Value,
        txtDescription.Text,
        cmbCategory.Text,
        cmbType.Text,
        (double)numAmount.Value
    );
            this.Close();
        }
    }
}
