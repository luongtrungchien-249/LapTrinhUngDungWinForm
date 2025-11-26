namespace BTH2
{
    partial class BAI10
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblbirth = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblcountry = new System.Windows.Forms.Label();
            this.lblqualification = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbldateofjoining = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.mastxtdate = new System.Windows.Forms.MaskedTextBox();
            this.cbbcountry = new System.Windows.Forms.ComboBox();
            this.mastxtphone = new System.Windows.Forms.MaskedTextBox();
            this.dtpkchienpa = new System.Windows.Forms.DateTimePicker();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.llbl = new System.Windows.Forms.LinkLabel();
            this.lblyyyy = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtqualy = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(141, 26);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(136, 18);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "EmployeeName :";
            // 
            // lblbirth
            // 
            this.lblbirth.AutoSize = true;
            this.lblbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbirth.Location = new System.Drawing.Point(161, 71);
            this.lblbirth.Name = "lblbirth";
            this.lblbirth.Size = new System.Drawing.Size(116, 18);
            this.lblbirth.TabIndex = 0;
            this.lblbirth.Text = "Date Of Birth :";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(196, 136);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(79, 18);
            this.lbladdress.TabIndex = 0;
            this.lbladdress.Text = "Address :";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.Location = new System.Drawing.Point(221, 178);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(54, 18);
            this.lblcity.TabIndex = 0;
            this.lblcity.Text = "CITY :";
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcountry.Location = new System.Drawing.Point(193, 267);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(82, 18);
            this.lblcountry.TabIndex = 0;
            this.lblcountry.Text = "Country : ";
            this.lblcountry.Click += new System.EventHandler(this.lblcountry_Click);
            // 
            // lblqualification
            // 
            this.lblqualification.AutoSize = true;
            this.lblqualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqualification.Location = new System.Drawing.Point(161, 309);
            this.lblqualification.Name = "lblqualification";
            this.lblqualification.Size = new System.Drawing.Size(112, 18);
            this.lblqualification.TabIndex = 0;
            this.lblqualification.Text = "Qualificaiton :";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(201, 415);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(66, 18);
            this.lblphone.TabIndex = 0;
            this.lblphone.Text = "Phone :";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(207, 468);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(60, 18);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email :";
            // 
            // lbldateofjoining
            // 
            this.lbldateofjoining.AutoSize = true;
            this.lbldateofjoining.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateofjoining.Location = new System.Drawing.Point(132, 511);
            this.lbldateofjoining.Name = "lbldateofjoining";
            this.lbldateofjoining.Size = new System.Drawing.Size(135, 18);
            this.lbldateofjoining.TabIndex = 0;
            this.lbldateofjoining.Text = "Date Of Joining :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(283, 26);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(305, 20);
            this.txtname.TabIndex = 1;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(281, 137);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(307, 20);
            this.txtaddress.TabIndex = 1;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(279, 468);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(308, 20);
            this.txtemail.TabIndex = 1;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // mastxtdate
            // 
            this.mastxtdate.Location = new System.Drawing.Point(283, 72);
            this.mastxtdate.Mask = "00/00/0000";
            this.mastxtdate.Name = "mastxtdate";
            this.mastxtdate.Size = new System.Drawing.Size(305, 20);
            this.mastxtdate.TabIndex = 2;
            this.mastxtdate.ValidatingType = typeof(System.DateTime);
            // 
            // cbbcountry
            // 
            this.cbbcountry.FormattingEnabled = true;
            this.cbbcountry.Location = new System.Drawing.Point(281, 267);
            this.cbbcountry.Name = "cbbcountry";
            this.cbbcountry.Size = new System.Drawing.Size(307, 21);
            this.cbbcountry.TabIndex = 4;
            this.cbbcountry.SelectedIndexChanged += new System.EventHandler(this.cbbcountry_SelectedIndexChanged);
            // 
            // mastxtphone
            // 
            this.mastxtphone.Location = new System.Drawing.Point(279, 416);
            this.mastxtphone.Mask = "000-0000000";
            this.mastxtphone.Name = "mastxtphone";
            this.mastxtphone.Size = new System.Drawing.Size(309, 20);
            this.mastxtphone.TabIndex = 2;
            // 
            // dtpkchienpa
            // 
            this.dtpkchienpa.CustomFormat = "MM/dd/yyyy";
            this.dtpkchienpa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkchienpa.Location = new System.Drawing.Point(281, 511);
            this.dtpkchienpa.Name = "dtpkchienpa";
            this.dtpkchienpa.Size = new System.Drawing.Size(306, 20);
            this.dtpkchienpa.TabIndex = 5;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(323, 558);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(81, 45);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(431, 558);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(81, 45);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // llbl
            // 
            this.llbl.AutoSize = true;
            this.llbl.Location = new System.Drawing.Point(171, 574);
            this.llbl.Name = "llbl";
            this.llbl.Size = new System.Drawing.Size(96, 13);
            this.llbl.TabIndex = 7;
            this.llbl.TabStop = true;
            this.llbl.Text = "Link To VnExpress";
            // 
            // lblyyyy
            // 
            this.lblyyyy.AutoSize = true;
            this.lblyyyy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyyyy.Location = new System.Drawing.Point(161, 89);
            this.lblyyyy.Name = "lblyyyy";
            this.lblyyyy.Size = new System.Drawing.Size(114, 18);
            this.lblyyyy.TabIndex = 8;
            this.lblyyyy.Text = "(mm/DD/yyyy)";
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(283, 175);
            this.txtcity.Multiline = true;
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(305, 85);
            this.txtcity.TabIndex = 9;
            // 
            // txtqualy
            // 
            this.txtqualy.Location = new System.Drawing.Point(280, 306);
            this.txtqualy.Multiline = true;
            this.txtqualy.Name = "txtqualy";
            this.txtqualy.Size = new System.Drawing.Size(308, 91);
            this.txtqualy.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BAI10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 626);
            this.Controls.Add(this.txtqualy);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.lblyyyy);
            this.Controls.Add(this.llbl);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.dtpkchienpa);
            this.Controls.Add(this.cbbcountry);
            this.Controls.Add(this.mastxtphone);
            this.Controls.Add(this.mastxtdate);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblcountry);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbldateofjoining);
            this.Controls.Add(this.lblqualification);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.lblbirth);
            this.Name = "BAI10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAI10";
            this.Load += new System.EventHandler(this.BAI10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblbirth;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.Label lblqualification;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbldateofjoining;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.MaskedTextBox mastxtdate;
        private System.Windows.Forms.ComboBox cbbcountry;
        private System.Windows.Forms.MaskedTextBox mastxtphone;
        private System.Windows.Forms.DateTimePicker dtpkchienpa;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.LinkLabel llbl;
        private System.Windows.Forms.Label lblyyyy;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtqualy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}