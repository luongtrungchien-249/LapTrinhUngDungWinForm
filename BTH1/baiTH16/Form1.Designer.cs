namespace baiTH16
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
            this.txtinput = new System.Windows.Forms.TextBox();
            this.lblhienthi = new System.Windows.Forms.Label();
            this.radtimenewroman = new System.Windows.Forms.RadioButton();
            this.radarial = new System.Windows.Forms.RadioButton();
            this.radtahoma = new System.Windows.Forms.RadioButton();
            this.radcouriernew = new System.Windows.Forms.RadioButton();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(202, 61);
            this.txtinput.Multiline = true;
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(293, 306);
            this.txtinput.TabIndex = 0;
            // 
            // lblhienthi
            // 
            this.lblhienthi.AutoSize = true;
            this.lblhienthi.Location = new System.Drawing.Point(199, 26);
            this.lblhienthi.Name = "lblhienthi";
            this.lblhienthi.Size = new System.Drawing.Size(83, 13);
            this.lblhienthi.TabIndex = 1;
            this.lblhienthi.Text = "Nhập Văn Bản :";
            // 
            // radtimenewroman
            // 
            this.radtimenewroman.AutoSize = true;
            this.radtimenewroman.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radtimenewroman.Location = new System.Drawing.Point(550, 83);
            this.radtimenewroman.Name = "radtimenewroman";
            this.radtimenewroman.Size = new System.Drawing.Size(124, 19);
            this.radtimenewroman.TabIndex = 2;
            this.radtimenewroman.TabStop = true;
            this.radtimenewroman.Text = "Times New Roman";
            this.radtimenewroman.UseVisualStyleBackColor = true;
            this.radtimenewroman.CheckedChanged += new System.EventHandler(this.radtimenewroman_CheckedChanged);
            // 
            // radarial
            // 
            this.radarial.AutoSize = true;
            this.radarial.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radarial.Location = new System.Drawing.Point(550, 164);
            this.radarial.Name = "radarial";
            this.radarial.Size = new System.Drawing.Size(46, 20);
            this.radarial.TabIndex = 3;
            this.radarial.TabStop = true;
            this.radarial.Text = "Arial";
            this.radarial.UseVisualStyleBackColor = true;
            this.radarial.CheckedChanged += new System.EventHandler(this.radarial_CheckedChanged);
            // 
            // radtahoma
            // 
            this.radtahoma.AutoSize = true;
            this.radtahoma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radtahoma.Location = new System.Drawing.Point(550, 236);
            this.radtahoma.Name = "radtahoma";
            this.radtahoma.Size = new System.Drawing.Size(72, 20);
            this.radtahoma.TabIndex = 4;
            this.radtahoma.TabStop = true;
            this.radtahoma.Text = "Tahoma";
            this.radtahoma.UseVisualStyleBackColor = true;
            this.radtahoma.CheckedChanged += new System.EventHandler(this.radrahoma_CheckedChanged);
            // 
            // radcouriernew
            // 
            this.radcouriernew.AutoSize = true;
            this.radcouriernew.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radcouriernew.Location = new System.Drawing.Point(550, 314);
            this.radcouriernew.Name = "radcouriernew";
            this.radcouriernew.Size = new System.Drawing.Size(113, 20);
            this.radcouriernew.TabIndex = 5;
            this.radcouriernew.TabStop = true;
            this.radcouriernew.Text = "Courier New";
            this.radcouriernew.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(375, 401);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(120, 23);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.radcouriernew);
            this.Controls.Add(this.radtahoma);
            this.Controls.Add(this.radarial);
            this.Controls.Add(this.radtimenewroman);
            this.Controls.Add(this.lblhienthi);
            this.Controls.Add(this.txtinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Label lblhienthi;
        private System.Windows.Forms.RadioButton radtimenewroman;
        private System.Windows.Forms.RadioButton radarial;
        private System.Windows.Forms.RadioButton radtahoma;
        private System.Windows.Forms.RadioButton radcouriernew;
        private System.Windows.Forms.Button btnthoat;
    }
}

