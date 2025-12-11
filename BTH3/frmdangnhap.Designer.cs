namespace BTH3
{
    partial class frmdangnhap
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
            this.grbdangnhap = new System.Windows.Forms.GroupBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.lbltennd = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.grbdangnhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbdangnhap
            // 
            this.grbdangnhap.Controls.Add(this.txtpass);
            this.grbdangnhap.Controls.Add(this.txtuser);
            this.grbdangnhap.Controls.Add(this.lblmatkhau);
            this.grbdangnhap.Controls.Add(this.lbltennd);
            this.grbdangnhap.Controls.Add(this.btnthoat);
            this.grbdangnhap.Controls.Add(this.btndangnhap);
            this.grbdangnhap.Location = new System.Drawing.Point(64, 27);
            this.grbdangnhap.Name = "grbdangnhap";
            this.grbdangnhap.Size = new System.Drawing.Size(463, 310);
            this.grbdangnhap.TabIndex = 0;
            this.grbdangnhap.TabStop = false;
            this.grbdangnhap.Text = "Thông tin đăng nhập";
            
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(178, 143);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(189, 20);
            this.txtpass.TabIndex = 4;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(178, 77);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(189, 20);
            this.txtuser.TabIndex = 3;
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.Location = new System.Drawing.Point(68, 133);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(104, 39);
            this.lblmatkhau.TabIndex = 2;
            this.lblmatkhau.Text = "Mật khẩu";
            this.lblmatkhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltennd
            // 
            this.lbltennd.Location = new System.Drawing.Point(68, 67);
            this.lbltennd.Name = "lbltennd";
            this.lbltennd.Size = new System.Drawing.Size(104, 39);
            this.lbltennd.TabIndex = 1;
            this.lbltennd.Text = "Tên người dùng :";
            this.lbltennd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(252, 207);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(110, 207);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(75, 23);
            this.btndangnhap.TabIndex = 0;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 386);
            this.Controls.Add(this.grbdangnhap);
            this.Name = "frmdangnhap";
            this.Text = "Đăng nhập hệ thống";
            
            this.Load += new System.EventHandler(this.frmdangnhap_Load);
            this.grbdangnhap.ResumeLayout(false);
            this.grbdangnhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbdangnhap;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Label lbltennd;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndangnhap;
    }
}