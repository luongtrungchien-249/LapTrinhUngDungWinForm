namespace BTH3
{
    partial class frmquanlynhanvien
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
            this.dgrvbaith3 = new System.Windows.Forms.DataGridView();
            this.dataForWinFormDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataForWinFormDataSet = new BTH3.DataForWinFormDataSet();
            this.grbthongtin = new System.Windows.Forms.GroupBox();
            this.cboquyen = new System.Windows.Forms.ComboBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.lblquyen = new System.Windows.Forms.Label();
            this.lbltendangnhap = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.lblma = new System.Windows.Forms.Label();
            this.pnbutton = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new BTH3.DataForWinFormDataSetTableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvbaith3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForWinFormDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForWinFormDataSet)).BeginInit();
            this.grbthongtin.SuspendLayout();
            this.pnbutton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvbaith3
            // 
            this.dgrvbaith3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvbaith3.Location = new System.Drawing.Point(0, 0);
            this.dgrvbaith3.Name = "dgrvbaith3";
            this.dgrvbaith3.Size = new System.Drawing.Size(854, 221);
            this.dgrvbaith3.TabIndex = 0;
            this.dgrvbaith3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvbaith3_CellContentClick);
            // 
            // dataForWinFormDataSetBindingSource
            // 
            this.dataForWinFormDataSetBindingSource.DataSource = this.dataForWinFormDataSet;
            this.dataForWinFormDataSetBindingSource.Position = 0;
            // 
            // dataForWinFormDataSet
            // 
            this.dataForWinFormDataSet.DataSetName = "DataForWinFormDataSet";
            this.dataForWinFormDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbthongtin
            // 
            this.grbthongtin.Controls.Add(this.cboquyen);
            this.grbthongtin.Controls.Add(this.txtuser);
            this.grbthongtin.Controls.Add(this.txtdiachi);
            this.grbthongtin.Controls.Add(this.txttennv);
            this.grbthongtin.Controls.Add(this.txtmanv);
            this.grbthongtin.Controls.Add(this.lblquyen);
            this.grbthongtin.Controls.Add(this.lbltendangnhap);
            this.grbthongtin.Controls.Add(this.lbldiachi);
            this.grbthongtin.Controls.Add(this.lblten);
            this.grbthongtin.Controls.Add(this.lblma);
            this.grbthongtin.Location = new System.Drawing.Point(13, 250);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Size = new System.Drawing.Size(537, 295);
            this.grbthongtin.TabIndex = 1;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Thông tin cơ bản";
            // 
            // cboquyen
            // 
            this.cboquyen.FormattingEnabled = true;
            this.cboquyen.Location = new System.Drawing.Point(178, 219);
            this.cboquyen.Name = "cboquyen";
            this.cboquyen.Size = new System.Drawing.Size(316, 21);
            this.cboquyen.TabIndex = 2;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(178, 174);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(316, 20);
            this.txtuser.TabIndex = 1;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(178, 127);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(316, 20);
            this.txtdiachi.TabIndex = 1;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(178, 86);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(316, 20);
            this.txttennv.TabIndex = 1;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(178, 44);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(316, 20);
            this.txtmanv.TabIndex = 1;
            // 
            // lblquyen
            // 
            this.lblquyen.AutoSize = true;
            this.lblquyen.Location = new System.Drawing.Point(40, 219);
            this.lblquyen.Name = "lblquyen";
            this.lblquyen.Size = new System.Drawing.Size(59, 13);
            this.lblquyen.TabIndex = 0;
            this.lblquyen.Text = "Quyền hạn";
            // 
            // lbltendangnhap
            // 
            this.lbltendangnhap.AutoSize = true;
            this.lbltendangnhap.Location = new System.Drawing.Point(40, 174);
            this.lbltendangnhap.Name = "lbltendangnhap";
            this.lbltendangnhap.Size = new System.Drawing.Size(87, 13);
            this.lbltendangnhap.TabIndex = 0;
            this.lbltendangnhap.Text = "Tên đăng nhập :";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(40, 127);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(46, 13);
            this.lbldiachi.TabIndex = 0;
            this.lbldiachi.Text = "Địa chỉ :";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(40, 89);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(85, 13);
            this.lblten.TabIndex = 0;
            this.lblten.Text = "Tên nhân viên : ";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Location = new System.Drawing.Point(40, 44);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(78, 13);
            this.lblma.TabIndex = 0;
            this.lblma.Text = "Mã nhân viên :";
            // 
            // pnbutton
            // 
            this.pnbutton.Controls.Add(this.btnthoat);
            this.pnbutton.Controls.Add(this.btnxoa);
            this.pnbutton.Controls.Add(this.btnsua);
            this.pnbutton.Controls.Add(this.btntaomoi);
            this.pnbutton.Location = new System.Drawing.Point(569, 260);
            this.pnbutton.Name = "pnbutton";
            this.pnbutton.Size = new System.Drawing.Size(273, 285);
            this.pnbutton.TabIndex = 2;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(68, 219);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(164, 38);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(68, 151);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(164, 38);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa NV";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(68, 79);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(164, 38);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa NV";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntaomoi
            // 
            this.btntaomoi.Location = new System.Drawing.Point(68, 16);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(164, 38);
            this.btntaomoi.TabIndex = 0;
            this.btntaomoi.Text = "Tạo mới";
            this.btntaomoi.UseVisualStyleBackColor = true;
            this.btntaomoi.Click += new System.EventHandler(this.btntaomoi_Click);
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dataForWinFormDataSetBindingSource;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmquanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 557);
            this.Controls.Add(this.pnbutton);
            this.Controls.Add(this.grbthongtin);
            this.Controls.Add(this.dgrvbaith3);
            this.Name = "frmquanlynhanvien";
            this.Text = "frmquanlynhanvien";
            this.Load += new System.EventHandler(this.frmquanlynhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvbaith3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForWinFormDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataForWinFormDataSet)).EndInit();
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            this.pnbutton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvbaith3;
        private System.Windows.Forms.GroupBox grbthongtin;
        private System.Windows.Forms.Panel pnbutton;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.ComboBox cboquyen;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label lblquyen;
        private System.Windows.Forms.Label lbltendangnhap;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntaomoi;
        private System.Windows.Forms.BindingSource dataForWinFormDataSetBindingSource;
        private DataForWinFormDataSet dataForWinFormDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DataForWinFormDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
    }
}