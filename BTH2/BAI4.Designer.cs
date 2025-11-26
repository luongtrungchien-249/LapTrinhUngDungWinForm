namespace BTH2
{
    partial class BAI4
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
            this.grbinfor = new System.Windows.Forms.GroupBox();
            this.lstvchienpa = new System.Windows.Forms.ListView();
            this.lblmasv = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lbllop = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.dtpchienpa = new System.Windows.Forms.DateTimePicker();
            this.cbblop = new System.Windows.Forms.ComboBox();
            this.btnthemmoi = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoaitem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.grbinfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbinfor
            // 
            this.grbinfor.Controls.Add(this.btnthoat);
            this.grbinfor.Controls.Add(this.btnxoaitem);
            this.grbinfor.Controls.Add(this.btncapnhat);
            this.grbinfor.Controls.Add(this.btnthemmoi);
            this.grbinfor.Controls.Add(this.cbblop);
            this.grbinfor.Controls.Add(this.dtpchienpa);
            this.grbinfor.Controls.Add(this.txtdiachi);
            this.grbinfor.Controls.Add(this.txthoten);
            this.grbinfor.Controls.Add(this.txtmasv);
            this.grbinfor.Controls.Add(this.lblngaysinh);
            this.grbinfor.Controls.Add(this.lbllop);
            this.grbinfor.Controls.Add(this.lbldiachi);
            this.grbinfor.Controls.Add(this.lblhoten);
            this.grbinfor.Controls.Add(this.lblmasv);
            this.grbinfor.Location = new System.Drawing.Point(193, 12);
            this.grbinfor.Name = "grbinfor";
            this.grbinfor.Size = new System.Drawing.Size(429, 249);
            this.grbinfor.TabIndex = 0;
            this.grbinfor.TabStop = false;
            this.grbinfor.Text = "Thông tin sinh viên";
            // 
            // lstvchienpa
            // 
            this.lstvchienpa.FullRowSelect = true;
            this.lstvchienpa.GridLines = true;
            this.lstvchienpa.Location = new System.Drawing.Point(193, 267);
            this.lstvchienpa.Name = "lstvchienpa";
            this.lstvchienpa.Size = new System.Drawing.Size(429, 171);
            this.lstvchienpa.TabIndex = 1;
            this.lstvchienpa.UseCompatibleStateImageBehavior = false;
            this.lstvchienpa.View = System.Windows.Forms.View.Details;
            this.lstvchienpa.SelectedIndexChanged += new System.EventHandler(this.lstvchienpa_SelectedIndexChanged);
            // 
            // lblmasv
            // 
            this.lblmasv.AutoSize = true;
            this.lblmasv.Location = new System.Drawing.Point(31, 34);
            this.lblmasv.Name = "lblmasv";
            this.lblmasv.Size = new System.Drawing.Size(45, 13);
            this.lblmasv.TabIndex = 0;
            this.lblmasv.Text = "Mã SV :";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(27, 76);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(49, 13);
            this.lblhoten.TabIndex = 1;
            this.lblhoten.Text = "Họ Tên :";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(27, 118);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(49, 13);
            this.lbldiachi.TabIndex = 2;
            this.lbldiachi.Text = "Địa chỉ : ";
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Location = new System.Drawing.Point(16, 160);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(60, 13);
            this.lblngaysinh.TabIndex = 2;
            this.lblngaysinh.Text = "Ngày sinh :";
            // 
            // lbllop
            // 
            this.lbllop.AutoSize = true;
            this.lbllop.Location = new System.Drawing.Point(45, 202);
            this.lbllop.Name = "lbllop";
            this.lbllop.Size = new System.Drawing.Size(31, 13);
            this.lbllop.TabIndex = 2;
            this.lbllop.Text = "Lớp :";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(82, 31);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(231, 20);
            this.txtmasv.TabIndex = 3;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(82, 73);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(231, 20);
            this.txthoten.TabIndex = 4;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(82, 111);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(231, 20);
            this.txtdiachi.TabIndex = 5;
            // 
            // dtpchienpa
            // 
            this.dtpchienpa.CustomFormat = "MM/dd/yyyy";
            this.dtpchienpa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpchienpa.Location = new System.Drawing.Point(82, 154);
            this.dtpchienpa.Name = "dtpchienpa";
            this.dtpchienpa.Size = new System.Drawing.Size(231, 20);
            this.dtpchienpa.TabIndex = 6;
            // 
            // cbblop
            // 
            this.cbblop.FormattingEnabled = true;
            this.cbblop.Location = new System.Drawing.Point(83, 193);
            this.cbblop.Name = "cbblop";
            this.cbblop.Size = new System.Drawing.Size(230, 21);
            this.cbblop.TabIndex = 7;
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.Location = new System.Drawing.Point(330, 11);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(75, 59);
            this.btnthemmoi.TabIndex = 8;
            this.btnthemmoi.Text = "Thêm mới";
            this.btnthemmoi.UseVisualStyleBackColor = true;
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(330, 71);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 59);
            this.btncapnhat.TabIndex = 8;
            this.btncapnhat.Text = "Cập Nhật Items";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoaitem
            // 
            this.btnxoaitem.Location = new System.Drawing.Point(330, 131);
            this.btnxoaitem.Name = "btnxoaitem";
            this.btnxoaitem.Size = new System.Drawing.Size(75, 59);
            this.btnxoaitem.TabIndex = 8;
            this.btnxoaitem.Text = "Xóa Items";
            this.btnxoaitem.UseVisualStyleBackColor = true;
            this.btnxoaitem.Click += new System.EventHandler(this.btnxoaitem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(330, 191);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 59);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // BAI4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstvchienpa);
            this.Controls.Add(this.grbinfor);
            this.Name = "BAI4";
            this.Text = "Bài tập ListView";
            this.Load += new System.EventHandler(this.BAI4_Load);
            this.grbinfor.ResumeLayout(false);
            this.grbinfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbinfor;
        private System.Windows.Forms.DateTimePicker dtpchienpa;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lbllop;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblmasv;
        private System.Windows.Forms.ListView lstvchienpa;
        private System.Windows.Forms.ComboBox cbblop;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoaitem;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnthemmoi;
    }
}