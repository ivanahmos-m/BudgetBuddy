namespace BudgetBuddy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIncome = new Label();
            lblExpense = new Label();
            lblBalance = new Label();
            dtpMonth = new DateTimePicker();
            dgvTransactions = new DataGridView();
            btnAddTransaction = new Button();
            btnDeleteTransaction = new Button();
            btnRefresh = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIncome.Location = new Point(61, 45);
            lblIncome.Margin = new Padding(5, 0, 5, 0);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(85, 22);
            lblIncome.TabIndex = 0;
            lblIncome.Text = "Income:";
            // 
            // lblExpense
            // 
            lblExpense.AutoSize = true;
            lblExpense.Location = new Point(61, 67);
            lblExpense.Name = "lblExpense";
            lblExpense.Size = new Size(97, 22);
            lblExpense.TabIndex = 1;
            lblExpense.Text = "Expenses:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(61, 89);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(91, 22);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "Balance:";
            // 
            // dtpMonth
            // 
            dtpMonth.Location = new Point(61, 11);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.Size = new Size(342, 31);
            dtpMonth.TabIndex = 3;
            dtpMonth.ValueChanged += dtpMonth_ValueChanged;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(64, 140);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(972, 397);
            dgvTransactions.TabIndex = 4;
            dgvTransactions.CellContentClick += dgvTransactions_CellContentClick;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.Location = new Point(520, 49);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(135, 59);
            btnAddTransaction.TabIndex = 5;
            btnAddTransaction.Text = "Add Transaction";
            btnAddTransaction.UseVisualStyleBackColor = true;
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // btnDeleteTransaction
            // 
            btnDeleteTransaction.Location = new Point(688, 49);
            btnDeleteTransaction.Name = "btnDeleteTransaction";
            btnDeleteTransaction.Size = new Size(141, 59);
            btnDeleteTransaction.TabIndex = 6;
            btnDeleteTransaction.Text = "Delete Transaction";
            btnDeleteTransaction.UseVisualStyleBackColor = true;
            btnDeleteTransaction.Click += btnDeleteTransaction_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(860, 49);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(122, 59);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(82, 566);
            button1.Name = "button1";
            button1.Size = new Size(157, 69);
            button1.TabIndex = 8;
            button1.Text = "Income Statement";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 660);
            Controls.Add(button1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeleteTransaction);
            Controls.Add(btnAddTransaction);
            Controls.Add(dgvTransactions);
            Controls.Add(dtpMonth);
            Controls.Add(lblBalance);
            Controls.Add(lblExpense);
            Controls.Add(lblIncome);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "BudgetBuddy";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIncome;
        private Label lblExpense;
        private Label lblBalance;
        private DateTimePicker dtpMonth;
        private DataGridView dgvTransactions;
        private Button btnAddTransaction;
        private Button btnDeleteTransaction;
        private Button btnRefresh;
        private Button button1;
    }
}
