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
using System.Runtime.CompilerServices;

namespace Calculator
{
    public partial class Calculator : Form
    {
        /// <summary>
        /// Keeps track of whether or not the user is pressing down on the application
        /// used to move the form when user presses down
        /// </summary>
        private bool mouseDown;
        /// <summary>
        /// Keeps track of the last position the form was in.
        /// used to move the form when user presses down
        /// </summary>
        private Point lastLocation;
        /// <summary>
        /// Format all Error Messages to look alike
        /// </summary>
        /// <param name="ErrorCode">Error Code, can be looked up at end of Form1.cs</param>
        /// <param name="LineNumber">LineNumber of where the error occured</param>
        public void ErrorMessage(Exception a, string ErrorCode, [CallerLineNumber] int LineNumber = 0)
        {
            try
            {

                MessageBox.Show(a.Message + "\n" +
                                "Error Code: " + ErrorCode + "\n" +
                                "Line: " + LineNumber +
                                a.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public Calculator()
        {
            InitializeComponent();
        }
        /*************************
               Drag and Drop
         *************************/
        /// <summary>
        /// When User presses down with the mouse on the form, this function keeps track of the mouse location and moves the form
        /// </summary>
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                mouseDown = true;// Mouse is pressed down: start moving form
                lastLocation = e.Location; // get location of mouse
            }
            catch (Exception a)
            {
                ErrorMessage(a, "Could Not Move Window");
            }
        }
        /// <summary>
        /// When User lifts up with the mouse on the form, this function tells the program to stop moving the form
        /// </summary>
        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                mouseDown = false;// Mouse is no longer pressed down: stop moving form
            }
            catch (Exception a)
            {
                ErrorMessage(a, "Could Not Move Window");
            }
        }
        /// <summary>
        /// When User presses down with the mouse on the form, this function keeps track of the mouse location and moves the form
        /// </summary>
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (mouseDown) // Mouse is pressed down: when mouse starts moving
                {

                    this.Location = new Point(
                        (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);// set new location of mouse

                    this.Update();// Moves form locatio to mouse location
                }
            }
            catch (Exception a)
            {
                ErrorMessage(a, "Could Not Move Window");
            }
        }
        /*****************
              BUTTONS
        ******************/
        #region numbers
        /// <summary>
        /// Button Pressed
        /// Add '0' to textbox
        /// </summary>
        private void btn0_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("0"); // Adds '0' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Add '1' to textbox
        /// </summary>
        private void btn1_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("1"); // Adds '1' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Add '2' to textbox
        /// </summary>
        private void btn2_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("2"); // Adds '2' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Add '3' to textbox
        /// </summary>
        private void btn3_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("3"); // Adds '3' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Add '4' to textbox
        /// </summary>
        private void btn4_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("4"); // Adds '4' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Add '5' to textbox
        /// </summary>
        private void btn5_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("5"); // Adds '5' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Add '6' to textbox
        /// </summary>
        private void btn6_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("6"); // Adds '6' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Add '7' to textbox
        /// </summary>
        private void btn7_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("7"); // Adds '7' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Add '8' to textbox
        /// </summary>
        private void btn8_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("8"); // Adds '8' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Add '9' to textbox
        /// </summary>
        private void btn9_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("9"); // Adds '9' to textbox
        }
        #endregion
        #region operators
        /// <summary>
        /// Button Pressed
        /// Clears textbox
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear(); // Clears textbox
        }
        /// <summary>
        /// Button Pressed
        /// Removes last character in textbox
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1); // removes last character in textbox
            }
            catch (ArgumentOutOfRangeException) { 
                // thrown when back button is pressed and output is empty
                // ignore
            }
        }
        /// <summary>
        /// Button Pressed
        /// Adds '(' to textbox
        /// </summary>
        private void btnOpenSoft_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("("); // Adds '(' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Add ')' to textbox
        /// </summary>
        private void btnCloseSoft_Click(object sender, EventArgs e) {
            txtOutput.AppendText(")"); // Adds ')' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Displays equation result
        /// </summary>
        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtOutput.Text = PostFixEvaluator(toPostFix(TokenizeEquation(txtOutput.Text))); // Calculates and displays answer
        }
        /// <summary>
        /// Button Pressed
        /// Adds '+' to textbox
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("+");  // Adds '+' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Adds '-' to textbox
        /// </summary>
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("—");  // Adds '-' to textbox //em— en-
        }
        /// <summary>
        /// Button Pressed
        /// Adds 'x' to textbox
        /// </summary>
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("x");  // Adds 'x' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Adds '/' to textbox
        /// </summary>
        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("/");  // Adds '/' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Adds '±' to textbox
        /// </summary>
        private void btnSign_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("-");
        }
        /// <summary>
        /// Button Pressed
        /// Adds '^' to textbox
        /// </summary>
        private void btnExponent_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("^");
        }
        #endregion
        /*********************************
              Shunting-yard Algorithm
        **********************************/
        #region shunting-yard Algorithm
        /// <summary>
        /// Converts Infix equation to a Postfix equation
        /// </summary>
        /// <param name="inFix">Tokenized original equation</param>
        /// <returns>Tokenized Infix equation</returns>
        private List<string> toPostFix(List<string> inFix) {
            try
            {
                List<string> result = new List<string>(); // result stack
                Stack<string> stack = new Stack<string>(); // temp stack
                for (int i = 0; i < inFix.Count; i++) // foreach character in tokenized infix equation
                {
                    string ch = inFix[i]; // get character
                    int chNum;
                    bool isNum = Int32.TryParse(ch, out chNum); // check if character is a number
                    if (isNum) // if character is a number
                    {
                        result.Add(ch); // add character to results
                    }
                    else if (ch == "(") // if open parenthesis
                    {
                        stack.Push(ch); // push to temp stack
                    }
                    else if (ch == ")") // if closed parenthesis
                    {
                        while (stack.Count > 0 && stack.Peek() != "(") // while the stack has items, check for closing parenthesis
                        {
                            result.Add(stack.Pop()); // add non-parehtnesis functions to results

                        }
                        if (stack.Count > 0 && stack.Peek() != "(") // if last element is not an open perenthesis
                        {
                            txtOutput.Text = "Syntax Error"; // couldn't find opening parenthesis throws syntax error
                        }
                        else
                        {
                            stack.Pop(); // found opening parenthesis, remove from stack (we dont want parenthesis in postfix equation)
                        }

                    }
                    else
                    {
                        while (stack.Count > 0 && precedence(ch) <= precedence(stack.Peek())) // check the precedence of currenct function to that in the stack
                        {
                            result.Add(stack.Pop()); // add to result if precedence is less
                        }
                        stack.Push(ch); // add to stack if precedence is more
                    }
                }
                while (stack.Count > 0) // while stack has any leftover function
                {
                    result.Add(stack.Pop()); // add them to results
                }
                if (result.Contains("(")) { // checks if original equation only had one open parenthesis
                    txtOutput.Text = "Syntax Error";
                    return new List<string>();
                }
                return result;
            }
            catch (Exception err) {
                txtOutput.Text = "Syntax Error"; // if for any reason an error was thrown, display syntax error
                return new List<string>();
            }
        }
        /// <summary>
        /// Evaluates a Postfix Equation
        /// </summary>
        /// <param name="PostFix">Postfix equation given as a token</param>
        /// <returns>number result of postfix equation</returns>
        private string PostFixEvaluator(List<string> PostFix) {
            try
            {
                Stack stack = new Stack(); // temp stack
                double a, b, ans; // first in stack, second in stack, some combination of the two
                for (int i = 0; i < PostFix.Count; i++) // foreach character in postfix equation
                {
                    string ch = PostFix[i]; // get character in equation
                    if (ch.Equals("+")) // if character is a '+' sign
                    {
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = (string)stack.Pop(); // get second number in stack
                        a = Convert.ToInt32(sb); // convert string to int
                        b = Convert.ToInt32(sa); // convert string to int
                        ans = a + b; // calculates first + second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("—")) // if character is a '-' sign
                    {
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = "0";
                        if (stack.Count != 0) {
                            sb = (string)stack.Pop(); // get second number in stack
                        }
                        a = Convert.ToInt32(sb); // convert string to int
                        b = Convert.ToInt32(sa); // convert string to int
                        ans = a - b; // calculates first - second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("x")) // if character is a 'x' sign
                    {
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = (string)stack.Pop(); // get second number in stack
                        a = Convert.ToInt32(sb); // convert string to int
                        b = Convert.ToInt32(sa); // convert string to int
                        ans = a * b; // calculates first x second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("/")) // if character is a '/' sign
                    {
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = (string)stack.Pop(); // get second number in stack
                        a = Convert.ToInt32(sb); // convert string to int
                        b = Convert.ToInt32(sa); // convert string to int
                        ans = a / b; // calculates first / second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("^")) { // if character is a '^' sign
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = (string)stack.Pop(); // get second number in stack
                        a = Convert.ToInt32(sb); // convert string to int
                        b = Convert.ToInt32(sa); // convert string to int
                        ans = Math.Pow(a, b); // calculates first / second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else // if character is a number
                    {
                        stack.Push(PostFix[i]); // add number to stack
                    }

                }
                return (string)stack.Pop(); // final nummber in stack is the answer
                
            }
            catch (Exception err) {
                txtOutput.Text = "Syntax Error"; // if for any reason an error was thrown, display syntax error
                return "Syntax Error";
            }
        }
        /// <summary>
        /// Determins the precedence of each operator
        /// </summary>
        /// <param name="op">operator as a string</param>
        /// <returns>precendce score as a number</returns>
        private int precedence(string op)
        {
            switch (op)
            {
                case "+":
                case "—":
                    return 1;
                case "x":
                case "/":
                    return 2;
                case "^":
                    return 3;
                case "-":
                    return 4;
            }
            return -1;
        }
        /// <summary>
        /// Tokenizes the equation to solve large and complex numbers/equations
        /// </summary>
        /// <param name="equation">Equatoin to be tokenized</param>
        /// <returns>List of strings, i.e. the tokenized equation</returns>
        public List<string> TokenizeEquation(string equation)
        {
            var delimiters = new[] { '(', '+', '—', 'x', '/', ')', '^' }; // list of delimiters to separate from
            var buffer = string.Empty; // buffer currently set to empty, used to determine large numbers
            var result = new List<string>(); // results
            foreach (var ch in equation) // for each character in the equation
            {
                if (delimiters.Contains(ch)) // if the character is a delimiter
                {
                    if (buffer.Length > 0) result.Add(buffer); // add buffer to results
                    result.Add(ch.ToString()); // add character to results
                    buffer = String.Empty; // clear buffer
                }
                else // if character is a number
                {
                    buffer += ch; // add character to buffer
                }
            }
            if (buffer.Length > 0) result.Add(buffer); // add buffer to results
            return result;
        }

        #endregion

        
    }
}
