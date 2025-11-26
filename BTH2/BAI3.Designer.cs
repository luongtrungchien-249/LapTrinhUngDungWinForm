namespace BTH2
{
    partial class BAI3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAI3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chienpaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chienassasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstvchienpa = new System.Windows.Forms.ListView();
            this.txtdetail = new System.Windows.Forms.TextBox();
            this.pnchienpa = new System.Windows.Forms.Panel();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnchienpa.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chienToolStripMenuItem,
            this.chienpaToolStripMenuItem,
            this.chienassasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // chienToolStripMenuItem
            // 
            this.chienToolStripMenuItem.Name = "chienToolStripMenuItem";
            this.chienToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.chienToolStripMenuItem.Text = "FILE";
            // 
            // chienpaToolStripMenuItem
            // 
            this.chienpaToolStripMenuItem.Name = "chienpaToolStripMenuItem";
            this.chienpaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.chienpaToolStripMenuItem.Text = "View";
            this.chienpaToolStripMenuItem.Click += new System.EventHandler(this.chienpaToolStripMenuItem_Click);
            // 
            // chienassasToolStripMenuItem
            // 
            this.chienassasToolStripMenuItem.Name = "chienassasToolStripMenuItem";
            this.chienassasToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.chienassasToolStripMenuItem.Text = "Format ListView";
            // 
            // lstvchienpa
            // 
            this.lstvchienpa.GridLines = true;
            this.lstvchienpa.HideSelection = false;
            this.lstvchienpa.Location = new System.Drawing.Point(12, 55);
            this.lstvchienpa.Name = "lstvchienpa";
            this.lstvchienpa.Size = new System.Drawing.Size(484, 383);
            this.lstvchienpa.TabIndex = 1;
            this.lstvchienpa.UseCompatibleStateImageBehavior = false;
            this.lstvchienpa.View = System.Windows.Forms.View.Details;
            this.lstvchienpa.SelectedIndexChanged += new System.EventHandler(this.lstvchienpa_SelectedIndexChanged);
            // 
            // txtdetail
            // 
            this.txtdetail.Location = new System.Drawing.Point(12, 29);
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(100, 20);
            this.txtdetail.TabIndex = 2;
            this.txtdetail.Text = "Details";
            // 
            // pnchienpa
            // 
            this.pnchienpa.Controls.Add(this.btnadd);
            this.pnchienpa.Controls.Add(this.txtphone);
            this.pnchienpa.Controls.Add(this.txtfirstname);
            this.pnchienpa.Controls.Add(this.txtlastname);
            this.pnchienpa.Controls.Add(this.lblphone);
            this.pnchienpa.Controls.Add(this.lblfirstname);
            this.pnchienpa.Controls.Add(this.lbllastname);
            this.pnchienpa.Location = new System.Drawing.Point(503, 55);
            this.pnchienpa.Name = "pnchienpa";
            this.pnchienpa.Size = new System.Drawing.Size(285, 383);
            this.pnchienpa.TabIndex = 3;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(30, 22);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(90, 20);
            this.lbllastname.TabIndex = 0;
            this.lbllastname.Text = "LastName :";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(30, 112);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(90, 20);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "FirstName :";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(30, 218);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(55, 20);
            this.lblphone.TabIndex = 0;
            this.lblphone.Text = "Phone";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(33, 60);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(184, 20);
            this.txtlastname.TabIndex = 1;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(33, 163);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(184, 20);
            this.txtfirstname.TabIndex = 2;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(33, 270);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(184, 20);
            this.txtphone.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(129, 318);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(133, 49);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add Name";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "avt.jpg");
            this.imageList1.Images.SetKeyName(1, "avt.jpg");
            // 
            // BAI3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnchienpa);
            this.Controls.Add(this.txtdetail);
            this.Controls.Add(this.lstvchienpa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BAI3";
            this.Text = "ListView DEMO";
            this.Load += new System.EventHandler(this.BAI3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnchienpa.ResumeLayout(false);
            this.pnchienpa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chienpaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chienassasToolStripMenuItem;
        private System.Windows.Forms.ListView lstvchienpa;
        private System.Windows.Forms.TextBox txtdetail;
        private System.Windows.Forms.Panel pnchienpa;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.ImageList imageList1;
    }
}