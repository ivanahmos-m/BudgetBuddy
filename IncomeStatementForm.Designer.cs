namespace BudgetBuddy
{
    partial class IncomeStatementForm
    {
        private System.Windows.Forms.ListView lvIncomeStatement;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Label lblNetProfit;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        // IncomeStatementForm.Designer.cs

        private void InitializeComponent()
        {
            lvIncomeStatement = new ListView();
            lblTotalIncome = new Label();
            lblTotalExpense = new Label();
            lblNetProfit = new Label();
            SuspendLayout();
            // 
            // lvIncomeStatement
            // 
            lvIncomeStatement.Location = new Point(12, 12);
            lvIncomeStatement.Name = "lvIncomeStatement";
            lvIncomeStatement.Size = new Size(400, 300);
            lvIncomeStatement.TabIndex = 0;
            lvIncomeStatement.UseCompatibleStateImageBehavior = false;
            lvIncomeStatement.View = View.Details;
            this.lvIncomeStatement = new System.Windows.Forms.ListView();
            this.lvIncomeStatement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
    new System.Windows.Forms.ColumnHeader() { Text = "Category", Width = 200 },
    new System.Windows.Forms.ColumnHeader() { Text = "Amount", Width = 150 }
});
            this.lvIncomeStatement.Location = new System.Drawing.Point(12, 12);
            this.lvIncomeStatement.Size = new System.Drawing.Size(400, 300);
            this.lvIncomeStatement.View = System.Windows.Forms.View.Details;
            this.lvIncomeStatement.FullRowSelect = true;
            this.lvIncomeStatement.GridLines = true;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.Location = new Point(12, 320);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(150, 25);
            lblTotalIncome.TabIndex = 1;
            // 
            // lblTotalExpense
            // 
            lblTotalExpense.Location = new Point(12, 350);
            lblTotalExpense.Name = "lblTotalExpense";
            lblTotalExpense.Size = new Size(150, 25);
            lblTotalExpense.TabIndex = 2;
            // 
            // lblNetProfit
            // 
            lblNetProfit.Location = new Point(12, 380);
            lblNetProfit.Name = "lblNetProfit";
            lblNetProfit.Size = new Size(150, 25);
            lblNetProfit.TabIndex = 3;
            // 
            // IncomeStatementForm
            // 
            ClientSize = new Size(450, 420);
            Controls.Add(lvIncomeStatement);
            Controls.Add(lblTotalIncome);
            Controls.Add(lblTotalExpense);
            Controls.Add(lblNetProfit);
            Name = "IncomeStatementForm";
            Text = "Income Statement";
            Load += IncomeStatementForm_Load_1;
            ResumeLayout(false);
        }

        #endregion
    }
}