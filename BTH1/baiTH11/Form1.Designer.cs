namespace baiTH1
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
            this.components = new System.ComponentModel.Container();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.chkghinho = new System.Windows.Forms.CheckBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btndung = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.Location = new System.Drawing.Point(182, 81);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(114, 20);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Tên đăng nhập";
            this.lbllogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(201, 133);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(53, 13);
            this.lblpass.TabIndex = 0;
            this.lblpass.Text = "Mật Khẩu";
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtlogin.ForeColor = System.Drawing.Color.White;
            this.txtlogin.Location = new System.Drawing.Point(302, 81);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(275, 20);
            this.txtlogin.TabIndex = 1;
            this.txtlogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtpass.Location = new System.Drawing.Point(302, 133);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(275, 20);
            this.txtpass.TabIndex = 1;
            this.txtpass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // chkghinho
            // 
            this.chkghinho.AutoSize = true;
            this.chkghinho.Location = new System.Drawing.Point(204, 181);
            this.chkghinho.Name = "chkghinho";
            this.chkghinho.Size = new System.Drawing.Size(63, 17);
            this.chkghinho.TabIndex = 2;
            this.chkghinho.Text = "Ghi nhớ";
            this.chkghinho.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(221, 223);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Dăng nhập";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(342, 223);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndung
            // 
            this.btndung.Location = new System.Drawing.Point(502, 223);
            this.btndung.Name = "btndung";
            this.btndung.Size = new System.Drawing.Size(75, 23);
            this.btndung.TabIndex = 5;
            this.btndung.Text = "Dừng";
            this.btndung.UseVisualStyleBackColor = true;
            this.btndung.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndung);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.chkghinho);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbllogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.CheckBox chkghinho;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btndung;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

