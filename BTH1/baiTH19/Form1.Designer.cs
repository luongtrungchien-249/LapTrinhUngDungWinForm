namespace baiTH19
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
            this.grblistbox = new System.Windows.Forms.GroupBox();
            this.grbsulylistbox = new System.Windows.Forms.GroupBox();
            this.btnketthuc = new System.Windows.Forms.Button();
            this.btntong = new System.Windows.Forms.Button();
            this.btnxoadaucuoi = new System.Windows.Forms.Button();
            this.btnxoadangchon = new System.Windows.Forms.Button();
            this.btntang2 = new System.Windows.Forms.Button();
            this.btnbinhphuong = new System.Windows.Forms.Button();
            this.btnchan = new System.Windows.Forms.Button();
            this.btnchonsole = new System.Windows.Forms.Button();
            this.btnnhap = new System.Windows.Forms.Button();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.lstchienpa = new System.Windows.Forms.ListBox();
            this.grblistbox.SuspendLayout();
            this.grbsulylistbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnhan
            // 
            this.lblnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhan.ForeColor = System.Drawing.Color.Orange;
            this.lblnhan.Location = new System.Drawing.Point(1, 0);
            this.lblnhan.Name = "lblnhan";
            this.lblnhan.Size = new System.Drawing.Size(798, 69);
            this.lblnhan.TabIndex = 0;
            this.lblnhan.Text = "LISTBOX";
            this.lblnhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grblistbox
            // 
            this.grblistbox.Controls.Add(this.lstchienpa);
            this.grblistbox.Controls.Add(this.txtinput);
            this.grblistbox.Controls.Add(this.btnnhap);
            this.grblistbox.Location = new System.Drawing.Point(238, 66);
            this.grblistbox.Name = "grblistbox";
            this.grblistbox.Size = new System.Drawing.Size(141, 292);
            this.grblistbox.TabIndex = 1;
            this.grblistbox.TabStop = false;
            this.grblistbox.Text = "ListBox";
            // 
            // grbsulylistbox
            // 
            this.grbsulylistbox.Controls.Add(this.btntong);
            this.grbsulylistbox.Controls.Add(this.btnchonsole);
            this.grbsulylistbox.Controls.Add(this.btnchan);
            this.grbsulylistbox.Controls.Add(this.btnbinhphuong);
            this.grbsulylistbox.Controls.Add(this.btntang2);
            this.grbsulylistbox.Controls.Add(this.btnxoadangchon);
            this.grbsulylistbox.Controls.Add(this.btnxoadaucuoi);
            this.grbsulylistbox.Location = new System.Drawing.Point(385, 66);
            this.grbsulylistbox.Name = "grbsulylistbox";
            this.grbsulylistbox.Size = new System.Drawing.Size(242, 292);
            this.grbsulylistbox.TabIndex = 1;
            this.grbsulylistbox.TabStop = false;
            this.grbsulylistbox.Text = "Sử lý ListBox";
            // 
            // btnketthuc
            // 
            this.btnketthuc.Location = new System.Drawing.Point(238, 364);
            this.btnketthuc.Name = "btnketthuc";
            this.btnketthuc.Size = new System.Drawing.Size(389, 39);
            this.btnketthuc.TabIndex = 2;
            this.btnketthuc.Text = "Kết Thúc";
            this.btnketthuc.UseVisualStyleBackColor = true;
            this.btnketthuc.Click += new System.EventHandler(this.btnketthuc_Click);
            // 
            // btntong
            // 
            this.btntong.Location = new System.Drawing.Point(0, 19);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(242, 33);
            this.btntong.TabIndex = 2;
            this.btntong.Text = "Tổng các phần tử trong List";
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // btnxoadaucuoi
            // 
            this.btnxoadaucuoi.Location = new System.Drawing.Point(0, 54);
            this.btnxoadaucuoi.Name = "btnxoadaucuoi";
            this.btnxoadaucuoi.Size = new System.Drawing.Size(242, 33);
            this.btnxoadaucuoi.TabIndex = 2;
            this.btnxoadaucuoi.Text = "Xóa phần tử đầu và cuối";
            this.btnxoadaucuoi.UseVisualStyleBackColor = true;
            this.btnxoadaucuoi.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnxoadangchon
            // 
            this.btnxoadangchon.Location = new System.Drawing.Point(0, 93);
            this.btnxoadangchon.Name = "btnxoadangchon";
            this.btnxoadangchon.Size = new System.Drawing.Size(242, 33);
            this.btnxoadangchon.TabIndex = 2;
            this.btnxoadangchon.Text = "Xóa phần tử đang chọn";
            this.btnxoadangchon.UseVisualStyleBackColor = true;
            this.btnxoadangchon.Click += new System.EventHandler(this.btnxoadangchon_Click);
            // 
            // btntang2
            // 
            this.btntang2.Location = new System.Drawing.Point(0, 132);
            this.btntang2.Name = "btntang2";
            this.btntang2.Size = new System.Drawing.Size(242, 33);
            this.btntang2.TabIndex = 2;
            this.btntang2.Text = "Tăng mỗi phần tử lên 2";
            this.btntang2.UseVisualStyleBackColor = true;
            this.btntang2.Click += new System.EventHandler(this.btntang2_Click);
            // 
            // btnbinhphuong
            // 
            this.btnbinhphuong.Location = new System.Drawing.Point(0, 171);
            this.btnbinhphuong.Name = "btnbinhphuong";
            this.btnbinhphuong.Size = new System.Drawing.Size(242, 33);
            this.btnbinhphuong.TabIndex = 2;
            this.btnbinhphuong.Text = "Bình phương";
            this.btnbinhphuong.UseVisualStyleBackColor = true;
            this.btnbinhphuong.Click += new System.EventHandler(this.btnbinhphuong_Click);
            // 
            // btnchan
            // 
            this.btnchan.Location = new System.Drawing.Point(0, 210);
            this.btnchan.Name = "btnchan";
            this.btnchan.Size = new System.Drawing.Size(242, 33);
            this.btnchan.TabIndex = 2;
            this.btnchan.Text = "Chọn số chẵn";
            this.btnchan.UseVisualStyleBackColor = true;
            this.btnchan.Click += new System.EventHandler(this.btnchan_Click);
            // 
            // btnchonsole
            // 
            this.btnchonsole.Location = new System.Drawing.Point(0, 249);
            this.btnchonsole.Name = "btnchonsole";
            this.btnchonsole.Size = new System.Drawing.Size(242, 33);
            this.btnchonsole.TabIndex = 2;
            this.btnchonsole.Text = "Chọn Số Lẻ";
            this.btnchonsole.UseVisualStyleBackColor = true;
            this.btnchonsole.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(0, 54);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(141, 36);
            this.btnnhap.TabIndex = 2;
            this.btnnhap.Text = "Nhập";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(0, 28);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(141, 20);
            this.txtinput.TabIndex = 3;
            // 
            // lstchienpa
            // 
            this.lstchienpa.FormattingEnabled = true;
            this.lstchienpa.Location = new System.Drawing.Point(7, 97);
            this.lstchienpa.Name = "lstchienpa";
            this.lstchienpa.Size = new System.Drawing.Size(128, 186);
            this.lstchienpa.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnketthuc);
            this.Controls.Add(this.grbsulylistbox);
            this.Controls.Add(this.grblistbox);
            this.Controls.Add(this.lblnhan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grblistbox.ResumeLayout(false);
            this.grblistbox.PerformLayout();
            this.grbsulylistbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblnhan;
        private System.Windows.Forms.GroupBox grblistbox;
        private System.Windows.Forms.GroupBox grbsulylistbox;
        private System.Windows.Forms.Button btnketthuc;
        private System.Windows.Forms.ListBox lstchienpa;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.Button btnchonsole;
        private System.Windows.Forms.Button btnchan;
        private System.Windows.Forms.Button btnbinhphuong;
        private System.Windows.Forms.Button btntang2;
        private System.Windows.Forms.Button btnxoadangchon;
        private System.Windows.Forms.Button btnxoadaucuoi;
    }
}

