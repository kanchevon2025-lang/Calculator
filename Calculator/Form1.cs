namespace Calculator

{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" || isOperationPerformed) txtdisplay.Clear();
            isOperationPerformed = false;
            txtdisplay.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" || isOperationPerformed) txtdisplay.Clear();
            isOperationPerformed = false;
            txtdisplay.Text += "4";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            resultValue = double.Parse(txtdisplay.Text);
            operationPerformed = "-";
            isOperationPerformed = true;
        }

        private void btndivide_Click(object sender, EventArgs e)
        {

        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            resultValue = double.Parse(txtdisplay.Text);
            operationPerformed = "+";
            isOperationPerformed = true;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" || isOperationPerformed) txtdisplay.Clear();
            isOperationPerformed = false;
            txtdisplay.Text += "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" || isOperationPerformed) txtdisplay.Clear();
            isOperationPerformed = false;
            txtdisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" || isOperationPerformed) txtdisplay.Clear();
            isOperationPerformed = false;
            txtdisplay.Text += "3";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" || isOperationPerformed) txtdisplay.Clear();
            isOperationPerformed = false;
            txtdisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" || isOperationPerformed) txtdisplay.Clear();
            isOperationPerformed = false;
            txtdisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" || isOperationPerformed) txtdisplay.Clear();
            isOperationPerformed = false;
            txtdisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" || isOperationPerformed) txtdisplay.Clear();
            isOperationPerformed = false;
            txtdisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "0" || isOperationPerformed) txtdisplay.Clear();
            isOperationPerformed = false;
            txtdisplay.Text += "9";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed) txtdisplay.Clear();
            isOperationPerformed = false;

            if (!txtdisplay.Text.Contains("."))
            {
                txtdisplay.Text += ".";
            }
        }

        private void btnmultiply_Click_1(object sender, EventArgs e)
        {
            resultValue = double.Parse(txtdisplay.Text);
            operationPerformed = "*";
            isOperationPerformed = true;
        }

        private void btndivide_Click_1(object sender, EventArgs e)
        {
            resultValue = double.Parse(txtdisplay.Text);
            operationPerformed = "/";
            isOperationPerformed = true;
        }

        private void btnclearentry_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
            resultValue = 0;
            operationPerformed = "";
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            double secondNum = double.Parse(txtdisplay.Text);

            switch (operationPerformed)
            {
                case "+":
                    txtdisplay.Text = (resultValue + secondNum).ToString();
                    break;
                case "-":
                    txtdisplay.Text = (resultValue - secondNum).ToString();
                    break;
                case "*":
                    txtdisplay.Text = (resultValue * secondNum).ToString();
                    break;
                case "/":
                    if (secondNum != 0)
                        txtdisplay.Text = (resultValue / secondNum).ToString();
                    else
                        txtdisplay.Text = "Error";
                    break;
            }

            resultValue = 0;
            operationPerformed = "";
        }
    }
}
