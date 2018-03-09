using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseConversion
{
    public partial class Form1 : Form
    {
        char capitalLetter;
        char lowerLetterChar;
        int ASCIIValue;
        String BinaryValue;
        String HexValue;
        int inputLength = 0;
        String input;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpperCaseAns_TextChanged(object sender, EventArgs e)
        {

        }

        private void BinaryAns_TextChanged(object sender, EventArgs e)
        {

        }

        private void HexAns_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            input = textBox.Text;
            inputLength = input.Length;
            if (inputLength > 1) // Handles user inputs greater than a character
            {
                ASCIIAns.Text = "Too long!";
                UpperCaseAns.Text = "Too long!";
                HexAns.Text = "Too long!";
                BinaryAns.Text = "Too long!";
            }

            else if(inputLength <= 0) // Handles empty user input
            {
                ASCIIAns.Text = "Too short!";
                UpperCaseAns.Text = "Too short!";
                HexAns.Text = "Too short!";
                BinaryAns.Text = "Too short!";
            }

            else
            {
                inputLength = 0; // reset the length for the next input
                lowerLetterChar = input[0];
                if (Char.IsUpper(lowerLetterChar))
                {
                    ASCIIAns.Text = "Wrong case!";
                    UpperCaseAns.Text = "Wrong case!";
                    HexAns.Text = "Wrong case!";
                    BinaryAns.Text = "Wrong case!";
                }
                else if(Char.IsLetter(lowerLetterChar) != true)
                {
                    ASCIIAns.Text = "Not a letter!";
                    UpperCaseAns.Text = "Not a letter!";
                    HexAns.Text = "Not a letter!";
                    BinaryAns.Text = "Not a letter!";
                }
                else
                {
                    ASCIIValue = Convert.ToInt16(lowerLetterChar);
                    capitalLetter = Char.ToUpper(lowerLetterChar);
                    BinaryValue = Convert.ToString(ASCIIValue, 2);
                    HexValue = Convert.ToString(ASCIIValue, 16);

                    ASCIIAns.Text = "" + ASCIIValue;
                    UpperCaseAns.Text = "" + capitalLetter;
                    HexAns.Text = "" + HexValue;
                    BinaryAns.Text = "" + BinaryValue;
                }
            }
        }
    }
}
