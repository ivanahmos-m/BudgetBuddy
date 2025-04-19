namespace BudgetBuddy
{
    partial class AddTransactionForm
    {
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
        private void InitializeComponent()
        {
            dtpDate = new DateTimePicker();
            txtDescription = new TextBox();
            label1 = new Label();
            cmbCategory = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbType = new ComboBox();
            btnSave = new Button();
            label4 = new Label();
            numAmount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(77, 41);
            dtpDate.Margin = new Padding(5, 4, 5, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(312, 31);
            dtpDate.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(190, 94);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(156, 31);
            txtDescription.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 97);
            label1.Name = "label1";
            label1.Size = new Size(116, 22);
            label1.TabIndex = 2;
            label1.Text = "Description:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(189, 195);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 30);
            cmbCategory.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 195);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 4;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 139);
            label3.Name = "label3";
            label3.Size = new Size(59, 22);
            label3.TabIndex = 5;
            label3.Text = "Type:";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(189, 139);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 30);
            cmbType.TabIndex = 6;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(176, 271);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 68);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Transaction";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 233);
            label4.Name = "label4";
            label4.Size = new Size(88, 22);
            label4.TabIndex = 8;
            label4.Text = "amount:";
            // 
            // numAmount
            // 
            numAmount.Location = new Point(190, 231);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(120, 31);
            numAmount.TabIndex = 9;
            // 
            // AddTransactionForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 351);
            Controls.Add(numAmount);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(cmbType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbCategory);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(dtpDate);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "AddTransactionForm";
            Text = "Add Transaction";
            Load += AddTransactionForm_Load;
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private TextBox txtDescription;
        private Label label1;
        private ComboBox cmbCategory;
        private Label label2;
        private Label label3;
        private ComboBox cmbType;
        private Button btnSave;
        private Label label4;
        private NumericUpDown numAmount;
    }
}