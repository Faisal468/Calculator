using System;
using System.Windows.Forms;
using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isoperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0")  || (isoperationPerformed)  )
            textBox_result.Clear();
                

            isoperationPerformed = false;
            Button button = (Button)sender;
            textBox_result.Text = textBox_result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = double.Parse(textBox_result.Text);
            isoperationPerformed = true;


        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultValue = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (textBox_result.Text.Length > 0)
            {
                textBox_result.Text = textBox_result.Text.Remove(textBox_result.Text.Length - 1, 1);
            }


            if (textBox_result.Text == "0")
            {
                textBox_result.Text = "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_result.Text = (resultValue + double.Parse(textBox_result.Text)).ToString();
                    break;

                case "-":
                    textBox_result.Text = (resultValue - double.Parse(textBox_result.Text)).ToString();
                    break;

                case "X":
                    textBox_result.Text = (resultValue * double.Parse(textBox_result.Text)).ToString();
                    break;

                case "%":
                    textBox_result.Text = (resultValue / double.Parse(textBox_result.Text)).ToString();
                    break;

                default:
                    break;

            }

        }
    }


}
