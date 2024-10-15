using Microsoft.Extensions.Configuration;

namespace Expenses_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal expenseValue;
            string categoryName;

            if (decimal.TryParse(txtExpenseValue.Text, out expenseValue) != true) 
            {
                MessageBox.Show("The expense value typed is not valid.");
                txtExpenseValue.Text = "";
                return; //to stop the method execution
            }
            else {

                DataBaseControl exp_control = new DataBaseControl();


                if (listCate.SelectedItem != null)
                {
                    categoryName = listCate.SelectedItem.ToString();
                    try
                    {
                        int idCategory = exp_control.selectCategoryID(categoryName);
                        exp_control.AddExpense(expenseValue, dateExpensePicker.Value, idCategory);

                        //cleaning fields for a new expense
                        txtExpenseValue.Text = "";
                        dateExpensePicker.Value = DateTime.Now;
                        listCate.Items.Clear();

                        MessageBox.Show("Expense correctly inserted.");
                        return; //to stop the method execution
                    }

                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
    }
}
