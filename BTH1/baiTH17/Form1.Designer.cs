namespace baiTH17
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
            this.lblyourname = new System.Windows.Forms.Label();
            this.lblyearofbirth = new System.Windows.Forms.Label();
            this.txtyourname = new System.Windows.Forms.TextBox();
            this.txtyearofbirth = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblyourname
            // 
            this.lblyourname.AutoSize = true;
            this.lblyourname.Location = new System.Drawing.Point(202, 94);
            this.lblyourname.Name = "lblyourname";
            this.lblyourname.Size = new System.Drawing.Size(69, 13);
            this.lblyourname.TabIndex = 5;
            this.lblyourname.Text = "Your Name : ";
            // 
            // lblyearofbirth
            // 
            this.lblyearofbirth.AutoSize = true;
            this.lblyearofbirth.Location = new System.Drawing.Point(202, 160);
            this.lblyearofbirth.Name = "lblyearofbirth";
            this.lblyearofbirth.Size = new System.Drawing.Size(76, 13);
            this.lblyearofbirth.TabIndex = 6;
            this.lblyearofbirth.Text = "Year Of Birth : ";
            // 
            // txtyourname
            // 
            this.txtyourname.Location = new System.Drawing.Point(303, 87);
            this.txtyourname.Name = "txtyourname";
            this.txtyourname.Size = new System.Drawing.Size(265, 20);
            this.txtyourname.TabIndex = 0;
            // 
            // txtyearofbirth
            // 
            this.txtyearofbirth.Location = new System.Drawing.Point(303, 157);
            this.txtyearofbirth.Name = "txtyearofbirth";
            this.txtyearofbirth.Size = new System.Drawing.Size(265, 20);
            this.txtyearofbirth.TabIndex = 1;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(205, 260);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 2;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(346, 260);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(493, 260);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Exit";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
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
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtyearofbirth);
            this.Controls.Add(this.txtyourname);
            this.Controls.Add(this.lblyearofbirth);
            this.Controls.Add(this.lblyourname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblyourname;
        private System.Windows.Forms.Label lblyearofbirth;
        private System.Windows.Forms.TextBox txtyourname;
        private System.Windows.Forms.TextBox txtyearofbirth;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

