namespace BTH2
{
    partial class BAI7
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
            this.lstvchienpa = new System.Windows.Forms.ListView();
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblnhan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trvchienpa
            // 
            this.trvchienpa.Location = new System.Drawing.Point(12, 49);
            this.trvchienpa.Name = "trvchienpa";
            this.trvchienpa.Size = new System.Drawing.Size(373, 389);
            this.trvchienpa.TabIndex = 0;
            // 
            // lstvchienpa
            // 
            this.lstvchienpa.HideSelection = false;
            this.lstvchienpa.Location = new System.Drawing.Point(412, 49);
            this.lstvchienpa.Name = "lstvchienpa";
            this.lstvchienpa.Size = new System.Drawing.Size(376, 389);
            this.lstvchienpa.TabIndex = 1;
            this.lstvchienpa.UseCompatibleStateImageBehavior = false;
            this.lstvchienpa.View = System.Windows.Forms.View.Details;
            this.lstvchienpa.SelectedIndexChanged += new System.EventHandler(this.lstvchienpa_SelectedIndexChanged);
            // 
            // txtnhapten
            // 
            this.txtnhapten.Location = new System.Drawing.Point(572, 13);
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(100, 20);
            this.txtnhapten.TabIndex = 2;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(689, 10);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(99, 23);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Tìm";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblnhan
            // 
            this.lblnhan.AutoSize = true;
            this.lblnhan.Location = new System.Drawing.Point(505, 16);
            this.lblnhan.Name = "lblnhan";
            this.lblnhan.Size = new System.Drawing.Size(61, 13);
            this.lblnhan.TabIndex = 4;
            this.lblnhan.Text = "Nhập Tên :";
            // 
            // BAI7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnhan);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtnhapten);
            this.Controls.Add(this.lstvchienpa);
            this.Controls.Add(this.trvchienpa);
            this.Name = "BAI7";
            this.Text = "BAI7";
            this.Load += new System.EventHandler(this.BAI7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvchienpa;
        private System.Windows.Forms.ListView lstvchienpa;
        private System.Windows.Forms.TextBox txtnhapten;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lblnhan;
    }
}