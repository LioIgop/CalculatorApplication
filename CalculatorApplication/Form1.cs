namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorPass cal;
        double num1, num2;
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorPass();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);
            if (cbOperator.Text == "+")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                lbDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }
            else if (cbOperator.Text == "-")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                lbDisplayTotal.Text= cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }
            else if (cbOperator.Text == "*")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                lbDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
            }
            else if (cbOperator.Text == "/")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                lbDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
            }
        }
    }
}