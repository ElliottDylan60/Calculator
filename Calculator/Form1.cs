using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*****************
              BUTTONS
        ******************/
        #region numbers
        private void btn0_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("9");
        }
        #endregion
        #region operators
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);
            }
            catch (ArgumentOutOfRangeException) { 
                // thrown when back button is pressed and output is empty
                // ignore
            }
        }

        private void btnOpenSoft_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("(");
        }

        private void btnCloseSoft_Click(object sender, EventArgs e) {
            txtOutput.AppendText(")");
        }
        #endregion
        #region operators
        private void btnEqual_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PostFix: "+toPostFix());
            //Console.WriteLine(outputText);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("+");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("x");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("/");
        }
        #endregion
        #region shunting-yard Algorithm
        /// <summary>
        /// Converts infix to postfix
        /// </summary>
        private string toPostFix() {
            string result = "";
            string input = txtOutput.Text;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < input.Length; ++i) {
                char ch = input[i];
                if (char.IsDigit(ch)) // if character is number
                {
                    result += ch;
                }
                else if (ch == '(') // if character is open bracket
                {
                    stack.Push(ch);
                }
                else if (ch == ')') // if character is closing bracket
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result += stack.Pop();
                    }
                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        txtOutput.Text = "Syntax Error";
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else { 
                    while(stack.Count > 0 && precedence(ch) <= precedence(stack.Peek())){
                        result += stack.Pop();
                    }
                    stack.Push(ch);
                }
                

            }
            while (stack.Count > 0) {
                result += stack.Pop();
            }
            return result;
        }
        /// <summary>
        /// Determins the precedence of each operator
        /// </summary>
        private int precedence(char op) {
            switch (op) {
                case '+':
                case '-':
                    return 1;
                case 'x':
                case '/':
                    return 2;
                case '^':
                    return 3;
            }
            return -1;
        }
        #endregion

        
    }
}
