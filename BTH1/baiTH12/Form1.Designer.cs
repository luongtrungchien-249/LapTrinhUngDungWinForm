namespace baiTH2
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
            this.lblinput = new System.Windows.Forms.Label();
            this.grbchucnang = new System.Windows.Forms.GroupBox();
            this.lblhienthi = new System.Windows.Forms.Button();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.txthienthi = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.radthuong = new System.Windows.Forms.RadioButton();
            this.radhoa = new System.Windows.Forms.RadioButton();
            this.grbchucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblinput
            // 
            this.lblinput.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinput.Location = new System.Drawing.Point(203, 104);
            this.lblinput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(161, 25);
            this.lblinput.TabIndex = 0;
            this.lblinput.Text = "Nhập họ và tên :";
            this.lblinput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblinput.Click += new System.EventHandler(this.lblhienthi_Click);
            // 
            // grbchucnang
            // 
            this.grbchucnang.Controls.Add(this.radhoa);
            this.grbchucnang.Controls.Add(this.radthuong);
            this.grbchucnang.Location = new System.Drawing.Point(257, 137);
            this.grbchucnang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbchucnang.Name = "grbchucnang";
            this.grbchucnang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbchucnang.Size = new System.Drawing.Size(305, 123);
            this.grbchucnang.TabIndex = 1;
            this.grbchucnang.TabStop = false;
            this.grbchucnang.Text = "Chọn kiểu chữ";
            // 
            // lblhienthi
            // 
            this.lblhienthi.Location = new System.Drawing.Point(257, 268);
            this.lblhienthi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblhienthi.Name = "lblhienthi";
            this.lblhienthi.Size = new System.Drawing.Size(88, 28);
            this.lblhienthi.TabIndex = 2;
            this.lblhienthi.Text = "Kết Quả ";
            this.lblhienthi.UseVisualStyleBackColor = true;
            this.lblhienthi.Click += new System.EventHandler(this.txtHienthi_Click);
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(363, 106);
            this.txtinput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(271, 23);
            this.txtinput.TabIndex = 3;
            this.txtinput.TextChanged += new System.EventHandler(this.txtinput_TextChanged);
            // 
            // txthienthi
            // 
            this.txthienthi.Location = new System.Drawing.Point(363, 273);
            this.txthienthi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txthienthi.Name = "txthienthi";
            this.txthienthi.Size = new System.Drawing.Size(271, 23);
            this.txthienthi.TabIndex = 3;
            this.txthienthi.TextChanged += new System.EventHandler(this.txthienthi_TextChanged);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(575, 147);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(59, 113);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // radthuong
            // 
            this.radthuong.AutoSize = true;
            this.radthuong.Location = new System.Drawing.Point(46, 34);
            this.radthuong.Name = "radthuong";
            this.radthuong.Size = new System.Drawing.Size(90, 20);
            this.radthuong.TabIndex = 0;
            this.radthuong.TabStop = true;
            this.radthuong.Text = "chữ thường";
            this.radthuong.UseVisualStyleBackColor = true;
            this.radthuong.CheckedChanged += new System.EventHandler(this.radthuong_CheckedChanged);
            // 
            // radhoa
            // 
            this.radhoa.AutoSize = true;
            this.radhoa.Location = new System.Drawing.Point(46, 74);
            this.radhoa.Name = "radhoa";
            this.radhoa.Size = new System.Drawing.Size(79, 20);
            this.radhoa.TabIndex = 1;
            this.radhoa.TabStop = true;
            this.radhoa.Text = "CHỮ HOA";
            this.radhoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.txthienthi);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.lblhienthi);
            this.Controls.Add(this.grbchucnang);
            this.Controls.Add(this.lblinput);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbchucnang.ResumeLayout(false);
            this.grbchucnang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.GroupBox grbchucnang;
        private System.Windows.Forms.Button lblhienthi;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.TextBox txthienthi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.RadioButton radhoa;
        private System.Windows.Forms.RadioButton radthuong;
    }
}

