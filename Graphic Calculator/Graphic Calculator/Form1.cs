using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Calculator
{
    public partial class Form1 : Form
    {
        double num1 = 0.0;
        double num2 = 0.0;
        char op = ' ';
        double result = 0.0;
        int click = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            textBox.Text += 1.ToString();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            textBox.Text += 2.ToString();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            textBox.Text += 3.ToString();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            textBox.Text += 4.ToString();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            textBox.Text += 5.ToString();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            textBox.Text += 6.ToString();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            textBox.Text += 7.ToString();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            textBox.Text += 8.ToString();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            textBox.Text += 9.ToString();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            textBox.Text += 0.ToString();
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if(click == 0)
            {
                num1 = Convert.ToDouble(textBox.Text);
                click++;
                textBox.Clear();
            }

            else if(click == 1)
            {
                num2 = Convert.ToDouble(textBox.Text);
                textBox.Clear();
                if(op != '+' && op != '-' && op != '/' && op != '*' && op != '^' && op != 'l' && click == 1)
                {
                    textBox.Text = "Wrong operation!";
                    op = ' ';
                }
                else
                {
                    if(op == '+')
                    {
                        result = Add(num1, num2);
                    }

                    else if(op == '-')
                    {
                        result = Sub(num1, num2);
                    }

                    else if(op == '*')
                    {
                        result = Mult(num1, num2);
                    }

                    else if(op == '/')
                    {
                        result = Div(num1, num2);
                    }

                    else if(op == '^')
                    {
                        result = NumPow(num1, num2);
                    }
                    
                    else if (op == 'l')
                    {
                        result = LogFunc(num1, num2);
                    }
                    textBox.Text = result.ToString();
                    num1 = 0;
                    num2 = 0;
                }
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            op = '+';
            if(textBox.Text.Length > 0 && click == 0)
            {
                num1 = Convert.ToDouble(textBox.Text);
                textBox.Clear();
                click++;
            }
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            op = '*';
            if (textBox.Text.Length > 0 && click == 0)
            {
                num1 = Convert.ToDouble(textBox.Text);
                textBox.Clear();
                click++;
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            op = '-';
            if (textBox.Text.Length > 0 && click == 0)
            {
                num1 = Convert.ToDouble(textBox.Text);
                textBox.Clear();
                click++;
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            op = '/';
            if (textBox.Text.Length > 0 && click == 0)
            {
                num1 = Convert.ToDouble(textBox.Text);
                textBox.Clear();
                click++;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            num1 = 0;
            op = ' ';
            num2 = 0;
            click = 0;
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            if(click == 0)
            {
                num1 = Convert.ToDouble(textBox.Text);
                result = EFunc(num1);
            }
            else
            {
                result = EFunc(num1);
            }
            textBox.Text = result.ToString();
        }

        private void PowButton_Click(object sender, EventArgs e)
        {
            op = '^';
            if (textBox.Text.Length > 0 && click == 0)
            {
                num1 = Convert.ToDouble(textBox.Text);
                textBox.Clear();
                click++;
            }
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            op = 'l';
            if (textBox.Text.Length > 0 && click == 0)
            {
                num1 = Convert.ToDouble(textBox.Text);
                textBox.Clear();
                click++;
            }
        }

        private void PiButton_Click(object sender, EventArgs e)
        {
            textBox.Text = Math.PI.ToString();
        }

        private double Add(double num1, double num2)
        {
            double ans = num1 + num2;
            return ans;
        }

        private double Sub(double num1, double num2)
        {
            double ans = num1 - num2;
            return ans;
        }

        private double Mult(double num1, double num2)
        {
            double ans = num1 * num2;
            return ans;
        }

        private double Div(double num1, double num2)
        {
            if(num2 == 0)
            {
                textBox.Text = "DIVIDE BY ZERO ERROR";
                num1 = 0;
                num2 = 0;
                op = ' ';
                return -1;
            }

            else
            {
                double ans = num1 / num2;
                return ans;
            }
        }

        private double EFunc(double num1)
        {
            double ans = Math.Exp(num1);
            return ans;
        }

        private double NumPow(double num1, double num2)
        {
            double ans = Math.Pow(num1, num2);
            return ans;
        }

        private double LogFunc(double num1, double num2)
        {
            double ans = Math.Log(num2, num1);
            return ans;
        }
    }
}
