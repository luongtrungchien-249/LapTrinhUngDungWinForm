namespace baiTH110
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
            this.components = new System.ComponentModel.Container();
            this.lblhoten = new System.Windows.Forms.Label();
            this.grblopa = new System.Windows.Forms.GroupBox();
            this.lstlopa = new System.Windows.Forms.ListBox();
            this.grblopb = new System.Windows.Forms.GroupBox();
            this.lstlopb = new System.Windows.Forms.ListBox();
            this.txthovaten = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsangb = new System.Windows.Forms.Button();
            this.btnsangb1 = new System.Windows.Forms.Button();
            this.btnsanga = new System.Windows.Forms.Button();
            this.btnsanga1 = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnketthuc = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grblopa.SuspendLayout();
            this.grblopb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(137, 55);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(68, 13);
            this.lblhoten.TabIndex = 0;
            this.lblhoten.Text = "Họ Và Tên : ";
            // 
            // grblopa
            // 
            this.grblopa.Controls.Add(this.lstlopa);
            this.grblopa.Location = new System.Drawing.Point(140, 95);
            this.grblopa.Name = "grblopa";
            this.grblopa.Size = new System.Drawing.Size(200, 151);
            this.grblopa.TabIndex = 1;
            this.grblopa.TabStop = false;
            this.grblopa.Text = "Lớp A";
            // 
            // lstlopa
            // 
            this.lstlopa.FormattingEnabled = true;
            this.lstlopa.Location = new System.Drawing.Point(21, 19);
            this.lstlopa.Name = "lstlopa";
            this.lstlopa.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstlopa.Size = new System.Drawing.Size(161, 121);
            this.lstlopa.TabIndex = 0;
            this.lstlopa.SelectedIndexChanged += new System.EventHandler(this.lstlopa_SelectedIndexChanged);
            // 
            // grblopb
            // 
            this.grblopb.Controls.Add(this.lstlopb);
            this.grblopb.Location = new System.Drawing.Point(469, 95);
            this.grblopb.Name = "grblopb";
            this.grblopb.Size = new System.Drawing.Size(200, 151);
            this.grblopb.TabIndex = 1;
            this.grblopb.TabStop = false;
            this.grblopb.Text = "Lớp B";
            // 
            // lstlopb
            // 
            this.lstlopb.FormattingEnabled = true;
            this.lstlopb.Location = new System.Drawing.Point(20, 19);
            this.lstlopb.Name = "lstlopb";
            this.lstlopb.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstlopb.Size = new System.Drawing.Size(161, 121);
            this.lstlopb.TabIndex = 0;
            // 
            // txthovaten
            // 
            this.txthovaten.Location = new System.Drawing.Point(211, 52);
            this.txthovaten.Name = "txthovaten";
            this.txthovaten.Size = new System.Drawing.Size(377, 20);
            this.txthovaten.TabIndex = 2;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(594, 50);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Cập Nhật";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsangb
            // 
            this.btnsangb.Location = new System.Drawing.Point(363, 95);
            this.btnsangb.Name = "btnsangb";
            this.btnsangb.Size = new System.Drawing.Size(75, 23);
            this.btnsangb.TabIndex = 3;
            this.btnsangb.Text = ">";
            this.btnsangb.UseVisualStyleBackColor = true;
            this.btnsangb.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsangb1
            // 
            this.btnsangb1.Location = new System.Drawing.Point(363, 136);
            this.btnsangb1.Name = "btnsangb1";
            this.btnsangb1.Size = new System.Drawing.Size(75, 23);
            this.btnsangb1.TabIndex = 3;
            this.btnsangb1.Text = ">>";
            this.btnsangb1.UseVisualStyleBackColor = true;
            this.btnsangb1.Click += new System.EventHandler(this.btnsangb1_Click);
            // 
            // btnsanga
            // 
            this.btnsanga.Location = new System.Drawing.Point(363, 176);
            this.btnsanga.Name = "btnsanga";
            this.btnsanga.Size = new System.Drawing.Size(75, 23);
            this.btnsanga.TabIndex = 3;
            this.btnsanga.Text = "<";
            this.btnsanga.UseVisualStyleBackColor = true;
            this.btnsanga.Click += new System.EventHandler(this.btnsanga_Click);
            // 
            // btnsanga1
            // 
            this.btnsanga1.Location = new System.Drawing.Point(363, 223);
            this.btnsanga1.Name = "btnsanga1";
            this.btnsanga1.Size = new System.Drawing.Size(75, 23);
            this.btnsanga1.TabIndex = 3;
            this.btnsanga1.Text = "<<";
            this.btnsanga1.UseVisualStyleBackColor = true;
            this.btnsanga1.Click += new System.EventHandler(this.btnsanga1_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(161, 270);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(161, 23);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnketthuc
            // 
            this.btnketthuc.Location = new System.Drawing.Point(489, 270);
            this.btnketthuc.Name = "btnketthuc";
            this.btnketthuc.Size = new System.Drawing.Size(161, 23);
            this.btnketthuc.TabIndex = 3;
            this.btnketthuc.Text = "Kết thúc";
            this.btnketthuc.UseVisualStyleBackColor = true;
            this.btnketthuc.Click += new System.EventHandler(this.btnketthuc_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsanga1);
            this.Controls.Add(this.btnsanga);
            this.Controls.Add(this.btnsangb1);
            this.Controls.Add(this.btnsangb);
            this.Controls.Add(this.btnketthuc);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txthovaten);
            this.Controls.Add(this.grblopb);
            this.Controls.Add(this.grblopa);
            this.Controls.Add(this.lblhoten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grblopa.ResumeLayout(false);
            this.grblopb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.GroupBox grblopa;
        private System.Windows.Forms.ListBox lstlopa;
        private System.Windows.Forms.GroupBox grblopb;
        private System.Windows.Forms.ListBox lstlopb;
        private System.Windows.Forms.TextBox txthovaten;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsangb;
        private System.Windows.Forms.Button btnsangb1;
        private System.Windows.Forms.Button btnsanga;
        private System.Windows.Forms.Button btnsanga1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnketthuc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

