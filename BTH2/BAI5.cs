using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH2
{
    public partial class BAI5 : Form
    {
        public BAI5()
        {
            InitializeComponent();
        }

        private void pnchienpa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BAI5_Load(object sender, EventArgs e)
        {
            dgrvchienpa.Columns.Add("colmasv", "Mã SV");
            dgrvchienpa.Columns.Add("colhoten", "Họ Tên");
            dgrvchienpa.Columns.Add("colquequan", "Quê quán");



        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            dgrvchienpa.Rows.Add(txtma.Text, txtten.Text, txtquequan.Text);
            txtma.Clear();
            txtten.Clear();
            txtquequan.Clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgrvchienpa.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgrvchienpa.SelectedRows[0];
                selectedRow.Cells["colmasv"].Value = txtma.Text;
                selectedRow.Cells["colhoten"].Value = txtten.Text;
                selectedRow.Cells["colquequan"].Value = txtquequan.Text;

                txtma.Clear();
                txtten.Clear();
                txtquequan.Clear();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgrvchienpa.SelectedRows.Count > 0)
            {
                dgrvchienpa.Rows.RemoveAt(dgrvchienpa.SelectedRows[0].Index);
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            txtma.Focus();
            if (txtma.Text == "")
            {
                errorProvider1.SetError(txtma, "Vui lòng nhập mã sinh viên để tìm kiếm.");
            }
            for (int i = 0; i < dgrvchienpa.Rows.Count; i++)
            {
                if (dgrvchienpa.Rows[i].Cells["colmasv"].Value.ToString().Equals(txtma.Text))
                {
                    MessageBox.Show($"Đã tìm thấy tại hàng {dgrvchienpa.Rows[i].Index}  ", "Thông báo");
                }
            }
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
