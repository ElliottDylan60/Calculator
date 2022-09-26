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
    }
}
