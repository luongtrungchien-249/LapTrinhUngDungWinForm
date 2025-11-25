namespace baiTH15
{
    partial class Form1
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
            this.lblnhapten = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.lblhienthi = new System.Windows.Forms.Label();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.grbfont = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.radred = new System.Windows.Forms.RadioButton();
            this.radgreen = new System.Windows.Forms.RadioButton();
            this.radblue = new System.Windows.Forms.RadioButton();
            this.radblack = new System.Windows.Forms.RadioButton();
            this.chkbold = new System.Windows.Forms.CheckBox();
            this.chkitalic = new System.Windows.Forms.CheckBox();
            this.chkunderline = new System.Windows.Forms.CheckBox();
            this.grbColor.SuspendLayout();
            this.grbfont.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnhapten
            // 
            this.lblnhapten.AutoSize = true;
            this.lblnhapten.Location = new System.Drawing.Point(265, 41);
            this.lblnhapten.Name = "lblnhapten";
            this.lblnhapten.Size = new System.Drawing.Size(64, 13);
            this.lblnhapten.TabIndex = 0;
            this.lblnhapten.Text = "Nhập Tên : ";
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Location = new System.Drawing.Point(265, 332);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(78, 13);
            this.lbloutput.TabIndex = 0;
            this.lbloutput.Text = "Lập Trình bới : ";
            this.lbloutput.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblhienthi
            // 
            this.lblhienthi.BackColor = System.Drawing.SystemColors.Control;
            this.lblhienthi.Location = new System.Drawing.Point(349, 324);
            this.lblhienthi.Name = "lblhienthi";
            this.lblhienthi.Size = new System.Drawing.Size(348, 29);
            this.lblhienthi.TabIndex = 0;
            this.lblhienthi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbColor
            // 
            this.grbColor.Controls.Add(this.radblack);
            this.grbColor.Controls.Add(this.radblue);
            this.grbColor.Controls.Add(this.radgreen);
            this.grbColor.Controls.Add(this.radred);
            this.grbColor.Location = new System.Drawing.Point(268, 76);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(152, 234);
            this.grbColor.TabIndex = 1;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "Color";
            // 
            // grbfont
            // 
            this.grbfont.Controls.Add(this.chkunderline);
            this.grbfont.Controls.Add(this.chkitalic);
            this.grbfont.Controls.Add(this.chkbold);
            this.grbfont.Location = new System.Drawing.Point(440, 76);
            this.grbfont.Name = "grbfont";
            this.grbfont.Size = new System.Drawing.Size(257, 234);
            this.grbfont.TabIndex = 1;
            this.grbfont.TabStop = false;
            this.grbfont.Text = "Font";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(622, 374);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 22);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(344, 38);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(353, 20);
            this.txtinput.TabIndex = 3;
            this.txtinput.TextChanged += new System.EventHandler(this.txtinput_TextChanged);
            // 
            // radred
            // 
            this.radred.AutoSize = true;
            this.radred.ForeColor = System.Drawing.Color.Red;
            this.radred.Location = new System.Drawing.Point(24, 46);
            this.radred.Name = "radred";
            this.radred.Size = new System.Drawing.Size(45, 17);
            this.radred.TabIndex = 0;
            this.radred.TabStop = true;
            this.radred.Text = "Red";
            this.radred.UseVisualStyleBackColor = true;
            this.radred.CheckedChanged += new System.EventHandler(this.radred_CheckedChanged);
            // 
            // radgreen
            // 
            this.radgreen.AutoSize = true;
            this.radgreen.ForeColor = System.Drawing.Color.Green;
            this.radgreen.Location = new System.Drawing.Point(24, 91);
            this.radgreen.Name = "radgreen";
            this.radgreen.Size = new System.Drawing.Size(54, 17);
            this.radgreen.TabIndex = 1;
            this.radgreen.TabStop = true;
            this.radgreen.Text = "Green";
            this.radgreen.UseVisualStyleBackColor = true;
            this.radgreen.CheckedChanged += new System.EventHandler(this.radgreen_CheckedChanged);
            // 
            // radblue
            // 
            this.radblue.AutoSize = true;
            this.radblue.ForeColor = System.Drawing.Color.Blue;
            this.radblue.Location = new System.Drawing.Point(24, 137);
            this.radblue.Name = "radblue";
            this.radblue.Size = new System.Drawing.Size(46, 17);
            this.radblue.TabIndex = 2;
            this.radblue.TabStop = true;
            this.radblue.Text = "Blue";
            this.radblue.UseVisualStyleBackColor = true;
            this.radblue.CheckedChanged += new System.EventHandler(this.radblue_CheckedChanged);
            // 
            // radblack
            // 
            this.radblack.AutoSize = true;
            this.radblack.Location = new System.Drawing.Point(24, 183);
            this.radblack.Name = "radblack";
            this.radblack.Size = new System.Drawing.Size(52, 17);
            this.radblack.TabIndex = 3;
            this.radblack.TabStop = true;
            this.radblack.Text = "Black";
            this.radblack.UseVisualStyleBackColor = true;
            this.radblack.CheckedChanged += new System.EventHandler(this.radblack_CheckedChanged);
            // 
            // chkbold
            // 
            this.chkbold.AutoSize = true;
            this.chkbold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbold.Location = new System.Drawing.Point(44, 46);
            this.chkbold.Name = "chkbold";
            this.chkbold.Size = new System.Drawing.Size(104, 17);
            this.chkbold.TabIndex = 0;
            this.chkbold.Text = "Đậm ( BOLD )";
            this.chkbold.UseVisualStyleBackColor = true;
            this.chkbold.CheckedChanged += new System.EventHandler(this.chkbold_CheckedChanged);
            // 
            // chkitalic
            // 
            this.chkitalic.AutoSize = true;
            this.chkitalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkitalic.Location = new System.Drawing.Point(44, 108);
            this.chkitalic.Name = "chkitalic";
            this.chkitalic.Size = new System.Drawing.Size(114, 17);
            this.chkitalic.TabIndex = 1;
            this.chkitalic.Text = "Nghiêng ( ITALIC )";
            this.chkitalic.UseVisualStyleBackColor = true;
            this.chkitalic.CheckedChanged += new System.EventHandler(this.chkitalic_CheckedChanged);
            // 
            // chkunderline
            // 
            this.chkunderline.AutoSize = true;
            this.chkunderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkunderline.Location = new System.Drawing.Point(44, 174);
            this.chkunderline.Name = "chkunderline";
            this.chkunderline.Size = new System.Drawing.Size(157, 17);
            this.chkunderline.TabIndex = 2;
            this.chkunderline.Text = "Gạch chân ( UNDERLINE )";
            this.chkunderline.UseVisualStyleBackColor = true;
            this.chkunderline.CheckedChanged += new System.EventHandler(this.chkunderline_CheckedChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(855, 427);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.grbfont);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblhienthi);
            this.Controls.Add(this.lblnhapten);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.grbfont.ResumeLayout(false);
            this.grbfont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblnhapten;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Label lblhienthi;
        private System.Windows.Forms.GroupBox grbColor;
        private System.Windows.Forms.GroupBox grbfont;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.RadioButton radblack;
        private System.Windows.Forms.RadioButton radblue;
        private System.Windows.Forms.RadioButton radgreen;
        private System.Windows.Forms.RadioButton radred;
        private System.Windows.Forms.CheckBox chkunderline;
        private System.Windows.Forms.CheckBox chkitalic;
        private System.Windows.Forms.CheckBox chkbold;
    }
}

