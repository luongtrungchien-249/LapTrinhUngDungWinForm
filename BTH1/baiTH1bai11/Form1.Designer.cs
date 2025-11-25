namespace baiTH1bai11
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
            this.lblnhan = new System.Windows.Forms.Label();
            this.lblmssv = new System.Windows.Forms.Label();
            this.lblhovaten = new System.Windows.Forms.Label();
            this.lblniienkhoa = new System.Windows.Forms.Label();
            this.lbllop = new System.Windows.Forms.Label();
            this.lblhocky = new System.Windows.Forms.Label();
            this.lblmonhoc = new System.Windows.Forms.Label();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.txthovaten = new System.Windows.Forms.TextBox();
            this.cmbnienkhoa = new System.Windows.Forms.ComboBox();
            this.cmblop = new System.Windows.Forms.ComboBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.chklstbox = new System.Windows.Forms.CheckedListBox();
            this.btndangki = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnhan
            // 
            this.lblnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhan.Location = new System.Drawing.Point(-3, 0);
            this.lblnhan.Name = "lblnhan";
            this.lblnhan.Size = new System.Drawing.Size(803, 64);
            this.lblnhan.TabIndex = 0;
            this.lblnhan.Text = "Đăng Kí Môn Học";
            this.lblnhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblmssv
            // 
            this.lblmssv.AutoSize = true;
            this.lblmssv.Location = new System.Drawing.Point(239, 81);
            this.lblmssv.Name = "lblmssv";
            this.lblmssv.Size = new System.Drawing.Size(46, 13);
            this.lblmssv.TabIndex = 0;
            this.lblmssv.Text = "MSSV : ";
            this.lblmssv.Click += new System.EventHandler(this.lblmssv_Click);
            // 
            // lblhovaten
            // 
            this.lblhovaten.AutoSize = true;
            this.lblhovaten.Location = new System.Drawing.Point(239, 129);
            this.lblhovaten.Name = "lblhovaten";
            this.lblhovaten.Size = new System.Drawing.Size(65, 13);
            this.lblhovaten.TabIndex = 0;
            this.lblhovaten.Text = "Họ Và Tên :";
            // 
            // lblniienkhoa
            // 
            this.lblniienkhoa.AutoSize = true;
            this.lblniienkhoa.Location = new System.Drawing.Point(239, 170);
            this.lblniienkhoa.Name = "lblniienkhoa";
            this.lblniienkhoa.Size = new System.Drawing.Size(63, 13);
            this.lblniienkhoa.TabIndex = 0;
            this.lblniienkhoa.Text = "Niên Khóa :";
            // 
            // lbllop
            // 
            this.lbllop.AutoSize = true;
            this.lbllop.Location = new System.Drawing.Point(239, 221);
            this.lbllop.Name = "lbllop";
            this.lbllop.Size = new System.Drawing.Size(34, 13);
            this.lbllop.TabIndex = 0;
            this.lbllop.Text = "Lớp : ";
            // 
            // lblhocky
            // 
            this.lblhocky.AutoSize = true;
            this.lblhocky.Location = new System.Drawing.Point(239, 271);
            this.lblhocky.Name = "lblhocky";
            this.lblhocky.Size = new System.Drawing.Size(51, 13);
            this.lblhocky.TabIndex = 0;
            this.lblhocky.Text = "Học Kỳ : ";
            // 
            // lblmonhoc
            // 
            this.lblmonhoc.AutoSize = true;
            this.lblmonhoc.Location = new System.Drawing.Point(239, 317);
            this.lblmonhoc.Name = "lblmonhoc";
            this.lblmonhoc.Size = new System.Drawing.Size(60, 13);
            this.lblmonhoc.TabIndex = 0;
            this.lblmonhoc.Text = "Môn Học : ";
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(328, 81);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(246, 20);
            this.txtmssv.TabIndex = 0;
            // 
            // txthovaten
            // 
            this.txthovaten.Location = new System.Drawing.Point(328, 122);
            this.txthovaten.Name = "txthovaten";
            this.txthovaten.Size = new System.Drawing.Size(246, 20);
            this.txthovaten.TabIndex = 1;
            this.txthovaten.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbnienkhoa
            // 
            this.cmbnienkhoa.FormattingEnabled = true;
            this.cmbnienkhoa.Location = new System.Drawing.Point(328, 167);
            this.cmbnienkhoa.Name = "cmbnienkhoa";
            this.cmbnienkhoa.Size = new System.Drawing.Size(246, 21);
            this.cmbnienkhoa.TabIndex = 2;
            // 
            // cmblop
            // 
            this.cmblop.FormattingEnabled = true;
            this.cmblop.Location = new System.Drawing.Point(328, 218);
            this.cmblop.Name = "cmblop";
            this.cmblop.Size = new System.Drawing.Size(246, 21);
            this.cmblop.TabIndex = 3;
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(328, 271);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(28, 17);
            this.rad1.TabIndex = 4;
            this.rad1.TabStop = true;
            this.rad1.Text = "I";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(425, 271);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(31, 17);
            this.rad2.TabIndex = 5;
            this.rad2.TabStop = true;
            this.rad2.Text = "II";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Location = new System.Drawing.Point(524, 271);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(34, 17);
            this.rad3.TabIndex = 6;
            this.rad3.TabStop = true;
            this.rad3.Text = "III";
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.Location = new System.Drawing.Point(612, 271);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(35, 17);
            this.rad4.TabIndex = 7;
            this.rad4.TabStop = true;
            this.rad4.Text = "IV";
            this.rad4.UseVisualStyleBackColor = true;
            // 
            // chklstbox
            // 
            this.chklstbox.FormattingEnabled = true;
            this.chklstbox.Location = new System.Drawing.Point(347, 317);
            this.chklstbox.Name = "chklstbox";
            this.chklstbox.Size = new System.Drawing.Size(228, 34);
            this.chklstbox.TabIndex = 8;
            // 
            // btndangki
            // 
            this.btndangki.Location = new System.Drawing.Point(241, 386);
            this.btndangki.Name = "btndangki";
            this.btndangki.Size = new System.Drawing.Size(75, 23);
            this.btndangki.TabIndex = 9;
            this.btndangki.Text = "Đăng Ký";
            this.btndangki.UseVisualStyleBackColor = true;
            this.btndangki.Click += new System.EventHandler(this.btndangki_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(409, 385);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 10;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(573, 386);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 11;
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
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btndangki);
            this.Controls.Add(this.chklstbox);
            this.Controls.Add(this.rad4);
            this.Controls.Add(this.rad3);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.cmblop);
            this.Controls.Add(this.cmbnienkhoa);
            this.Controls.Add(this.txthovaten);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.lblmonhoc);
            this.Controls.Add(this.lblhocky);
            this.Controls.Add(this.lbllop);
            this.Controls.Add(this.lblniienkhoa);
            this.Controls.Add(this.lblhovaten);
            this.Controls.Add(this.lblmssv);
            this.Controls.Add(this.lblnhan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhan;
        private System.Windows.Forms.Label lblmssv;
        private System.Windows.Forms.Label lblhovaten;
        private System.Windows.Forms.Label lblniienkhoa;
        private System.Windows.Forms.Label lbllop;
        private System.Windows.Forms.Label lblhocky;
        private System.Windows.Forms.Label lblmonhoc;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.TextBox txthovaten;
        private System.Windows.Forms.ComboBox cmbnienkhoa;
        private System.Windows.Forms.ComboBox cmblop;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad3;
        private System.Windows.Forms.RadioButton rad4;
        private System.Windows.Forms.CheckedListBox chklstbox;
        private System.Windows.Forms.Button btndangki;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnthoat;
    }
}

