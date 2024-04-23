namespace Auto_Key_Presser
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.IntervalPanel = new System.Windows.Forms.Panel();
            this.IntervalSaveBtn = new System.Windows.Forms.Button();
            this.OffsetTxtBox = new System.Windows.Forms.TextBox();
            this.IntervalTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PressTypePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxProgressLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.INPUTS = new System.Windows.Forms.Label();
            this.amount5 = new System.Windows.Forms.TextBox();
            this.amount4 = new System.Windows.Forms.TextBox();
            this.amount3 = new System.Windows.Forms.TextBox();
            this.amount2 = new System.Windows.Forms.TextBox();
            this.amount1 = new System.Windows.Forms.TextBox();
            this.KeyTxtBox5 = new System.Windows.Forms.TextBox();
            this.KeyTxtBox4 = new System.Windows.Forms.TextBox();
            this.KeyTxtBox3 = new System.Windows.Forms.TextBox();
            this.KeyTxtBox2 = new System.Windows.Forms.TextBox();
            this.KeyTxtBox = new System.Windows.Forms.TextBox();
            this.LeftMouseRdBtn = new System.Windows.Forms.RadioButton();
            this.IntervalProgressBar = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IntervalPanel.SuspendLayout();
            this.PressTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(151, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 11000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interval";
            // 
            // IntervalPanel
            // 
            this.IntervalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntervalPanel.Controls.Add(this.IntervalSaveBtn);
            this.IntervalPanel.Controls.Add(this.OffsetTxtBox);
            this.IntervalPanel.Controls.Add(this.IntervalTxtBox);
            this.IntervalPanel.Controls.Add(this.label3);
            this.IntervalPanel.Controls.Add(this.label5);
            this.IntervalPanel.Controls.Add(this.label4);
            this.IntervalPanel.Controls.Add(this.label1);
            this.IntervalPanel.Location = new System.Drawing.Point(12, 12);
            this.IntervalPanel.Name = "IntervalPanel";
            this.IntervalPanel.Size = new System.Drawing.Size(260, 62);
            this.IntervalPanel.TabIndex = 3;
            // 
            // IntervalSaveBtn
            // 
            this.IntervalSaveBtn.Location = new System.Drawing.Point(162, 13);
            this.IntervalSaveBtn.Name = "IntervalSaveBtn";
            this.IntervalSaveBtn.Size = new System.Drawing.Size(85, 32);
            this.IntervalSaveBtn.TabIndex = 3;
            this.IntervalSaveBtn.Text = "Save";
            this.IntervalSaveBtn.UseVisualStyleBackColor = true;
            this.IntervalSaveBtn.Click += new System.EventHandler(this.IntervalSaveBtn_Click);
            // 
            // OffsetTxtBox
            // 
            this.OffsetTxtBox.Location = new System.Drawing.Point(61, 33);
            this.OffsetTxtBox.Name = "OffsetTxtBox";
            this.OffsetTxtBox.Size = new System.Drawing.Size(71, 20);
            this.OffsetTxtBox.TabIndex = 2;
            this.OffsetTxtBox.Text = "0";
            this.toolTip1.SetToolTip(this.OffsetTxtBox, "A random offset in milliseconds between 0 and your offset that gets added on to y" +
        "our total interval. Use this in games and applications if you are woried about b" +
        "eing detected for botting.");
            // 
            // IntervalTxtBox
            // 
            this.IntervalTxtBox.Location = new System.Drawing.Point(61, 7);
            this.IntervalTxtBox.Name = "IntervalTxtBox";
            this.IntervalTxtBox.Size = new System.Drawing.Size(71, 20);
            this.IntervalTxtBox.TabIndex = 1;
            this.IntervalTxtBox.Text = "3750";
            this.toolTip1.SetToolTip(this.IntervalTxtBox, "The interval in milliseconds that each key press will take place.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add Rand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ms";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(179, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Done";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(182, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "To Do";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // PressTypePanel
            // 
            this.PressTypePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PressTypePanel.Controls.Add(this.label10);
            this.PressTypePanel.Controls.Add(this.label7);
            this.PressTypePanel.Controls.Add(this.label9);
            this.PressTypePanel.Controls.Add(this.MaxProgressLbl);
            this.PressTypePanel.Controls.Add(this.label8);
            this.PressTypePanel.Controls.Add(this.INPUTS);
            this.PressTypePanel.Controls.Add(this.amount5);
            this.PressTypePanel.Controls.Add(this.amount4);
            this.PressTypePanel.Controls.Add(this.amount3);
            this.PressTypePanel.Controls.Add(this.amount2);
            this.PressTypePanel.Controls.Add(this.amount1);
            this.PressTypePanel.Controls.Add(this.KeyTxtBox5);
            this.PressTypePanel.Controls.Add(this.KeyTxtBox4);
            this.PressTypePanel.Controls.Add(this.KeyTxtBox3);
            this.PressTypePanel.Controls.Add(this.KeyTxtBox2);
            this.PressTypePanel.Controls.Add(this.KeyTxtBox);
            this.PressTypePanel.Controls.Add(this.LeftMouseRdBtn);
            this.PressTypePanel.Location = new System.Drawing.Point(12, 81);
            this.PressTypePanel.Name = "PressTypePanel";
            this.PressTypePanel.Size = new System.Drawing.Size(260, 219);
            this.PressTypePanel.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "0s";
            // 
            // MaxProgressLbl
            // 
            this.MaxProgressLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MaxProgressLbl.AutoEllipsis = true;
            this.MaxProgressLbl.Location = new System.Drawing.Point(207, 198);
            this.MaxProgressLbl.Name = "MaxProgressLbl";
            this.MaxProgressLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaxProgressLbl.Size = new System.Drawing.Size(48, 13);
            this.MaxProgressLbl.TabIndex = 11;
            this.MaxProgressLbl.Text = "0";
            this.MaxProgressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "AMOUNT";
            // 
            // INPUTS
            // 
            this.INPUTS.AutoSize = true;
            this.INPUTS.Location = new System.Drawing.Point(32, 45);
            this.INPUTS.Name = "INPUTS";
            this.INPUTS.Size = new System.Drawing.Size(47, 13);
            this.INPUTS.TabIndex = 21;
            this.INPUTS.Text = "INPUTS";
            this.INPUTS.Click += new System.EventHandler(this.INPUTS_Click);
            // 
            // amount5
            // 
            this.amount5.Location = new System.Drawing.Point(151, 165);
            this.amount5.Name = "amount5";
            this.amount5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amount5.Size = new System.Drawing.Size(90, 20);
            this.amount5.TabIndex = 20;
            this.amount5.Text = "0";
            // 
            // amount4
            // 
            this.amount4.Location = new System.Drawing.Point(151, 139);
            this.amount4.Name = "amount4";
            this.amount4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amount4.Size = new System.Drawing.Size(90, 20);
            this.amount4.TabIndex = 19;
            this.amount4.Text = "0";
            // 
            // amount3
            // 
            this.amount3.Location = new System.Drawing.Point(151, 114);
            this.amount3.Name = "amount3";
            this.amount3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amount3.Size = new System.Drawing.Size(90, 20);
            this.amount3.TabIndex = 18;
            this.amount3.Text = "0";
            // 
            // amount2
            // 
            this.amount2.Location = new System.Drawing.Point(150, 87);
            this.amount2.Name = "amount2";
            this.amount2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amount2.Size = new System.Drawing.Size(90, 20);
            this.amount2.TabIndex = 17;
            this.amount2.Text = "0";
            // 
            // amount1
            // 
            this.amount1.Location = new System.Drawing.Point(150, 61);
            this.amount1.Name = "amount1";
            this.amount1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.amount1.Size = new System.Drawing.Size(90, 20);
            this.amount1.TabIndex = 16;
            this.amount1.Text = "0";
            this.amount1.TextChanged += new System.EventHandler(this.amount1_TextChanged);
            // 
            // KeyTxtBox5
            // 
            this.KeyTxtBox5.Location = new System.Drawing.Point(32, 165);
            this.KeyTxtBox5.Name = "KeyTxtBox5";
            this.KeyTxtBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KeyTxtBox5.Size = new System.Drawing.Size(90, 20);
            this.KeyTxtBox5.TabIndex = 15;
            this.KeyTxtBox5.Text = "{ENTER}";
            this.KeyTxtBox5.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // KeyTxtBox4
            // 
            this.KeyTxtBox4.Location = new System.Drawing.Point(32, 139);
            this.KeyTxtBox4.Name = "KeyTxtBox4";
            this.KeyTxtBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KeyTxtBox4.Size = new System.Drawing.Size(90, 20);
            this.KeyTxtBox4.TabIndex = 13;
            this.KeyTxtBox4.Text = "{ENTER}";
            this.KeyTxtBox4.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // KeyTxtBox3
            // 
            this.KeyTxtBox3.Location = new System.Drawing.Point(32, 113);
            this.KeyTxtBox3.Name = "KeyTxtBox3";
            this.KeyTxtBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KeyTxtBox3.Size = new System.Drawing.Size(90, 20);
            this.KeyTxtBox3.TabIndex = 11;
            this.KeyTxtBox3.Text = "{ENTER}";
            this.KeyTxtBox3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // KeyTxtBox2
            // 
            this.KeyTxtBox2.Location = new System.Drawing.Point(32, 87);
            this.KeyTxtBox2.Name = "KeyTxtBox2";
            this.KeyTxtBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KeyTxtBox2.Size = new System.Drawing.Size(90, 20);
            this.KeyTxtBox2.TabIndex = 9;
            this.KeyTxtBox2.Text = "{ENTER}";
            this.KeyTxtBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // KeyTxtBox
            // 
            this.KeyTxtBox.Location = new System.Drawing.Point(32, 61);
            this.KeyTxtBox.Name = "KeyTxtBox";
            this.KeyTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KeyTxtBox.Size = new System.Drawing.Size(90, 20);
            this.KeyTxtBox.TabIndex = 7;
            this.KeyTxtBox.Text = "{ENTER}";
            this.KeyTxtBox.TextChanged += new System.EventHandler(this.KeyTxtBox_TextChanged);
            // 
            // LeftMouseRdBtn
            // 
            this.LeftMouseRdBtn.AutoSize = true;
            this.LeftMouseRdBtn.Location = new System.Drawing.Point(32, 25);
            this.LeftMouseRdBtn.Name = "LeftMouseRdBtn";
            this.LeftMouseRdBtn.Size = new System.Drawing.Size(112, 17);
            this.LeftMouseRdBtn.TabIndex = 5;
            this.LeftMouseRdBtn.Text = "Left Mouse Button";
            this.LeftMouseRdBtn.UseVisualStyleBackColor = true;
            this.LeftMouseRdBtn.CheckedChanged += new System.EventHandler(this.LeftMouseRdBtn_CheckedChanged);
            // 
            // IntervalProgressBar
            // 
            this.IntervalProgressBar.Location = new System.Drawing.Point(12, 296);
            this.IntervalProgressBar.Name = "IntervalProgressBar";
            this.IntervalProgressBar.Size = new System.Drawing.Size(260, 23);
            this.IntervalProgressBar.TabIndex = 5;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hotkey: CRTL + O";
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(111, 347);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(75, 23);
            this.about.TabIndex = 10;
            this.about.Text = "about";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(251, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "v1.0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 374);
            this.Controls.Add(this.about);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IntervalProgressBar);
            this.Controls.Add(this.PressTypePanel);
            this.Controls.Add(this.IntervalPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "Auto Crafter";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.IntervalPanel.ResumeLayout(false);
            this.IntervalPanel.PerformLayout();
            this.PressTypePanel.ResumeLayout(false);
            this.PressTypePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel IntervalPanel;
        private System.Windows.Forms.Button IntervalSaveBtn;
        private System.Windows.Forms.TextBox OffsetTxtBox;
        private System.Windows.Forms.TextBox IntervalTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PressTypePanel;
        private System.Windows.Forms.RadioButton LeftMouseRdBtn;
        private System.Windows.Forms.TextBox KeyTxtBox;
        private System.Windows.Forms.ProgressBar IntervalProgressBar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label MaxProgressLbl;
        private System.Windows.Forms.TextBox KeyTxtBox5;
        private System.Windows.Forms.TextBox KeyTxtBox4;
        private System.Windows.Forms.TextBox KeyTxtBox3;
        private System.Windows.Forms.TextBox KeyTxtBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label INPUTS;
        private System.Windows.Forms.TextBox amount5;
        private System.Windows.Forms.TextBox amount4;
        private System.Windows.Forms.TextBox amount3;
        private System.Windows.Forms.TextBox amount2;
        private System.Windows.Forms.TextBox amount1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Label label2;
    }
}

