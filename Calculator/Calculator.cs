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
        /// Determines whether or not to calculate trig functions
        /// in radians or degrees
        /// </summary>
        private bool inDeg = false;
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
        private void Calculator_Load(object sender, EventArgs e)
        {
            btnExponent.Text = "x\u207f";
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
        #region FormButtons
        /// <summary>
        /// Button Pressed
        /// 
        /// Hides some form elements and expands a panel
        /// 
        /// uses guna2 to animage
        /// </summary>
        private void btnOpenPanel_Click(object sender, EventArgs e)
        {
            ExtraPanel.Visible = false; // Hide Panel
            btnOpenPanel.Visible = false; // Hides "Open Panel" Button
            ExtraPanel.Width = 288; // Change Panel Width
            guna2Transition1.ShowSync(ExtraPanel); // Shows Panel with cool animation
        }
        /// <summary>
        /// Button Pressed
        /// 
        /// Hides/Shows form elements and collapses a panel
        /// 
        /// Uses guna2 to animate
        /// </summary>
        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            ExtraPanel.Visible = false; // Hides Panel
            btnOpenPanel.Visible = true; // Shows "Open Panel" button
            ExtraPanel.Width = 82; // Changes Panel Width
            guna2Transition1.ShowSync(ExtraPanel); // Collapses Panel with cool animation
        }
        /// <summary>
        /// Calculates Trig functions in Degrees
        /// </summary>
        private void btnDeg_Click(object sender, EventArgs e)
        {
            // Show btnDeg is selected
            btnDeg.TextColor = Color.White;
            btnDeg.ButtonColor = Color.FromArgb(43, 105, 255);
            // show btnRad has been switch / deselected
            btnRad.TextColor = Color.Black;
            btnRad.ButtonColor = Color.White;

            inDeg = false;
        }
        /// <summary>
        /// Calculates Trig functions in Radians
        /// </summary>
        private void btnRad_Click(object sender, EventArgs e)
        {
            // Show btnRad is selected
            btnRad.TextColor = Color.White;
            btnRad.ButtonColor = Color.FromArgb(43, 105, 255);
            // show btnDeg has been switch / deselected
            btnDeg.TextColor = Color.Black;
            btnDeg.ButtonColor = Color.White;

            inDeg = true;
        }
        #endregion
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
            /*
            foreach (string ch in toPostFix(TokenizeEquation(txtOutput.Text))) {
                Console.WriteLine(ch);
            }*/
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
        /// <summary>
        /// Button Pressed
        /// Adds '.' to textbox
        /// </summary>
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText(".");
        }
        /// <summary>
        /// Button Pressed
        /// Adds 'sin(' to textbox
        /// </summary>
        private void btnSin_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("sin(");
        }
        /// <summary>
        /// Button Pressed
        /// Adds 'cos(' to textbox
        /// </summary>
        private void btnCos_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("cos(");
        }
        /// <summary>
        /// Button Pressed
        /// Adds 'tan(' to textbox
        /// </summary>
        private void btnTan_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("tan(");
        }
        /// <summary>
        /// Button Pressed
        /// Adds 'log(' to textbox
        /// </summary>
        private void btnLog_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("log(");
        }
        /// <summary>
        /// Button Pressed
        /// Adds 'ln(' to textbox
        /// </summary>
        private void btnLn_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("ln(");
        }
        #endregion
        /*********************************
              Shunting-yard Algorithm
        **********************************/
        #region shunting-yard Algorithm
        /// <summary>
        /// Converts Infix equation to a Postfix equation
        /// Original sample came from GeeksForGeeks, More understanding and
        /// conteptual ideas from Comp Sci in 5 from Youtube
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
                    double chNum;
                    //bool isNum = Int32.TryParse(ch, out chNum); // check if character is a number
                    bool isNum = Double.TryParse(ch, out chNum);
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
                        while (stack.Count > 0 && stack.Peek() != "(") // while the stack has items and the item is not a closing bracket
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
                MessageBox.Show(err.ToString());
                txtOutput.Text = "Syntax Error"; // if for any reason an error was thrown, display syntax error
                return new List<string>();
            }
        }
        /// <summary>
        /// Evaluates a Postfix Equation
        /// Original sample came from GeeksForGeeks, More understanding and
        /// conteptual ideas from Comp Sci in 5 from Youtube
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
                        a = Convert.ToDouble(sb); // convert string to double
                        b = Convert.ToDouble(sa); // convert string to double
                        ans = a + b; // calculates first + second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("—")) // if character is a '-' sign
                    {
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = (string)stack.Pop();
                        a = Convert.ToDouble(sb); // convert string to double
                        b = Convert.ToDouble(sa); // convert string to double
                        ans = a - b; // calculates first - second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("x")) // if character is a 'x' sign
                    {
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = (string)stack.Pop(); // get second number in stack
                        a = Convert.ToDouble(sb); // convert string to double
                        b = Convert.ToDouble(sa); // convert string to double
                        ans = a * b; // calculates first x second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("/")) // if character is a '/' sign
                    {
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = (string)stack.Pop(); // get second number in stack
                        a = Convert.ToDouble(sb); // convert string to double
                        b = Convert.ToDouble(sa); // convert string to double
                        ans = a / b; // calculates first / second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("^"))
                    { // if character is a '^' sign
                        string sa = (string)stack.Pop(); // get first number in stack
                        string sb = (string)stack.Pop(); // get second number in stack
                        a = Convert.ToDouble(sb); // convert string to double
                        b = Convert.ToDouble(sa); // convert string to double
                        ans = Math.Pow(a, b); // calculates first / second
                        stack.Push(ans.ToString()); // adds answer to stack
                    }
                    else if (ch.Equals("ln"))
                    {
                        string sa = (string)stack.Pop(); // get first number in stack
                        a = Convert.ToDouble(sa); // convert string to double
                        ans = Math.Log(a); // calculate log of number
                        stack.Push(ans.ToString()); // push number to stack
                    }
                    else if (ch.Equals("log"))
                    {
                        string sa = (string)stack.Pop();
                        a = Convert.ToDouble(sa);
                        ans = Math.Log(a, 10);
                        stack.Push(ans.ToString());
                    }
                    else if (ch.Equals("sin"))
                    {
                        if (inDeg)
                        {
                            string sa = (string)stack.Pop();
                            a = Convert.ToDouble(sa);
                            ans = Math.Sin(a);
                        }
                        else
                        {
                            string sa = (string)stack.Pop();
                            a = Convert.ToDouble(sa);
                            ans = Math.Sin((Math.PI / 180) * a); // Multiple a by pi/180 to convert to radians
                        }
                        ans = Math.Round(ans, 3);
                        stack.Push(ans.ToString());

                    }
                    else if (ch.Equals("cos"))
                    {
                        if (inDeg)
                        {
                            string sa = (string)stack.Pop();
                            a = Convert.ToDouble(sa);
                            ans = Math.Cos(a);
                        }
                        else
                        {
                            string sa = (string)stack.Pop();
                            a = Convert.ToDouble(sa);
                            ans = Math.Cos((Math.PI / 180) * a); // Multiple a by pi/180 to convert to radians
                        }
                        ans = Math.Round(ans, 3);
                        stack.Push(ans.ToString());
                    }
                    else if (ch.Equals("tan"))
                    {
                        if (inDeg)
                        {
                            string sa = (string)stack.Pop();
                            a = Convert.ToDouble(sa);
                            ans = Math.Tan(a);
                        }
                        else
                        {
                            string sa = (string)stack.Pop();
                            a = Convert.ToDouble(sa);
                            ans = Math.Tan((Math.PI / 180) * a); // Multiple a by pi/180 to convert to radians
                        }
                        ans = Math.Round(ans, 3);
                        stack.Push(ans.ToString());
                    }
                    else if (ch.Equals("-")) {
                        string sa = (string)stack.Pop();
                        a = Convert.ToDouble(sa);
                        ans = -a;
                        stack.Push(ans.ToString());
                    }
                    else // if character is a number
                    {
                        stack.Push(PostFix[i]); // add number to stack
                    }


                }
                return (string)stack.Pop(); // final number in stack is the answer
                
            }
            catch (Exception err) {
                MessageBox.Show(err.ToString());
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
        /// 
        /// We Tokenize large number (i.e. 100) all as one token (['100']) vs tokenizing
        /// them as three seperate tokens (['1', '0', '0']) Otherwise the program
        /// Will think this is three seperate numbers
        /// </summary>
        /// <param name="equation">Equatoin to be tokenized</param>
        /// <returns>List of strings, i.e. the tokenized equation</returns>
        public List<string> TokenizeEquation(string equation)
        {
            var delimiters = new[] { '(', '+', '—', 'x', '/', ')', '^',}; // list of delimiters to separate from
            var buffer = ""; // buffer currently set to empty, used to determine large numbers
            var result = new List<string>(); // results stored as a list
            foreach (var ch in equation) // for each character in the equation
            {
                if (delimiters.Contains(ch)) // if the character is a delimiter
                {
                    if (buffer.Length > 0) result.Add(buffer); // add buffer to results
                    result.Add(ch.ToString()); // add character to results
                    buffer = ""; // clear buffer
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