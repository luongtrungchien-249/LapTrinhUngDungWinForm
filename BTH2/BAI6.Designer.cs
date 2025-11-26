namespace BTH2
{
    partial class BAI6
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
            this.trvchienpa = new System.Windows.Forms.TreeView();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.pnchienpa = new System.Windows.Forms.Panel();
            this.pnchienpa.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvchienpa
            // 
            this.trvchienpa.Location = new System.Drawing.Point(12, 12);
            this.trvchienpa.Name = "trvchienpa";
            this.trvchienpa.Size = new System.Drawing.Size(263, 426);
            this.trvchienpa.TabIndex = 0;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(407, 337);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(-3, 29);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(75, 16);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "FirstName :";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(-3, 168);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(75, 16);
            this.lbllastname.TabIndex = 1;
            this.lbllastname.Text = "LastName :";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(28, 60);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(156, 20);
            this.txtfirstname.TabIndex = 2;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(31, 187);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(153, 20);
            this.txtlastname.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(122, 246);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add name";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // pnchienpa
            // 
            this.pnchienpa.Controls.Add(this.btnadd);
            this.pnchienpa.Controls.Add(this.lblfirstname);
            this.pnchienpa.Controls.Add(this.txtlastname);
            this.pnchienpa.Controls.Add(this.txtfirstname);
            this.pnchienpa.Controls.Add(this.lbllastname);
            this.pnchienpa.Location = new System.Drawing.Point(282, 13);
            this.pnchienpa.Name = "pnchienpa";
            this.pnchienpa.Size = new System.Drawing.Size(200, 308);
            this.pnchienpa.TabIndex = 4;
            // 
            // BAI6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 453);
            this.Controls.Add(this.pnchienpa);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.trvchienpa);
            this.Name = "BAI6";
            this.Text = "BAI6";
            this.Load += new System.EventHandler(this.BAI6_Load);
            this.pnchienpa.ResumeLayout(false);
            this.pnchienpa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvchienpa;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel pnchienpa;
    }
}