using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH3
{
    public partial class frmcauhinh : Form
    {

        public frmcauhinh()
        {
            InitializeComponent();
        }

        private void frmcauhinh_Load(object sender, EventArgs e)
        {
            string quyen, SN, DN, UN, PW;
            DataHelper.DocTep(Program.configFile, out quyen, out SN, out DN, out UN, out PW);

            if (quyen == "WD")
                radwd.Checked = true;
            else
                radacc.Checked = true;

            txtip.Text = SN;
            txtdataname.Text = DN;
            txtusername.Text = UN;
            txtpass.Text = PW;
        }

        private void btncauhinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtip.Text))
            {
                MessageBox.Show("Vui lòng nhập Server Name!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtip.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtdataname.Text))
            {
                MessageBox.Show("Vui lòng nhập Database Name!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdataname.Focus();
                return;
            }

            if (!radwd.Checked && string.IsNullOrWhiteSpace(txtusername.Text))
            {
                MessageBox.Show("Vui lòng nhập Username!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return;
            }

            string SN = txtip.Text.Trim();
            string DN = txtdataname.Text.Trim();
            string UN = txtusername.Text.Trim();
            string PW = txtpass.Text.Trim();
            string quyen = radwd.Checked ? "WD" : "AC";

            try
            {
                // Test kết nối trước
                DataHelper testDb = quyen == "WD"
                    ? new DataHelper(SN, DN)
                    : new DataHelper(SN, DN, UN, PW);

                testDb.MoKetNoi();
                testDb.DongKetNoi();

                // Lưu cấu hình
                DataHelper.GhiTep(Program.configFile, quyen, SN, DN, UN, PW);
                Program.Db = testDb;

                MessageBox.Show("Cấu hình thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new frmdangnhap().ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

