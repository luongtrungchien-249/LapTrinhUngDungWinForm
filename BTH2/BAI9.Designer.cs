namespace BTH2
{
    partial class BAI9
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
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblnhan = new System.Windows.Forms.Label();
            this.lblkhuvuc = new System.Windows.Forms.Label();
            this.lblsocu = new System.Windows.Forms.Label();
            this.lbldinhmuc = new System.Windows.Forms.Label();
            this.lblsomoi = new System.Windows.Forms.Label();
            this.lbltieuthu = new System.Windows.Forms.Label();
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.lstvchienpa = new System.Windows.Forms.ListView();
            this.btntinhtien = new System.Windows.Forms.Button();
            this.txtnhapmoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.txttieuthu = new System.Windows.Forms.TextBox();
            this.txtdinhmuc = new System.Windows.Forms.TextBox();
            this.txtsomoi = new System.Windows.Forms.TextBox();
            this.cbbkhuvuc = new System.Windows.Forms.ComboBox();
            this.txtsocu = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoten.ForeColor = System.Drawing.Color.Black;
            this.lblhoten.Location = new System.Drawing.Point(20, 106);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(101, 18);
            this.lblhoten.TabIndex = 0;
            this.lblhoten.Text = "Họ Tên KH :";
            // 
            // lblnhan
            // 
            this.lblnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhan.Location = new System.Drawing.Point(12, 9);
            this.lblnhan.Name = "lblnhan";
            this.lblnhan.Size = new System.Drawing.Size(311, 91);
            this.lblnhan.TabIndex = 0;
            this.lblnhan.Text = "Báo Cáo Tiêu Thụ Điện";
            this.lblnhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblkhuvuc
            // 
            this.lblkhuvuc.AutoSize = true;
            this.lblkhuvuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkhuvuc.Location = new System.Drawing.Point(20, 144);
            this.lblkhuvuc.Name = "lblkhuvuc";
            this.lblkhuvuc.Size = new System.Drawing.Size(78, 18);
            this.lblkhuvuc.TabIndex = 0;
            this.lblkhuvuc.Text = "Khu vực :";
            // 
            // lblsocu
            // 
            this.lblsocu.AutoSize = true;
            this.lblsocu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsocu.Location = new System.Drawing.Point(20, 214);
            this.lblsocu.Name = "lblsocu";
            this.lblsocu.Size = new System.Drawing.Size(65, 18);
            this.lblsocu.TabIndex = 0;
            this.lblsocu.Text = "Số Cũ :";
            // 
            // lbldinhmuc
            // 
            this.lbldinhmuc.AutoSize = true;
            this.lbldinhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldinhmuc.Location = new System.Drawing.Point(20, 179);
            this.lbldinhmuc.Name = "lbldinhmuc";
            this.lbldinhmuc.Size = new System.Drawing.Size(89, 18);
            this.lbldinhmuc.TabIndex = 0;
            this.lbldinhmuc.Text = "Định mức :";
            // 
            // lblsomoi
            // 
            this.lblsomoi.AutoSize = true;
            this.lblsomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsomoi.Location = new System.Drawing.Point(20, 249);
            this.lblsomoi.Name = "lblsomoi";
            this.lblsomoi.Size = new System.Drawing.Size(72, 18);
            this.lblsomoi.TabIndex = 0;
            this.lblsomoi.Text = "Số mới :";
            // 
            // lbltieuthu
            // 
            this.lbltieuthu.AutoSize = true;
            this.lbltieuthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieuthu.Location = new System.Drawing.Point(20, 282);
            this.lbltieuthu.Name = "lbltieuthu";
            this.lbltieuthu.Size = new System.Drawing.Size(78, 18);
            this.lbltieuthu.TabIndex = 0;
            this.lbltieuthu.Text = "Tiêu thụ :";
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.AutoSize = true;
            this.lblthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthanhtien.Location = new System.Drawing.Point(20, 317);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(101, 18);
            this.lblthanhtien.TabIndex = 0;
            this.lblthanhtien.Text = "Thành Tiền :";
            // 
            // lstvchienpa
            // 
            this.lstvchienpa.FullRowSelect = true;
            this.lstvchienpa.HideSelection = false;
            this.lstvchienpa.HoverSelection = true;
            this.lstvchienpa.Location = new System.Drawing.Point(347, 9);
            this.lstvchienpa.Name = "lstvchienpa";
            this.lstvchienpa.Size = new System.Drawing.Size(421, 334);
            this.lstvchienpa.TabIndex = 1;
            this.lstvchienpa.UseCompatibleStateImageBehavior = false;
            this.lstvchienpa.View = System.Windows.Forms.View.Details;
            // 
            // btntinhtien
            // 
            this.btntinhtien.Location = new System.Drawing.Point(34, 376);
            this.btntinhtien.Name = "btntinhtien";
            this.btntinhtien.Size = new System.Drawing.Size(87, 35);
            this.btntinhtien.TabIndex = 2;
            this.btntinhtien.Text = "TÍNH TIỀN";
            this.btntinhtien.UseVisualStyleBackColor = true;
            this.btntinhtien.Click += new System.EventHandler(this.btntinhtien_Click);
            // 
            // txtnhapmoi
            // 
            this.txtnhapmoi.Location = new System.Drawing.Point(130, 376);
            this.txtnhapmoi.Name = "txtnhapmoi";
            this.txtnhapmoi.Size = new System.Drawing.Size(87, 35);
            this.txtnhapmoi.TabIndex = 2;
            this.txtnhapmoi.Text = "Nhập Mới";
            this.txtnhapmoi.UseVisualStyleBackColor = true;
            this.txtnhapmoi.Click += new System.EventHandler(this.txtnhapmoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Location = new System.Drawing.Point(226, 376);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(87, 35);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(693, 385);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(127, 317);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.ReadOnly = true;
            this.txtthanhtien.Size = new System.Drawing.Size(187, 20);
            this.txtthanhtien.TabIndex = 3;
            // 
            // txttieuthu
            // 
            this.txttieuthu.Location = new System.Drawing.Point(127, 282);
            this.txttieuthu.Name = "txttieuthu";
            this.txttieuthu.Size = new System.Drawing.Size(187, 20);
            this.txttieuthu.TabIndex = 3;
            // 
            // txtdinhmuc
            // 
            this.txtdinhmuc.Location = new System.Drawing.Point(127, 177);
            this.txtdinhmuc.Name = "txtdinhmuc";
            this.txtdinhmuc.Size = new System.Drawing.Size(187, 20);
            this.txtdinhmuc.TabIndex = 3;
            // 
            // txtsomoi
            // 
            this.txtsomoi.Location = new System.Drawing.Point(127, 247);
            this.txtsomoi.Name = "txtsomoi";
            this.txtsomoi.Size = new System.Drawing.Size(187, 20);
            this.txtsomoi.TabIndex = 3;
            // 
            // cbbkhuvuc
            // 
            this.cbbkhuvuc.FormattingEnabled = true;
            this.cbbkhuvuc.Location = new System.Drawing.Point(127, 141);
            this.cbbkhuvuc.Name = "cbbkhuvuc";
            this.cbbkhuvuc.Size = new System.Drawing.Size(187, 21);
            this.cbbkhuvuc.TabIndex = 4;
            this.cbbkhuvuc.SelectedIndexChanged += new System.EventHandler(this.cbbkhuvuc_SelectedIndexChanged);
            // 
            // txtsocu
            // 
            this.txtsocu.Location = new System.Drawing.Point(127, 212);
            this.txtsocu.Name = "txtsocu";
            this.txtsocu.Size = new System.Drawing.Size(187, 20);
            this.txtsocu.TabIndex = 3;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(127, 106);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(187, 20);
            this.txthoten.TabIndex = 3;
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongtien.Location = new System.Drawing.Point(344, 386);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(90, 16);
            this.lbltongtien.TabIndex = 0;
            this.lbltongtien.Text = "Tổng Tiền  :";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(440, 385);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.ReadOnly = true;
            this.txttongtien.Size = new System.Drawing.Size(179, 20);
            this.txttongtien.TabIndex = 3;
            this.txttongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BAI9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(780, 456);
            this.Controls.Add(this.cbbkhuvuc);
            this.Controls.Add(this.txtsomoi);
            this.Controls.Add(this.txtsocu);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtdinhmuc);
            this.Controls.Add(this.txttieuthu);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.txtthanhtien);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtnhapmoi);
            this.Controls.Add(this.btntinhtien);
            this.Controls.Add(this.lstvchienpa);
            this.Controls.Add(this.lblnhan);
            this.Controls.Add(this.lbldinhmuc);
            this.Controls.Add(this.lblthanhtien);
            this.Controls.Add(this.lbltieuthu);
            this.Controls.Add(this.lblsomoi);
            this.Controls.Add(this.lblsocu);
            this.Controls.Add(this.lblkhuvuc);
            this.Controls.Add(this.lbltongtien);
            this.Controls.Add(this.lblhoten);
            this.Name = "BAI9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tiền điện";
            this.Load += new System.EventHandler(this.BAI9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblnhan;
        private System.Windows.Forms.Label lblkhuvuc;
        private System.Windows.Forms.Label lblsocu;
        private System.Windows.Forms.Label lbldinhmuc;
        private System.Windows.Forms.Label lblsomoi;
        private System.Windows.Forms.Label lbltieuthu;
        private System.Windows.Forms.Label lblthanhtien;
        private System.Windows.Forms.ListView lstvchienpa;
        private System.Windows.Forms.Button btntinhtien;
        private System.Windows.Forms.Button txtnhapmoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txttieuthu;
        private System.Windows.Forms.TextBox txtdinhmuc;
        private System.Windows.Forms.TextBox txtsomoi;
        private System.Windows.Forms.ComboBox cbbkhuvuc;
        private System.Windows.Forms.TextBox txtsocu;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}