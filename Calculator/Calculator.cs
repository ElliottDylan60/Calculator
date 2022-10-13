using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
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
        /// External Classed use to convert/calculate infix and postfix equations
        /// </summary>
        private Calc calculate = new Calc();
        /// <summary>
        /// List of Error Types to check for before calling syntax error
        /// </summary>
        List<string> ErrorTypes = new List<string>() {"Divide By Zero", "Syntax Error"};
        string open = "(";
        string close = ")";
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
            btnOpenSoft.ContextMenuStrip = BracketMenu;
            btnCloseSoft.ContextMenuStrip = BracketMenu;
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
        /// Button that closes the form
        /// 
        /// No other action needed
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Button Pressed
        /// 
        /// Hides some form elements and expands a panel
        /// 
        /// uses guna2 to animate
        /// 
        /// Guna2 is a library used to make the UI look nicer. It addes
        /// gradiants, animations, buttons, and more
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

            calculate.inDeg = false;
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

            calculate.inDeg = true;
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
            txtOutput.AppendText(open); // Adds '(' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Add ')' to textbox
        /// </summary>
        private void btnCloseSoft_Click(object sender, EventArgs e) {
            txtOutput.AppendText(close); // Adds ')' to textbox
        }
        /// <summary>
        /// Button Pressed
        /// Displays equation result
        /// </summary>
        private void btnEqual_Click(object sender, EventArgs e)
        {
            // Check if user entered an equation
            if (txtOutput.Text == "") {
                return; // dont do anything if the user has not entered anything in yet
            }
            txtOutput.Text = txtOutput.Text.Replace('{', '(');
            txtOutput.Text = txtOutput.Text.Replace('}', ')');

            List<string> token = calculate.TokenizeEquation(txtOutput.Text); // tokenizes given equation
            List<string> postfix = calculate.toPostFix(token); // infix to postix
            string result = calculate.PostFixEvaluator(postfix); // postfix evaluator
            if (result.Equals("∞") || result.Equals("-∞")) // Result is too large to display
                result = "Overflow"; // print "Overflow"
            double chNum;
            if (!result.Equals("Overflow") && !Double.TryParse(result, out chNum) && !ErrorTypes.Contains(result)) // There was no overflow and result is not a number
                result = "Syntax Error";
            txtOutput.Text = result; // show user results
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
        /// <summary>
        /// Button Pressed
        /// Adds 'cot(' to textbox
        /// </summary>
        private void btnCot_Click(object sender, EventArgs e)
        {
            txtOutput.AppendText("cot(");
        }
        #endregion

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btnOpenSoft.Text = "(";
            btnCloseSoft.Text = ")";
            open = "(";
            close = ")";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            btnOpenSoft.Text = "{";
            btnCloseSoft.Text = "}";
            open = "{";
            close = "}";
        }
    }
}