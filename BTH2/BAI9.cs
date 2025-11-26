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
    public partial class BAI9 : Form
    {
        public BAI9()
        {
            InitializeComponent();
        }
        private void creatcolumn()
        {
            lstvchienpa.Columns.Add("colhoten", "Họ Tên");
            lstvchienpa.Columns.Add("colkhuvuc", "Khu vực");
            lstvchienpa.Columns.Add("coldinhmuc", "Định mức");
            lstvchienpa.Columns.Add("coltieuthu", "Tiêu thụ");
            lstvchienpa.Columns.Add("colthanhtien", "Thành Tiền");

            lstvchienpa.Columns[0].Width = 100;
            lstvchienpa.Columns[1].Width = 100;
            lstvchienpa.Columns[2].Width = 100;
            lstvchienpa.Columns[3].Width = 100;
            lstvchienpa.Columns[4].Width = 150;


            //Tạo giá trị cho ComboBox
            cbbkhuvuc.Items.Add("Khu Vực 1");
            cbbkhuvuc.Items.Add("Khu Vực 2");
            cbbkhuvuc.Items.Add("Khu Vực 3");


            
        }
        private void BAI9_Load(object sender, EventArgs e)
        {
            creatcolumn();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstvchienpa.Items.Count; i++)
            {
                if (lstvchienpa.Items[i].Selected)
                {
                    lstvchienpa.Items.RemoveAt(i);
                    i--; // Giảm chỉ số để không bỏ qua mục tiếp theo sau khi xóa
                }
            }
            tinhtong();
        }

        private void txtnhapmoi_Click(object sender, EventArgs e)
        {
            
            lstvchienpa.Focus();
            ListViewItem item = new ListViewItem();
            if (txthoten.Text == "" || cbbkhuvuc.Text == "" ||  txtdinhmuc.Text =="" || txttieuthu.Text == "" || txtthanhtien.Text == "")
            {
                errorProvider1.SetError(txthoten, "Vui lòng nhập đầy đủ thông tin!");
                errorProvider1.SetError(cbbkhuvuc, "Vui lòng nhập đầy đủ thông tin!");
                errorProvider1.SetError(txtdinhmuc, "Vui lòng nhập đầy đủ thông tin!");
                errorProvider1.SetError(txttieuthu, "Vui lòng nhập đầy đủ thông tin!");
                errorProvider1.SetError(txtthanhtien, "Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            item.Text = txthoten.Text;
            item.SubItems.Add(cbbkhuvuc.Text);
            item.SubItems.Add(txtdinhmuc.Text);
            item.SubItems.Add(txttieuthu.Text);
            item.SubItems.Add(txtthanhtien.Text);
            lstvchienpa.Items.Add(item);


            txthoten.Clear();
            cbbkhuvuc.SelectedIndex = -1;
            txtdinhmuc.Clear();
            txttieuthu.Clear();
            txtthanhtien.Clear();

            tinhtong();
        }

        private void tinhtong()
        {
            int tong = 0;
            for (int i = 0; i < lstvchienpa.Items.Count; i++)
            {
                tong += int.Parse(lstvchienpa.Items[i].SubItems[4].Text);
            }

            txttongtien.Text = tong.ToString();
        }

        private void cbbkhuvuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tạo thiết lập giá trị Định mức khi chọn ComboBox

            if (cbbkhuvuc.SelectedIndex == 0)
            {
                txtdinhmuc.Text = "50";
            }
            else if (cbbkhuvuc.SelectedIndex == 1)
            {
                txtdinhmuc.Text = "100";
            }
            else
            {
                txtdinhmuc.Text = "150";
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            if (txthoten.Text == "" || cbbkhuvuc.Text == "" || txtdinhmuc.Text == "" || txttieuthu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int thanhtien;
            if(int.Parse(txtdinhmuc.Text) > int.Parse(txttieuthu.Text))
            {
                thanhtien = int.Parse(txttieuthu.Text) * 500;
                txtthanhtien.Text = thanhtien.ToString();
            }
            else
            {
                thanhtien = int.Parse(txttieuthu.Text) * 1000;
                txtthanhtien.Text = thanhtien.ToString();
            }

        }

        



        //private void lstvchienpa_ClientSizeChanged(object sender, EventArgs e)
        //{
        //    tinhtong();
        //}
    }
}
