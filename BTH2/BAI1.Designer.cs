namespace BTH2
{
    partial class BAI1
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
            this.lbldongho = new System.Windows.Forms.Label();
            this.btnbatdau = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbldongho
            // 
            this.lbldongho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbldongho.Location = new System.Drawing.Point(290, 114);
            this.lbldongho.Name = "lbldongho";
            this.lbldongho.Size = new System.Drawing.Size(220, 51);
            this.lbldongho.TabIndex = 0;
            this.lbldongho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnbatdau
            // 
            this.btnbatdau.Location = new System.Drawing.Point(290, 168);
            this.btnbatdau.Name = "btnbatdau";
            this.btnbatdau.Size = new System.Drawing.Size(107, 23);
            this.btnbatdau.TabIndex = 1;
            this.btnbatdau.Text = "Bắt đầu";
            this.btnbatdau.UseVisualStyleBackColor = true;
            this.btnbatdau.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(403, 168);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(107, 23);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Dừng";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BAI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnbatdau);
            this.Controls.Add(this.lbldongho);
            this.Name = "BAI1";
            this.Text = "Đồng Hồ đếm ngược";
            this.Load += new System.EventHandler(this.BAI1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbldongho;
        private System.Windows.Forms.Button btnbatdau;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Timer timer1;
    }
}

