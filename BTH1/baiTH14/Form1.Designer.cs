namespace baiTH14
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
            this.lblinta = new System.Windows.Forms.Label();
            this.lblintb = new System.Windows.Forms.Label();
            this.lblketqua = new System.Windows.Forms.Label();
            this.txtinta = new System.Windows.Forms.TextBox();
            this.txtintb = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.grbtinhtoan = new System.Windows.Forms.GroupBox();
            this.radchia = new System.Windows.Forms.RadioButton();
            this.radnhan = new System.Windows.Forms.RadioButton();
            this.radtru = new System.Windows.Forms.RadioButton();
            this.radcong = new System.Windows.Forms.RadioButton();
            this.grbtinhtoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblinta
            // 
            this.lblinta.AutoSize = true;
            this.lblinta.Location = new System.Drawing.Point(219, 81);
            this.lblinta.Name = "lblinta";
            this.lblinta.Size = new System.Drawing.Size(38, 13);
            this.lblinta.TabIndex = 0;
            this.lblinta.Text = "SỐ A :";
            // 
            // lblintb
            // 
            this.lblintb.AutoSize = true;
            this.lblintb.Location = new System.Drawing.Point(219, 143);
            this.lblintb.Name = "lblintb";
            this.lblintb.Size = new System.Drawing.Size(38, 13);
            this.lblintb.TabIndex = 0;
            this.lblintb.Text = "SỐ B :";
            this.lblintb.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(203, 310);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(52, 13);
            this.lblketqua.TabIndex = 0;
            this.lblketqua.Text = "Kết Quả :";
            // 
            // txtinta
            // 
            this.txtinta.Location = new System.Drawing.Point(293, 78);
            this.txtinta.Name = "txtinta";
            this.txtinta.Size = new System.Drawing.Size(412, 20);
            this.txtinta.TabIndex = 1;
            // 
            // txtintb
            // 
            this.txtintb.Location = new System.Drawing.Point(293, 140);
            this.txtintb.Name = "txtintb";
            this.txtintb.Size = new System.Drawing.Size(412, 20);
            this.txtintb.TabIndex = 1;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(282, 307);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(423, 20);
            this.txtketqua.TabIndex = 1;
            // 
            // grbtinhtoan
            // 
            this.grbtinhtoan.Controls.Add(this.radchia);
            this.grbtinhtoan.Controls.Add(this.radnhan);
            this.grbtinhtoan.Controls.Add(this.radtru);
            this.grbtinhtoan.Controls.Add(this.radcong);
            this.grbtinhtoan.Location = new System.Drawing.Point(193, 190);
            this.grbtinhtoan.Name = "grbtinhtoan";
            this.grbtinhtoan.Size = new System.Drawing.Size(512, 100);
            this.grbtinhtoan.TabIndex = 2;
            this.grbtinhtoan.TabStop = false;
            this.grbtinhtoan.Text = "Phép tính";
            // 
            // radchia
            // 
            this.radchia.AutoSize = true;
            this.radchia.Location = new System.Drawing.Point(399, 42);
            this.radchia.Name = "radchia";
            this.radchia.Size = new System.Drawing.Size(46, 17);
            this.radchia.TabIndex = 3;
            this.radchia.TabStop = true;
            this.radchia.Text = "Chia";
            this.radchia.UseVisualStyleBackColor = true;
            this.radchia.CheckedChanged += new System.EventHandler(this.radchia_CheckedChanged);
            // 
            // radnhan
            // 
            this.radnhan.AutoSize = true;
            this.radnhan.Location = new System.Drawing.Point(271, 42);
            this.radnhan.Name = "radnhan";
            this.radnhan.Size = new System.Drawing.Size(51, 17);
            this.radnhan.TabIndex = 2;
            this.radnhan.TabStop = true;
            this.radnhan.Text = "Nhân";
            this.radnhan.UseVisualStyleBackColor = true;
            this.radnhan.CheckedChanged += new System.EventHandler(this.radnhan_CheckedChanged);
            // 
            // radtru
            // 
            this.radtru.AutoSize = true;
            this.radtru.Location = new System.Drawing.Point(148, 42);
            this.radtru.Name = "radtru";
            this.radtru.Size = new System.Drawing.Size(41, 17);
            this.radtru.TabIndex = 1;
            this.radtru.TabStop = true;
            this.radtru.Text = "Trừ";
            this.radtru.UseVisualStyleBackColor = true;
            this.radtru.CheckedChanged += new System.EventHandler(this.radtru_CheckedChanged);
            // 
            // radcong
            // 
            this.radcong.AutoSize = true;
            this.radcong.Location = new System.Drawing.Point(29, 42);
            this.radcong.Name = "radcong";
            this.radcong.Size = new System.Drawing.Size(50, 17);
            this.radcong.TabIndex = 0;
            this.radcong.TabStop = true;
            this.radcong.Text = "Cộng";
            this.radcong.UseVisualStyleBackColor = true;
            this.radcong.CheckedChanged += new System.EventHandler(this.radcong_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbtinhtoan);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtintb);
            this.Controls.Add(this.txtinta);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.lblintb);
            this.Controls.Add(this.lblinta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbtinhtoan.ResumeLayout(false);
            this.grbtinhtoan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinta;
        private System.Windows.Forms.Label lblintb;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.TextBox txtinta;
        private System.Windows.Forms.TextBox txtintb;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.GroupBox grbtinhtoan;
        private System.Windows.Forms.RadioButton radchia;
        private System.Windows.Forms.RadioButton radnhan;
        private System.Windows.Forms.RadioButton radtru;
        private System.Windows.Forms.RadioButton radcong;
    }
}

