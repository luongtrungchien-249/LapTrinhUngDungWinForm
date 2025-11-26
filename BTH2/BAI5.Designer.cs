namespace BTH2
{
    partial class BAI5
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
            this.dgrvchienpa = new System.Windows.Forms.DataGridView();
            this.pnchienpa = new System.Windows.Forms.Panel();
            this.btnketthuc = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnnhap = new System.Windows.Forms.Button();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblquequan = new System.Windows.Forms.Label();
            this.lblmasv = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvchienpa)).BeginInit();
            this.pnchienpa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvchienpa
            // 
            this.dgrvchienpa.AllowUserToOrderColumns = true;
            this.dgrvchienpa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvchienpa.Location = new System.Drawing.Point(3, 107);
            this.dgrvchienpa.Name = "dgrvchienpa";
            this.dgrvchienpa.Size = new System.Drawing.Size(505, 279);
            this.dgrvchienpa.TabIndex = 0;
            // 
            // pnchienpa
            // 
            this.pnchienpa.Controls.Add(this.btnketthuc);
            this.pnchienpa.Controls.Add(this.btntim);
            this.pnchienpa.Controls.Add(this.btnxoa);
            this.pnchienpa.Controls.Add(this.btnsua);
            this.pnchienpa.Controls.Add(this.btnnhap);
            this.pnchienpa.Controls.Add(this.txtquequan);
            this.pnchienpa.Controls.Add(this.txtten);
            this.pnchienpa.Controls.Add(this.txtma);
            this.pnchienpa.Controls.Add(this.lblhoten);
            this.pnchienpa.Controls.Add(this.lblquequan);
            this.pnchienpa.Controls.Add(this.lblmasv);
            this.pnchienpa.Controls.Add(this.dgrvchienpa);
            this.pnchienpa.Location = new System.Drawing.Point(82, 31);
            this.pnchienpa.Name = "pnchienpa";
            this.pnchienpa.Size = new System.Drawing.Size(646, 389);
            this.pnchienpa.TabIndex = 1;
            this.pnchienpa.Paint += new System.Windows.Forms.PaintEventHandler(this.pnchienpa_Paint);
            // 
            // btnketthuc
            // 
            this.btnketthuc.Location = new System.Drawing.Point(541, 337);
            this.btnketthuc.Name = "btnketthuc";
            this.btnketthuc.Size = new System.Drawing.Size(75, 35);
            this.btnketthuc.TabIndex = 3;
            this.btnketthuc.Text = "Kết thúc";
            this.btnketthuc.UseVisualStyleBackColor = true;
            this.btnketthuc.Click += new System.EventHandler(this.btnketthuc_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(541, 282);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 35);
            this.btntim.TabIndex = 3;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(541, 228);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 35);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(541, 171);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 35);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(541, 118);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(75, 35);
            this.btnnhap.TabIndex = 3;
            this.btnnhap.Text = "Nhập";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // txtquequan
            // 
            this.txtquequan.Location = new System.Drawing.Point(309, 58);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(123, 20);
            this.txtquequan.TabIndex = 2;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(164, 58);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(122, 20);
            this.txtten.TabIndex = 2;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(28, 58);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(118, 20);
            this.txtma.TabIndex = 2;
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoten.Location = new System.Drawing.Point(185, 32);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(66, 16);
            this.lblhoten.TabIndex = 1;
            this.lblhoten.Text = "Họ Tên :";
            // 
            // lblquequan
            // 
            this.lblquequan.AutoSize = true;
            this.lblquequan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquequan.Location = new System.Drawing.Point(326, 32);
            this.lblquequan.Name = "lblquequan";
            this.lblquequan.Size = new System.Drawing.Size(83, 16);
            this.lblquequan.TabIndex = 1;
            this.lblquequan.Text = "Quê Quán :";
            // 
            // lblmasv
            // 
            this.lblmasv.AutoSize = true;
            this.lblmasv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmasv.Location = new System.Drawing.Point(49, 32);
            this.lblmasv.Name = "lblmasv";
            this.lblmasv.Size = new System.Drawing.Size(60, 16);
            this.lblmasv.TabIndex = 1;
            this.lblmasv.Text = "Mã SV :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BAI5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnchienpa);
            this.Name = "BAI5";
            this.Text = "BAI5";
            this.Load += new System.EventHandler(this.BAI5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvchienpa)).EndInit();
            this.pnchienpa.ResumeLayout(false);
            this.pnchienpa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvchienpa;
        private System.Windows.Forms.Panel pnchienpa;
        private System.Windows.Forms.Button btnketthuc;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblquequan;
        private System.Windows.Forms.Label lblmasv;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}