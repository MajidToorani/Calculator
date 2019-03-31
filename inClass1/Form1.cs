using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inClass1
{
    public partial class Form1 : Form
    {
        double num1Double;
        double num2Double;
        double result;
        string num1;
        string num2;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                buttonOnOff.BackColor = Color.Green;
                Screen.Text = "";
            }
            else
            {
                buttonOnOff.BackColor = Color.Red;
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                if (buttonPlus.BackColor == Color.Gray || buttonMultiply.BackColor == Color.Gray ||
                    buttonMinus.BackColor == Color.Gray || buttonDivision.BackColor == Color.Gray)
                {
                    Screen.Text += "0";
                    num2 += "0";
                }
                else
                {
                    Screen.Text += "0";
                    num1 += "0";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                if (buttonPlus.BackColor == Color.Gray || buttonMultiply.BackColor == Color.Gray ||
                    buttonMinus.BackColor == Color.Gray || buttonDivision.BackColor == Color.Gray)
                {
                    Screen.Text += "1";
                    num2 += "1";
                }
                else
                {
                    Screen.Text += "1";
                    num1 += "1";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                if (buttonPlus.BackColor == Color.Gray || buttonMultiply.BackColor == Color.Gray ||
                    buttonMinus.BackColor == Color.Gray || buttonDivision.BackColor == Color.Gray)
                {
                    Screen.Text += "2";
                    num2 += "2";
                }
                else
                {
                    Screen.Text += "2";
                    num1 += "2";
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                if (buttonPlus.BackColor == Color.Gray || buttonMultiply.BackColor == Color.Gray ||
                    buttonMinus.BackColor == Color.Gray || buttonDivision.BackColor == Color.Gray)
                {
                    Screen.Text += "3";
                    num2 += "3";
                }
                else
                {
                    Screen.Text += "3";
                    num1 += "3";
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                if (buttonPlus.BackColor == Color.Gray || buttonMultiply.BackColor == Color.Gray ||
                    buttonMinus.BackColor == Color.Gray || buttonDivision.BackColor == Color.Gray)
                {
                    Screen.Text += "4";
                    num2 += "4";
                }
                else
                {
                    Screen.Text += "4";
                    num1 += "4";
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                if (buttonPlus.BackColor == Color.Gray || buttonMultiply.BackColor == Color.Gray ||
                    buttonMinus.BackColor == Color.Gray || buttonDivision.BackColor == Color.Gray)
                {
                    Screen.Text += "5";
                    num2 += "5";
                }
                else
                {
                    Screen.Text += "5";
                    num1 += "5";
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                if (buttonPlus.BackColor == Color.Gray || buttonMultiply.BackColor == Color.Gray ||
                    buttonMinus.BackColor == Color.Gray || buttonDivision.BackColor == Color.Gray)
                {
                    Screen.Text += "6";
                    num2 += "6";
                }
                else
                {
                    Screen.Text += "6";
                    num1 += "6";
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                if (buttonPlus.BackColor == Color.Gray || buttonMultiply.BackColor == Color.Gray ||
                    buttonMinus.BackColor == Color.Gray || buttonDivision.BackColor == Color.Gray)
                {
                    Screen.Text = "";
                    Screen.Text += "7";
                    num2 += "7";
                }
                else
                {
                    Screen.Text += "7";
                    num1 += "7";
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                if (buttonPlus.BackColor == Color.Gray || buttonMultiply.BackColor == Color.Gray ||
                    buttonMinus.BackColor == Color.Gray || buttonDivision.BackColor == Color.Gray)
                {
                    Screen.Text += "8";
                    num2 += "8";
                }
                else
                {
                    Screen.Text += "8";
                    num1 += "8";
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                if (buttonPlus.BackColor == Color.Gray || buttonMultiply.BackColor == Color.Gray ||
                    buttonMinus.BackColor == Color.Gray || buttonDivision.BackColor == Color.Gray)
                {
                    Screen.Text += "9";
                    num2 += "9";
                }
                else
                {
                    Screen.Text += "9";
                    num1 += "9";
                }
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                buttonPlus.BackColor = Color.Gray;
                buttonMinusPlus.BackColor = Color.Gray;
                Screen.Text = "";
                operation = "+";
            }
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                buttonMinus.BackColor = Color.Gray;
                buttonMinusPlus.BackColor = Color.Gray;
                Screen.Text = "";
                operation = "-";
            }
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                buttonMultiply.BackColor = Color.Gray;
                buttonMinusPlus.BackColor = Color.Gray;
                Screen.Text = "";
                operation = "*";
            }
        }
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                buttonDivision.BackColor = Color.Gray;
                buttonMinusPlus.BackColor = Color.Gray;
                Screen.Text = "";
                operation = "/";
            }
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                switch (operation)
                {
                    case "+":
                        buttonPlus.BackColor = Color.DodgerBlue;
                        buttonMinusPlus.BackColor = Color.Gray;
                        Screen.Text = "";
                        num1Double = double.Parse(num1);
                        num2Double = double.Parse(num2);
                        result = num1Double + num2Double;
                        Screen.Text = result.ToString();
                        break;
                    case "-":
                        buttonMinus.BackColor = Color.LimeGreen;
                        buttonMinusPlus.BackColor = Color.Gray;
                        Screen.Text = "";
                        num1Double = double.Parse(num1);
                        num2Double = double.Parse(num2);
                        result = num1Double - num2Double;
                        Screen.Text = result.ToString();
                        break;
                    case "*":
                        buttonMultiply.BackColor = Color.Orange;
                        buttonMinusPlus.BackColor = Color.Gray;
                        Screen.Text = "";
                        num1Double = double.Parse(num1);
                        num2Double = double.Parse(num2);
                        result = num1Double * num2Double;
                        Screen.Text = result.ToString();
                        break;

                    case "/":
                        buttonDivision.BackColor = Color.Salmon;
                        buttonMinusPlus.BackColor = Color.Gray;
                        Screen.Text = "";
                        num1Double = double.Parse(num1);
                        num2Double = double.Parse(num2);
                        result = num1Double / num2Double;
                        Screen.Text = result.ToString();
                        if (num2 == "0")
                        {
                            Screen.Text = "Error";
                        }
                        break;
                }
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            Screen.Text = "";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                if (buttonPlus.BackColor == Color.Gray || buttonMultiply.BackColor == Color.Gray ||
                        buttonMinus.BackColor == Color.Gray || buttonDivision.BackColor == Color.Gray)
                {
                    num2 += ".";
                    Screen.Text += ".";
                }
                else
                {
                    num1 += ".";
                    Screen.Text += ".";
                }
            }
        }
        private void buttonMinusPlus_Click(object sender, EventArgs e)
        {
            if (buttonOnOff.BackColor == Color.Red)
            {
                Screen.Text = "Please Turn On Calculator";
            }
            else
            {
                if (buttonPlus.BackColor == Color.Gray || buttonMultiply.BackColor == Color.Gray ||
                        buttonMinus.BackColor == Color.Gray || buttonDivision.BackColor == Color.Gray)
                {
                    buttonMinusPlus.BackColor = Color.Red;
                    num2 = "-";
                    Screen.Text = "-";
                }
                else
                {
                    buttonMinusPlus.BackColor = Color.Red;
                    num1 = "-";
                    Screen.Text = "-";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
       
 


