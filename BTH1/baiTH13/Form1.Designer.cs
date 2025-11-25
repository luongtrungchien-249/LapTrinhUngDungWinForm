namespace baiTH13
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
            this.grbnhapso = new System.Windows.Forms.GroupBox();
            this.cbbSo = new System.Windows.Forms.ComboBox();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.txtnhapso = new System.Windows.Forms.TextBox();
            this.grbdscacbuocso = new System.Windows.Forms.GroupBox();
            this.lstuocso = new System.Windows.Forms.ListBox();
            this.btnsum = new System.Windows.Forms.Button();
            this.btnsoluongcacuocchan = new System.Windows.Forms.Button();
            this.btnsoluonguocnguyento = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.grbnhapso.SuspendLayout();
            this.grbdscacbuocso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbnhapso
            // 
            this.grbnhapso.Controls.Add(this.cbbSo);
            this.grbnhapso.Controls.Add(this.btncapnhat);
            this.grbnhapso.Controls.Add(this.txtnhapso);
            this.grbnhapso.Location = new System.Drawing.Point(203, 57);
            this.grbnhapso.Name = "grbnhapso";
            this.grbnhapso.Size = new System.Drawing.Size(200, 176);
            this.grbnhapso.TabIndex = 0;
            this.grbnhapso.TabStop = false;
            this.grbnhapso.Text = "Nhập Số";
            // 
            // cbbSo
            // 
            this.cbbSo.FormattingEnabled = true;
            this.cbbSo.Location = new System.Drawing.Point(19, 98);
            this.cbbSo.Name = "cbbSo";
            this.cbbSo.Size = new System.Drawing.Size(175, 21);
            this.cbbSo.TabIndex = 2;
            this.cbbSo.SelectedIndexChanged += new System.EventHandler(this.cbbSo_SelectedIndexChanged);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(125, 38);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 23);
            this.btncapnhat.TabIndex = 1;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // txtnhapso
            // 
            this.txtnhapso.Location = new System.Drawing.Point(19, 38);
            this.txtnhapso.Name = "txtnhapso";
            this.txtnhapso.Size = new System.Drawing.Size(100, 20);
            this.txtnhapso.TabIndex = 0;
            // 
            // grbdscacbuocso
            // 
            this.grbdscacbuocso.Controls.Add(this.lstuocso);
            this.grbdscacbuocso.Location = new System.Drawing.Point(409, 57);
            this.grbdscacbuocso.Name = "grbdscacbuocso";
            this.grbdscacbuocso.Size = new System.Drawing.Size(200, 176);
            this.grbdscacbuocso.TabIndex = 1;
            this.grbdscacbuocso.TabStop = false;
            this.grbdscacbuocso.Text = "Danh sách các bước số";
            // 
            // lstuocso
            // 
            this.lstuocso.FormattingEnabled = true;
            this.lstuocso.Location = new System.Drawing.Point(20, 26);
            this.lstuocso.Name = "lstuocso";
            this.lstuocso.Size = new System.Drawing.Size(162, 134);
            this.lstuocso.TabIndex = 0;
            // 
            // btnsum
            // 
            this.btnsum.Location = new System.Drawing.Point(409, 263);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(200, 23);
            this.btnsum.TabIndex = 2;
            this.btnsum.Text = "Tổng các ước số";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btnsoluongcacuocchan
            // 
            this.btnsoluongcacuocchan.Location = new System.Drawing.Point(409, 292);
            this.btnsoluongcacuocchan.Name = "btnsoluongcacuocchan";
            this.btnsoluongcacuocchan.Size = new System.Drawing.Size(200, 23);
            this.btnsoluongcacuocchan.TabIndex = 2;
            this.btnsoluongcacuocchan.Text = "Số lượng các ước chẵn ";
            this.btnsoluongcacuocchan.UseVisualStyleBackColor = true;
            this.btnsoluongcacuocchan.Click += new System.EventHandler(this.btnsoluongcacuocchan_Click);
            // 
            // btnsoluonguocnguyento
            // 
            this.btnsoluonguocnguyento.Location = new System.Drawing.Point(409, 321);
            this.btnsoluonguocnguyento.Name = "btnsoluonguocnguyento";
            this.btnsoluonguocnguyento.Size = new System.Drawing.Size(200, 23);
            this.btnsoluonguocnguyento.TabIndex = 2;
            this.btnsoluonguocnguyento.Text = "Số lượng các ước nguyên tố";
            this.btnsoluonguocnguyento.UseVisualStyleBackColor = true;
            this.btnsoluonguocnguyento.Click += new System.EventHandler(this.btnsoluonguocnguyento_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(314, 321);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(89, 23);
            this.btnthoat.TabIndex = 2;
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
            this.Controls.Add(this.btnsoluonguocnguyento);
            this.Controls.Add(this.btnsoluongcacuocchan);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.grbdscacbuocso);
            this.Controls.Add(this.grbnhapso);
            this.Name = "Form1";
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbnhapso.ResumeLayout(false);
            this.grbnhapso.PerformLayout();
            this.grbdscacbuocso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbnhapso;
        private System.Windows.Forms.TextBox txtnhapso;
        private System.Windows.Forms.GroupBox grbdscacbuocso;
        private System.Windows.Forms.ListBox lstuocso;
        private System.Windows.Forms.ComboBox cbbSo;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnsoluongcacuocchan;
        private System.Windows.Forms.Button btnsoluonguocnguyento;
        private System.Windows.Forms.Button btnthoat;
    }
}

