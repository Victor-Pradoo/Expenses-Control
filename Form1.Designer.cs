namespace Expenses_Control
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
            btnSubmit = new Button();
            lblHWMuch = new Label();
            txtExpenseValue = new TextBox();
            lblWhen = new Label();
            dateExpensePicker = new DateTimePicker();
            lblCate = new Label();
            listCate = new ListBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(197, 360);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // lblHWMuch
            // 
            lblHWMuch.AutoSize = true;
            lblHWMuch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHWMuch.Location = new Point(25, 19);
            lblHWMuch.Name = "lblHWMuch";
            lblHWMuch.Size = new Size(178, 19);
            lblHWMuch.TabIndex = 4;
            lblHWMuch.Text = "How much did you spent?";
            // 
            // txtExpenseValue
            // 
            txtExpenseValue.Location = new Point(29, 49);
            txtExpenseValue.Name = "txtExpenseValue";
            txtExpenseValue.Size = new Size(201, 23);
            txtExpenseValue.TabIndex = 0;
            txtExpenseValue.TextChanged += textBox1_TextChanged;
            // 
            // lblWhen
            // 
            lblWhen.AutoSize = true;
            lblWhen.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWhen.Location = new Point(25, 91);
            lblWhen.Name = "lblWhen";
            lblWhen.Size = new Size(226, 19);
            lblWhen.TabIndex = 5;
            lblWhen.Text = "When did you spent that money?";
            // 
            // dateExpensePicker
            // 
            dateExpensePicker.Location = new Point(29, 122);
            dateExpensePicker.Name = "dateExpensePicker";
            dateExpensePicker.Size = new Size(200, 23);
            dateExpensePicker.TabIndex = 1;
            dateExpensePicker.Value = new DateTime(2024, 9, 11, 0, 0, 0, 0);
            // 
            // lblCate
            // 
            lblCate.AutoSize = true;
            lblCate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCate.Location = new Point(25, 165);
            lblCate.Name = "lblCate";
            lblCate.Size = new Size(151, 19);
            lblCate.TabIndex = 6;
            lblCate.Text = "Wich category it fits?";
            // 
            // listCate
            // 
            listCate.FormattingEnabled = true;
            listCate.ItemHeight = 15;
            listCate.Items.AddRange(new object[] { "Housing", "Transportation", "Groceries", "Insurance", "Healthcare", "Debt Repayment", "Entertainment", "Personal Care", "Education", "Childcare" });
            listCate.Location = new Point(29, 203);
            listCate.Name = "listCate";
            listCate.Size = new Size(120, 94);
            listCate.TabIndex = 2;
            listCate.SelectedIndexChanged += listBox1_SelectedIndexChanged_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 395);
            Controls.Add(listCate);
            Controls.Add(lblCate);
            Controls.Add(dateExpensePicker);
            Controls.Add(lblWhen);
            Controls.Add(txtExpenseValue);
            Controls.Add(lblHWMuch);
            Controls.Add(btnSubmit);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense Registration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label lblHWMuch;
        private TextBox txtExpenseValue;
        private Label lblWhen;
        private DateTimePicker dateExpensePicker;
        private Label lblCate;
        private ListBox listCate;
    }
}
