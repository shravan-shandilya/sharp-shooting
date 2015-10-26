using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '1';
            this.textBox1.Text = input;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '2';
            this.textBox1.Text = input;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '3';
            this.textBox1.Text = input;
        }
        private void num4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '4';
            this.textBox1.Text = input;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '5';
            this.textBox1.Text = input;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '6';
            this.textBox1.Text = input;
        }
       

        private void num7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '7';
            this.textBox1.Text = input;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '8';
            this.textBox1.Text = input;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '9';
            this.textBox1.Text = input;
        }

        

        private void num0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '0';
            this.textBox1.Text = input;
        }

       
        private void plus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }
        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double number1, number2;
            double.TryParse(this.operand1, out number1);
            double.TryParse(this.operand2, out number2);
            if(operation == '+')
            {
                result = number1 + number2;
                this.textBox1.Text = result.ToString();

            }
            else if(operation == '-')
            {
                result = number1 - number2;
                this.textBox1.Text = result.ToString();

            }
            else if(operation == '*')
            {
                result = number1 * number2;
                this.textBox1.Text = result.ToString();

            }
            else if(operation == '/')
            {
                if (number2 == 0)
                {
                    this.textBox1.Text = "Divide by zero exception!!";
                }
                else
                {
                    result = number1 / number2;
                    this.textBox1.Text = result.ToString();
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.input = string.Empty;
            this.textBox1.Text = "";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '.';
            this.textBox1.Text = input;
        }
    }
}
