using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
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
        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtOutput.Text = PostFixEvaluator(toPostFix(TokenizeEquation(txtOutput.Text)));
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
        private List<string> toPostFix(List<string> inFix) {
            try
            {
                List<string> result = new List<string>();
                Stack<string> stack = new Stack<string>();
                for (int i = 0; i < inFix.Count; i++)
                {
                    string ch = inFix[i];
                    int chNum;
                    bool isNum = Int32.TryParse(ch, out chNum);
                    if (isNum)
                    {
                        result.Add(ch);
                    }
                    else if (ch == "(")
                    {
                        stack.Push(ch);
                    }
                    else if (ch == ")")
                    {
                        while (stack.Count > 0 && stack.Peek() != "(")
                        {
                            result.Add(stack.Pop());

                        }
                        if (stack.Count > 0 && stack.Peek() != "(")
                        {
                            txtOutput.Text = "Syntax Error";
                            Console.WriteLine("Syntax Error");
                        }
                        else
                        {
                            stack.Pop();
                        }

                    }
                    else
                    {
                        while (stack.Count > 0 && precedence(ch) <= precedence(stack.Peek()))
                        {
                            result.Add(stack.Pop());
                        }
                        stack.Push(ch);
                    }
                }
                while (stack.Count > 0)
                {
                    result.Add(stack.Pop());
                }
                return result;
            }
            catch (Exception err) {
                txtOutput.Text = "Syntax Error";
                return new List<string>();
            }
        }
        
        private string PostFixEvaluator(List<string> PostFix) {
            try
            {
                Stack stack = new Stack();
                int a, b, ans;
                for (int i = 0; i < PostFix.Count; i++)
                {
                    string ch = PostFix[i];
                    if (ch.Equals("+"))
                    {
                        string sa = (string)stack.Pop();
                        string sb = (string)stack.Pop();
                        a = Convert.ToInt32(sb);
                        b = Convert.ToInt32(sa);
                        ans = a + b;
                        stack.Push(ans.ToString());
                    }
                    else if (ch.Equals("-"))
                    {
                        string sa = (string)stack.Pop();
                        string sb = (string)stack.Pop();
                        a = Convert.ToInt32(sb);
                        b = Convert.ToInt32(sa);
                        ans = a - b;
                        stack.Push(ans.ToString());
                    }
                    else if (ch.Equals("x"))
                    {
                        string sa = (string)stack.Pop();
                        string sb = (string)stack.Pop();
                        a = Convert.ToInt32(sb);
                        b = Convert.ToInt32(sa);
                        ans = a * b;
                        stack.Push(ans.ToString());
                    }
                    else if (ch.Equals("/"))
                    {
                        string sa = (string)stack.Pop();
                        string sb = (string)stack.Pop();
                        a = Convert.ToInt32(sb);
                        b = Convert.ToInt32(sa);
                        ans = a / b;
                        stack.Push(ans.ToString());
                    }
                    else
                    {
                        stack.Push(PostFix[i]);
                    }

                }
                return (string)stack.Pop();
            }
            catch (Exception err) {
                txtOutput.Text = "Syntax Error";
                return "Syntax Error";
            }
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
        private int precedence(string op)
        {
            switch (op)
            {
                case "+":
                case "-":
                    return 1;
                case "x":
                case "/":
                    return 2;
                case "^":
                    return 3;
            }
            return -1;
        }
        #endregion

        public List<string> TokenizeEquation(string equation) {
            var delimiters = new[] { '(', '+', '-', 'x', '/', ')'};
            var buffer = string.Empty;
            var result = new List<string>();
            foreach (var ch in equation) {
                if (delimiters.Contains(ch)){
                    if (buffer.Length > 0) result.Add(buffer);
                    result.Add(ch.ToString());
                    buffer = String.Empty;
                }else {
                    buffer += ch;
                }
            }
            if (buffer.Length > 0) result.Add(buffer);
            return result;
        }
    }
}
