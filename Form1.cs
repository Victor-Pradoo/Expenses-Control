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

            if(decimal.TryParse(txtExpenseValue.Text, out expenseValue) != true) 
            {
                MessageBox.Show("The expense value typed is not valid.");
                txtExpenseValue.Text = "";
                return; //to stop the method execution
            }
            else {
                DataBaseControl.AddExpense();
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
