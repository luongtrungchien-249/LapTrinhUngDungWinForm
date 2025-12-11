namespace BTH3
{
    partial class frmcauhinh
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
            this.lblqkn = new System.Windows.Forms.Label();
            this.lbltenmayip = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtip = new System.Windows.Forms.TextBox();
            this.txtdataname = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btncauhinh = new System.Windows.Forms.Button();
            this.radwd = new System.Windows.Forms.RadioButton();
            this.radacc = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblqkn
            // 
            this.lblqkn.Location = new System.Drawing.Point(68, 59);
            this.lblqkn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblqkn.Name = "lblqkn";
            this.lblqkn.Size = new System.Drawing.Size(122, 68);
            this.lblqkn.TabIndex = 0;
            this.lblqkn.Text = "Quyền kết nối";
            this.lblqkn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltenmayip
            // 
            this.lbltenmayip.Location = new System.Drawing.Point(404, 79);
            this.lbltenmayip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltenmayip.Name = "lbltenmayip";
            this.lbltenmayip.Size = new System.Drawing.Size(101, 42);
            this.lbltenmayip.TabIndex = 0;
            this.lbltenmayip.Text = "Tên máy/IP :";
            this.lbltenmayip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldata
            // 
            this.lbldata.Location = new System.Drawing.Point(404, 139);
            this.lbldata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(101, 42);
            this.lbldata.TabIndex = 0;
            this.lbldata.Text = "Tên Data";
            this.lbldata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblusername
            // 
            this.lblusername.Location = new System.Drawing.Point(404, 203);
            this.lblusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(101, 42);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username";
            this.lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpass
            // 
            this.lblpass.Location = new System.Drawing.Point(404, 268);
            this.lblpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(101, 42);
            this.lblpass.TabIndex = 0;
            this.lblpass.Text = "Pass";
            this.lblpass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(522, 89);
            this.txtip.Margin = new System.Windows.Forms.Padding(4);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(184, 23);
            this.txtip.TabIndex = 3;
            // 
            // txtdataname
            // 
            this.txtdataname.Location = new System.Drawing.Point(522, 146);
            this.txtdataname.Margin = new System.Windows.Forms.Padding(4);
            this.txtdataname.Name = "txtdataname";
            this.txtdataname.Size = new System.Drawing.Size(184, 23);
            this.txtdataname.TabIndex = 3;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(522, 216);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(184, 23);
            this.txtusername.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(522, 278);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(184, 23);
            this.txtpass.TabIndex = 3;
            // 
            // btncauhinh
            // 
            this.btncauhinh.Location = new System.Drawing.Point(791, 89);
            this.btncauhinh.Margin = new System.Windows.Forms.Padding(4);
            this.btncauhinh.Name = "btncauhinh";
            this.btncauhinh.Size = new System.Drawing.Size(104, 50);
            this.btncauhinh.TabIndex = 4;
            this.btncauhinh.Text = "Cấu hình";
            this.btncauhinh.UseVisualStyleBackColor = true;
            this.btncauhinh.Click += new System.EventHandler(this.btncauhinh_Click);
            // 
            // radwd
            // 
            this.radwd.Location = new System.Drawing.Point(153, 146);
            this.radwd.Margin = new System.Windows.Forms.Padding(4);
            this.radwd.Name = "radwd";
            this.radwd.Size = new System.Drawing.Size(129, 49);
            this.radwd.TabIndex = 5;
            this.radwd.TabStop = true;
            this.radwd.Text = "Quyền window";
            this.radwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radwd.UseVisualStyleBackColor = true;
            // 
            // radacc
            // 
            this.radacc.Location = new System.Drawing.Point(153, 203);
            this.radacc.Margin = new System.Windows.Forms.Padding(4);
            this.radacc.Name = "radacc";
            this.radacc.Size = new System.Drawing.Size(129, 49);
            this.radacc.TabIndex = 5;
            this.radacc.TabStop = true;
            this.radacc.Text = "Quyền Account";
            this.radacc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radacc.UseVisualStyleBackColor = true;
            // 
            // frmcauhinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.radacc);
            this.Controls.Add(this.radwd);
            this.Controls.Add(this.btncauhinh);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtdataname);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.lbltenmayip);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblqkn);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmcauhinh";
            this.Text = "frmcauhinh";
            this.Load += new System.EventHandler(this.frmcauhinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblqkn;
        private System.Windows.Forms.Label lbltenmayip;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.TextBox txtdataname;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btncauhinh;
        private System.Windows.Forms.RadioButton radwd;
        private System.Windows.Forms.RadioButton radacc;
    }
}