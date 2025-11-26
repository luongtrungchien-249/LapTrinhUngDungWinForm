namespace BTH2
{
    partial class BAI2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAI2));
            this.grbcountry = new System.Windows.Forms.GroupBox();
            this.ptbusa = new System.Windows.Forms.PictureBox();
            this.ptbitaly = new System.Windows.Forms.PictureBox();
            this.ptbphilip = new System.Windows.Forms.PictureBox();
            this.ptbvn = new System.Windows.Forms.PictureBox();
            this.lblnhan = new System.Windows.Forms.Label();
            this.radvn = new System.Windows.Forms.RadioButton();
            this.radusa = new System.Windows.Forms.RadioButton();
            this.raditaly = new System.Windows.Forms.RadioButton();
            this.radphilipine = new System.Windows.Forms.RadioButton();
            this.grbcountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbusa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbitaly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbphilip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbvn)).BeginInit();
            this.SuspendLayout();
            // 
            // grbcountry
            // 
            this.grbcountry.Controls.Add(this.radphilipine);
            this.grbcountry.Controls.Add(this.raditaly);
            this.grbcountry.Controls.Add(this.radusa);
            this.grbcountry.Controls.Add(this.radvn);
            this.grbcountry.Location = new System.Drawing.Point(223, 77);
            this.grbcountry.Name = "grbcountry";
            this.grbcountry.Size = new System.Drawing.Size(200, 228);
            this.grbcountry.TabIndex = 0;
            this.grbcountry.TabStop = false;
            this.grbcountry.Text = "Country";
            // 
            // ptbusa
            // 
            this.ptbusa.Image = ((System.Drawing.Image)(resources.GetObject("ptbusa.Image")));
            this.ptbusa.Location = new System.Drawing.Point(429, 77);
            this.ptbusa.Name = "ptbusa";
            this.ptbusa.Size = new System.Drawing.Size(236, 228);
            this.ptbusa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbusa.TabIndex = 1;
            this.ptbusa.TabStop = false;
            // 
            // ptbitaly
            // 
            this.ptbitaly.Image = ((System.Drawing.Image)(resources.GetObject("ptbitaly.Image")));
            this.ptbitaly.Location = new System.Drawing.Point(429, 77);
            this.ptbitaly.Name = "ptbitaly";
            this.ptbitaly.Size = new System.Drawing.Size(236, 228);
            this.ptbitaly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbitaly.TabIndex = 2;
            this.ptbitaly.TabStop = false;
            // 
            // ptbphilip
            // 
            this.ptbphilip.Image = ((System.Drawing.Image)(resources.GetObject("ptbphilip.Image")));
            this.ptbphilip.Location = new System.Drawing.Point(429, 77);
            this.ptbphilip.Name = "ptbphilip";
            this.ptbphilip.Size = new System.Drawing.Size(236, 228);
            this.ptbphilip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbphilip.TabIndex = 3;
            this.ptbphilip.TabStop = false;
            // 
            // ptbvn
            // 
            this.ptbvn.Image = ((System.Drawing.Image)(resources.GetObject("ptbvn.Image")));
            this.ptbvn.Location = new System.Drawing.Point(429, 77);
            this.ptbvn.Name = "ptbvn";
            this.ptbvn.Size = new System.Drawing.Size(236, 228);
            this.ptbvn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbvn.TabIndex = 4;
            this.ptbvn.TabStop = false;
            this.ptbvn.Click += new System.EventHandler(this.ptbvn_Click);
            // 
            // lblnhan
            // 
            this.lblnhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblnhan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhan.Location = new System.Drawing.Point(0, 0);
            this.lblnhan.Name = "lblnhan";
            this.lblnhan.Size = new System.Drawing.Size(800, 74);
            this.lblnhan.TabIndex = 5;
            this.lblnhan.Text = "COUNTRY FLAG";
            this.lblnhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radvn
            // 
            this.radvn.AutoSize = true;
            this.radvn.Location = new System.Drawing.Point(42, 38);
            this.radvn.Name = "radvn";
            this.radvn.Size = new System.Drawing.Size(68, 17);
            this.radvn.TabIndex = 0;
            this.radvn.TabStop = true;
            this.radvn.Text = "Việt Nam";
            this.radvn.UseVisualStyleBackColor = true;
            this.radvn.CheckedChanged += new System.EventHandler(this.radvn_CheckedChanged);
            // 
            // radusa
            // 
            this.radusa.AutoSize = true;
            this.radusa.Location = new System.Drawing.Point(42, 72);
            this.radusa.Name = "radusa";
            this.radusa.Size = new System.Drawing.Size(47, 17);
            this.radusa.TabIndex = 1;
            this.radusa.TabStop = true;
            this.radusa.Text = "USA";
            this.radusa.UseVisualStyleBackColor = true;
            this.radusa.CheckedChanged += new System.EventHandler(this.radusa_CheckedChanged);
            // 
            // raditaly
            // 
            this.raditaly.AutoSize = true;
            this.raditaly.Location = new System.Drawing.Point(42, 112);
            this.raditaly.Name = "raditaly";
            this.raditaly.Size = new System.Drawing.Size(55, 17);
            this.raditaly.TabIndex = 2;
            this.raditaly.TabStop = true;
            this.raditaly.Text = "ITALY";
            this.raditaly.UseVisualStyleBackColor = true;
            this.raditaly.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radphilipine
            // 
            this.radphilipine.AutoSize = true;
            this.radphilipine.Location = new System.Drawing.Point(42, 145);
            this.radphilipine.Name = "radphilipine";
            this.radphilipine.Size = new System.Drawing.Size(77, 17);
            this.radphilipine.TabIndex = 3;
            this.radphilipine.TabStop = true;
            this.radphilipine.Text = "PHILIPINE";
            this.radphilipine.UseVisualStyleBackColor = true;
            this.radphilipine.CheckedChanged += new System.EventHandler(this.radphilipine_CheckedChanged);
            // 
            // BAI2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnhan);
            this.Controls.Add(this.ptbvn);
            this.Controls.Add(this.ptbphilip);
            this.Controls.Add(this.ptbitaly);
            this.Controls.Add(this.ptbusa);
            this.Controls.Add(this.grbcountry);
            this.Name = "BAI2";
            this.Text = "frmquocgia";
            this.Load += new System.EventHandler(this.BAI2_Load);
            this.grbcountry.ResumeLayout(false);
            this.grbcountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbusa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbitaly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbphilip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbvn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbcountry;
        private System.Windows.Forms.PictureBox ptbusa;
        private System.Windows.Forms.PictureBox ptbitaly;
        private System.Windows.Forms.PictureBox ptbphilip;
        private System.Windows.Forms.PictureBox ptbvn;
        private System.Windows.Forms.Label lblnhan;
        private System.Windows.Forms.RadioButton radphilipine;
        private System.Windows.Forms.RadioButton raditaly;
        private System.Windows.Forms.RadioButton radusa;
        private System.Windows.Forms.RadioButton radvn;
    }
}