namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnCloseSoft = new System.Windows.Forms.Button();
            this.btnOpenSoft = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnAdd = new System.Windows.Forms.Label();
            this.btnSubtract = new System.Windows.Forms.Label();
            this.btnMultiply = new System.Windows.Forms.Label();
            this.btnDivide = new System.Windows.Forms.Label();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.ExtraPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnCot = new Guna.UI2.WinForms.Guna2Button();
            this.btnExponent = new Guna.UI2.WinForms.Guna2Button();
            this.btnLn = new Guna.UI2.WinForms.Guna2Button();
            this.btnLog = new Guna.UI2.WinForms.Guna2Button();
            this.btnTan = new Guna.UI2.WinForms.Guna2Button();
            this.btnCos = new Guna.UI2.WinForms.Guna2Button();
            this.btnSin = new Guna.UI2.WinForms.Guna2Button();
            this.btnClosePanel = new System.Windows.Forms.Label();
            this.btnOpenPanel = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.BracketMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new ePOSOne.btnProduct.Button_WOC();
            this.btnBack = new ePOSOne.btnProduct.Button_WOC();
            this.btnClear = new ePOSOne.btnProduct.Button_WOC();
            this.btnRad = new ePOSOne.btnProduct.Button_WOC();
            this.btnDeg = new ePOSOne.btnProduct.Button_WOC();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.ExtraPanel.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.BracketMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEqual
            // 
            this.guna2Transition1.SetDecoration(this.btnEqual, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnEqual.Location = new System.Drawing.Point(213, 408);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(70, 50);
            this.btnEqual.TabIndex = 1;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDecimal
            // 
            this.guna2Transition1.SetDecoration(this.btnDecimal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnDecimal.Location = new System.Drawing.Point(213, 184);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(70, 50);
            this.btnDecimal.TabIndex = 6;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btn0
            // 
            this.guna2Transition1.SetDecoration(this.btn0, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btn0.Location = new System.Drawing.Point(137, 408);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 50);
            this.btn0.TabIndex = 7;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnSign
            // 
            this.guna2Transition1.SetDecoration(this.btnSign, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(61, 408);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(70, 50);
            this.btnSign.TabIndex = 8;
            this.btnSign.Text = "(-)";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btn1
            // 
            this.guna2Transition1.SetDecoration(this.btn1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btn1.Location = new System.Drawing.Point(61, 352);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 50);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.guna2Transition1.SetDecoration(this.btn2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btn2.Location = new System.Drawing.Point(137, 352);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 50);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.guna2Transition1.SetDecoration(this.btn3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btn3.Location = new System.Drawing.Point(213, 352);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 50);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.guna2Transition1.SetDecoration(this.btn6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btn6.Location = new System.Drawing.Point(213, 296);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 50);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.guna2Transition1.SetDecoration(this.btn5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btn5.Location = new System.Drawing.Point(137, 296);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 50);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.guna2Transition1.SetDecoration(this.btn4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btn4.Location = new System.Drawing.Point(61, 296);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 50);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            this.guna2Transition1.SetDecoration(this.btn7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btn7.Location = new System.Drawing.Point(61, 240);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 50);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.guna2Transition1.SetDecoration(this.btn8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btn8.Location = new System.Drawing.Point(137, 240);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 50);
            this.btn8.TabIndex = 16;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.guna2Transition1.SetDecoration(this.btn9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btn9.Location = new System.Drawing.Point(213, 240);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 50);
            this.btn9.TabIndex = 17;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnCloseSoft
            // 
            this.guna2Transition1.SetDecoration(this.btnCloseSoft, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCloseSoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnCloseSoft.Location = new System.Drawing.Point(137, 184);
            this.btnCloseSoft.Name = "btnCloseSoft";
            this.btnCloseSoft.Size = new System.Drawing.Size(70, 50);
            this.btnCloseSoft.TabIndex = 21;
            this.btnCloseSoft.Text = ")";
            this.btnCloseSoft.UseVisualStyleBackColor = true;
            this.btnCloseSoft.Click += new System.EventHandler(this.btnCloseSoft_Click);
            // 
            // btnOpenSoft
            // 
            this.guna2Transition1.SetDecoration(this.btnOpenSoft, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnOpenSoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnOpenSoft.Location = new System.Drawing.Point(61, 184);
            this.btnOpenSoft.Name = "btnOpenSoft";
            this.btnOpenSoft.Size = new System.Drawing.Size(70, 50);
            this.btnOpenSoft.TabIndex = 22;
            this.btnOpenSoft.Text = "(";
            this.btnOpenSoft.UseVisualStyleBackColor = true;
            this.btnOpenSoft.Click += new System.EventHandler(this.btnOpenSoft_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Transition1.SetDecoration(this.txtOutput, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.Black;
            this.txtOutput.Location = new System.Drawing.Point(20, 45);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(325, 40);
            this.txtOutput.TabIndex = 28;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.BorderRadius = 40;
            this.guna2CustomGradientPanel1.Controls.Add(this.btnAdd);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSubtract);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnMultiply);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnDivide);
            this.guna2Transition1.SetDecoration(this.guna2CustomGradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(292, 155);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(188, 274);
            this.guna2CustomGradientPanel1.TabIndex = 32;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.btnAdd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "+";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.btnSubtract, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnSubtract.ForeColor = System.Drawing.Color.White;
            this.btnSubtract.Location = new System.Drawing.Point(10, 147);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(50, 50);
            this.btnSubtract.TabIndex = 35;
            this.btnSubtract.Text = "-";
            this.btnSubtract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.btnMultiply, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnMultiply.ForeColor = System.Drawing.Color.White;
            this.btnMultiply.Location = new System.Drawing.Point(10, 82);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(50, 50);
            this.btnMultiply.TabIndex = 34;
            this.btnMultiply.Text = "x";
            this.btnMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.btnDivide, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(10, 17);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(50, 50);
            this.btnDivide.TabIndex = 33;
            this.btnDivide.Text = "/";
            this.btnDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // ExtraPanel
            // 
            this.ExtraPanel.BackColor = System.Drawing.Color.Transparent;
            this.ExtraPanel.BorderColor = System.Drawing.Color.Transparent;
            this.ExtraPanel.BorderRadius = 40;
            this.ExtraPanel.Controls.Add(this.btnCot);
            this.ExtraPanel.Controls.Add(this.btnExponent);
            this.ExtraPanel.Controls.Add(this.btnLn);
            this.ExtraPanel.Controls.Add(this.btnLog);
            this.ExtraPanel.Controls.Add(this.btnTan);
            this.ExtraPanel.Controls.Add(this.btnCos);
            this.ExtraPanel.Controls.Add(this.btnSin);
            this.ExtraPanel.Controls.Add(this.btnClosePanel);
            this.ExtraPanel.Controls.Add(this.btnOpenPanel);
            this.ExtraPanel.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.ExtraPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ExtraPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.ExtraPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.ExtraPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.ExtraPanel.Location = new System.Drawing.Point(-36, 153);
            this.ExtraPanel.Name = "ExtraPanel";
            this.ExtraPanel.Size = new System.Drawing.Size(82, 274);
            this.ExtraPanel.TabIndex = 37;
            // 
            // btnCot
            // 
            this.guna2Transition1.SetDecoration(this.btnCot, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCot.ForeColor = System.Drawing.Color.White;
            this.btnCot.Location = new System.Drawing.Point(95, 211);
            this.btnCot.Name = "btnCot";
            this.btnCot.Size = new System.Drawing.Size(70, 50);
            this.btnCot.TabIndex = 46;
            this.btnCot.Text = "cot";
            this.btnCot.Click += new System.EventHandler(this.btnCot_Click);
            // 
            // btnExponent
            // 
            this.guna2Transition1.SetDecoration(this.btnExponent, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExponent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExponent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExponent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExponent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnExponent.ForeColor = System.Drawing.Color.White;
            this.btnExponent.Location = new System.Drawing.Point(171, 145);
            this.btnExponent.Name = "btnExponent";
            this.btnExponent.Size = new System.Drawing.Size(70, 50);
            this.btnExponent.TabIndex = 45;
            this.btnExponent.Click += new System.EventHandler(this.btnExponent_Click);
            // 
            // btnLn
            // 
            this.guna2Transition1.SetDecoration(this.btnLn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnLn.ForeColor = System.Drawing.Color.White;
            this.btnLn.Location = new System.Drawing.Point(95, 145);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(70, 50);
            this.btnLn.TabIndex = 44;
            this.btnLn.Text = "ln";
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnLog
            // 
            this.guna2Transition1.SetDecoration(this.btnLog, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(171, 77);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(70, 50);
            this.btnLog.TabIndex = 43;
            this.btnLog.Text = "log";
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnTan
            // 
            this.guna2Transition1.SetDecoration(this.btnTan, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnTan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTan.ForeColor = System.Drawing.Color.White;
            this.btnTan.Location = new System.Drawing.Point(95, 77);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(70, 50);
            this.btnTan.TabIndex = 42;
            this.btnTan.Text = "tan";
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnCos
            // 
            this.guna2Transition1.SetDecoration(this.btnCos, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.ForeColor = System.Drawing.Color.White;
            this.btnCos.Location = new System.Drawing.Point(171, 10);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(70, 50);
            this.btnCos.TabIndex = 41;
            this.btnCos.Text = "cos";
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.guna2Transition1.SetDecoration(this.btnSin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSin.ForeColor = System.Drawing.Color.White;
            this.btnSin.Location = new System.Drawing.Point(95, 10);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(70, 50);
            this.btnSin.TabIndex = 40;
            this.btnSin.Text = "sin";
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnClosePanel
            // 
            this.btnClosePanel.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.btnClosePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClosePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnClosePanel.ForeColor = System.Drawing.Color.White;
            this.btnClosePanel.Location = new System.Drawing.Point(247, 112);
            this.btnClosePanel.Name = "btnClosePanel";
            this.btnClosePanel.Size = new System.Drawing.Size(50, 50);
            this.btnClosePanel.TabIndex = 38;
            this.btnClosePanel.Text = "<";
            this.btnClosePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClosePanel.Click += new System.EventHandler(this.btnClosePanel_Click);
            // 
            // btnOpenPanel
            // 
            this.btnOpenPanel.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.btnOpenPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnOpenPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnOpenPanel.ForeColor = System.Drawing.Color.White;
            this.btnOpenPanel.Location = new System.Drawing.Point(31, 112);
            this.btnOpenPanel.Name = "btnOpenPanel";
            this.btnOpenPanel.Size = new System.Drawing.Size(50, 50);
            this.btnOpenPanel.TabIndex = 37;
            this.btnOpenPanel.Text = ">";
            this.btnOpenPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOpenPanel.Click += new System.EventHandler(this.btnOpenPanel_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnClose);
            this.guna2ShadowPanel1.Controls.Add(this.txtOutput);
            this.guna2Transition1.SetDecoration(this.guna2ShadowPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(-8, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(370, 112);
            this.guna2ShadowPanel1.TabIndex = 38;
            this.guna2ShadowPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.guna2ShadowPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.guna2ShadowPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // BracketMenu
            // 
            this.guna2Transition1.SetDecoration(this.BracketMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BracketMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.BracketMenu.Name = "BracketMenu";
            this.BracketMenu.Size = new System.Drawing.Size(83, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItem2.Text = "()";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItem3.Text = "{}";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::Calculator.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.ButtonColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Transition1.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(324, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClose.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnClose.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 39;
            this.btnClose.TextColor = System.Drawing.Color.Black;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = global::Calculator.Properties.Resources.Back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.BorderColor = System.Drawing.Color.Transparent;
            this.btnBack.ButtonColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Transition1.SetDecoration(this.btnBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(213, 118);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnBack.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnBack.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(70, 50);
            this.btnBack.TabIndex = 30;
            this.btnBack.TextColor = System.Drawing.Color.Black;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnClear.ButtonColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Transition1.SetDecoration(this.btnClear, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(61, 118);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnClear.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnClear.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnClear.Size = new System.Drawing.Size(70, 50);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "AC";
            this.btnClear.TextColor = System.Drawing.Color.Black;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRad
            // 
            this.btnRad.BackColor = System.Drawing.Color.White;
            this.btnRad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnRad.ButtonColor = System.Drawing.Color.White;
            this.btnRad.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Transition1.SetDecoration(this.btnRad, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRad.ForeColor = System.Drawing.Color.White;
            this.btnRad.Location = new System.Drawing.Point(145, 149);
            this.btnRad.Name = "btnRad";
            this.btnRad.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnRad.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnRad.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRad.Size = new System.Drawing.Size(60, 30);
            this.btnRad.TabIndex = 40;
            this.btnRad.Text = "rad";
            this.btnRad.TextColor = System.Drawing.Color.Black;
            this.btnRad.UseVisualStyleBackColor = false;
            this.btnRad.Click += new System.EventHandler(this.btnRad_Click);
            // 
            // btnDeg
            // 
            this.btnDeg.BackColor = System.Drawing.Color.White;
            this.btnDeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnDeg.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnDeg.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2Transition1.SetDecoration(this.btnDeg, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeg.ForeColor = System.Drawing.Color.White;
            this.btnDeg.Location = new System.Drawing.Point(145, 118);
            this.btnDeg.Name = "btnDeg";
            this.btnDeg.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnDeg.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.btnDeg.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeg.Size = new System.Drawing.Size(60, 30);
            this.btnDeg.TabIndex = 39;
            this.btnDeg.Text = "deg";
            this.btnDeg.TextColor = System.Drawing.Color.White;
            this.btnDeg.UseVisualStyleBackColor = false;
            this.btnDeg.Click += new System.EventHandler(this.btnDeg_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 465);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.ExtraPanel);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpenSoft);
            this.Controls.Add(this.btnCloseSoft);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnRad);
            this.Controls.Add(this.btnDeg);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ExtraPanel.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.BracketMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnCloseSoft;
        private System.Windows.Forms.Button btnOpenSoft;
        private System.Windows.Forms.TextBox txtOutput;
        private ePOSOne.btnProduct.Button_WOC btnClear;
        private ePOSOne.btnProduct.Button_WOC btnBack;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label btnDivide;
        private System.Windows.Forms.Label btnAdd;
        private System.Windows.Forms.Label btnSubtract;
        private System.Windows.Forms.Label btnMultiply;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel ExtraPanel;
        private System.Windows.Forms.Label btnOpenPanel;
        private System.Windows.Forms.Label btnClosePanel;
        private Guna.UI2.WinForms.Guna2Button btnSin;
        private Guna.UI2.WinForms.Guna2Button btnTan;
        private Guna.UI2.WinForms.Guna2Button btnCos;
        private Guna.UI2.WinForms.Guna2Button btnLn;
        private Guna.UI2.WinForms.Guna2Button btnLog;
        private Guna.UI2.WinForms.Guna2Button btnExponent;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private ePOSOne.btnProduct.Button_WOC btnClose;
        private ePOSOne.btnProduct.Button_WOC btnDeg;
        private ePOSOne.btnProduct.Button_WOC btnRad;
        private Guna.UI2.WinForms.Guna2Button btnCot;
        private System.Windows.Forms.ContextMenuStrip BracketMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

