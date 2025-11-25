namespace baiTH18
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
            this.lbldebai = new System.Windows.Forms.Label();
            this.lblinta = new System.Windows.Forms.Label();
            this.lblintb = new System.Windows.Forms.Label();
            this.lblnghiem = new System.Windows.Forms.Label();
            this.txtinta = new System.Windows.Forms.TextBox();
            this.txtintb = new System.Windows.Forms.TextBox();
            this.txtnghiem = new System.Windows.Forms.TextBox();
            this.txtgiai = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldebai
            // 
            this.lbldebai.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldebai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbldebai.Location = new System.Drawing.Point(14, 11);
            this.lbldebai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldebai.Name = "lbldebai";
            this.lbldebai.Size = new System.Drawing.Size(905, 99);
            this.lbldebai.TabIndex = 0;
            this.lbldebai.Text = "GIẢI PHƯƠNG TRÌNH BẬC NHẤT AX + B = 0";
            this.lbldebai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblinta
            // 
            this.lblinta.AutoSize = true;
            this.lblinta.Location = new System.Drawing.Point(204, 135);
            this.lblinta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinta.Name = "lblinta";
            this.lblinta.Size = new System.Drawing.Size(61, 16);
            this.lblinta.TabIndex = 0;
            this.lblinta.Text = "Nhập A : ";
            // 
            // lblintb
            // 
            this.lblintb.AutoSize = true;
            this.lblintb.Location = new System.Drawing.Point(209, 252);
            this.lblintb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblintb.Name = "lblintb";
            this.lblintb.Size = new System.Drawing.Size(56, 16);
            this.lblintb.TabIndex = 0;
            this.lblintb.Text = "Nhập B :";
            // 
            // lblnghiem
            // 
            this.lblnghiem.AutoSize = true;
            this.lblnghiem.Location = new System.Drawing.Point(129, 353);
            this.lblnghiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnghiem.Name = "lblnghiem";
            this.lblnghiem.Size = new System.Drawing.Size(136, 16);
            this.lblnghiem.TabIndex = 0;
            this.lblnghiem.Text = "Nghiệm phương trình :";
            // 
            // txtinta
            // 
            this.txtinta.Location = new System.Drawing.Point(273, 132);
            this.txtinta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtinta.Name = "txtinta";
            this.txtinta.Size = new System.Drawing.Size(399, 23);
            this.txtinta.TabIndex = 1;
            // 
            // txtintb
            // 
            this.txtintb.Location = new System.Drawing.Point(273, 249);
            this.txtintb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtintb.Name = "txtintb";
            this.txtintb.Size = new System.Drawing.Size(399, 23);
            this.txtintb.TabIndex = 2;
            // 
            // txtnghiem
            // 
            this.txtnghiem.Location = new System.Drawing.Point(268, 350);
            this.txtnghiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnghiem.Name = "txtnghiem";
            this.txtnghiem.Size = new System.Drawing.Size(399, 23);
            this.txtnghiem.TabIndex = 3;
            // 
            // txtgiai
            // 
            this.txtgiai.Location = new System.Drawing.Point(268, 435);
            this.txtgiai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtgiai.Name = "txtgiai";
            this.txtgiai.Size = new System.Drawing.Size(88, 29);
            this.txtgiai.TabIndex = 4;
            this.txtgiai.Text = "Giải";
            this.txtgiai.UseVisualStyleBackColor = true;
            this.txtgiai.Click += new System.EventHandler(this.txtgiai_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(408, 435);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(88, 29);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(553, 435);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(88, 29);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txtgiai);
            this.Controls.Add(this.txtnghiem);
            this.Controls.Add(this.txtintb);
            this.Controls.Add(this.txtinta);
            this.Controls.Add(this.lblnghiem);
            this.Controls.Add(this.lblintb);
            this.Controls.Add(this.lblinta);
            this.Controls.Add(this.lbldebai);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Giải phương trình bậc nhất AX + B = 0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldebai;
        private System.Windows.Forms.Label lblinta;
        private System.Windows.Forms.Label lblintb;
        private System.Windows.Forms.Label lblnghiem;
        private System.Windows.Forms.TextBox txtinta;
        private System.Windows.Forms.TextBox txtintb;
        private System.Windows.Forms.TextBox txtnghiem;
        private System.Windows.Forms.Button txtgiai;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

