namespace BTH2
{
    partial class BAI8
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
            this.pnchienpa = new System.Windows.Forms.Panel();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblma = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.grbthongtin = new System.Windows.Forms.GroupBox();
            this.pnchienpa.SuspendLayout();
            this.grbthongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvchienpa
            // 
            this.trvchienpa.HideSelection = false;
            this.trvchienpa.Location = new System.Drawing.Point(12, 12);
            this.trvchienpa.Name = "trvchienpa";
            this.trvchienpa.Size = new System.Drawing.Size(389, 426);
            this.trvchienpa.TabIndex = 0;
            this.trvchienpa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvchienpa_AfterSelect);
            this.trvchienpa.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvchienpa_NodeMouseClick);
            this.trvchienpa.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvchienpa_NodeMouseDoubleClick);
            // 
            // pnchienpa
            // 
            this.pnchienpa.Controls.Add(this.grbthongtin);
            this.pnchienpa.Location = new System.Drawing.Point(407, 12);
            this.pnchienpa.Name = "pnchienpa";
            this.pnchienpa.Size = new System.Drawing.Size(388, 426);
            this.pnchienpa.TabIndex = 1;
            this.pnchienpa.Paint += new System.Windows.Forms.PaintEventHandler(this.pnchienpa_Paint);
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(29, 80);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(52, 13);
            this.lblhoten.TabIndex = 0;
            this.lblhoten.Text = "Họ Tên : ";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Location = new System.Drawing.Point(29, 42);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(48, 13);
            this.lblma.TabIndex = 0;
            this.lblma.Text = "Mã SV : ";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(29, 113);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(49, 13);
            this.lbldiachi.TabIndex = 0;
            this.lbldiachi.Text = "Địa chỉ : ";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(112, 39);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(201, 20);
            this.txtma.TabIndex = 1;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(112, 77);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(201, 20);
            this.txthoten.TabIndex = 2;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(112, 110);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(201, 20);
            this.txtdiachi.TabIndex = 3;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(65, 164);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 23);
            this.btncapnhat.TabIndex = 4;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(191, 164);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // grbthongtin
            // 
            this.grbthongtin.Controls.Add(this.btnxoa);
            this.grbthongtin.Controls.Add(this.txtma);
            this.grbthongtin.Controls.Add(this.btncapnhat);
            this.grbthongtin.Controls.Add(this.lblma);
            this.grbthongtin.Controls.Add(this.lblhoten);
            this.grbthongtin.Controls.Add(this.lbldiachi);
            this.grbthongtin.Controls.Add(this.txtdiachi);
            this.grbthongtin.Controls.Add(this.txthoten);
            this.grbthongtin.Location = new System.Drawing.Point(33, 24);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Size = new System.Drawing.Size(329, 250);
            this.grbthongtin.TabIndex = 6;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Thông tin sinh viên";
            // 
            // BAI8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnchienpa);
            this.Controls.Add(this.trvchienpa);
            this.Name = "BAI8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAI8";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.BAI8_Load);
            this.pnchienpa.ResumeLayout(false);
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvchienpa;
        private System.Windows.Forms.Panel pnchienpa;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.GroupBox grbthongtin;
    }
}