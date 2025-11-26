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
    public partial class BAI4 : Form
    {
        public BAI4()
        {
            InitializeComponent();
        }
        private ImageList imageListIcons = new ImageList();
        private void BAI4_Load(object sender, EventArgs e)
        {



            imageListIcons.ImageSize = new Size(24, 24); // kích thước icon
            imageListIcons.Images.Add("colma", Image.FromFile("C:\\Users\\PC ACER\\OneDrive\\Pictures\\Saved Pictures\\avt.jpg"));/////
            lstvchienpa.SmallImageList = imageListIcons;///////



            lstvchienpa.Columns.Add("colma", "Mã SV");
            lstvchienpa.Columns.Add("colhoten", "Họ Tên");
            lstvchienpa.Columns.Add("coldiachi", "Địa chỉ");
            lstvchienpa.Columns.Add("colngaysinh", "Ngày sinh");
            lstvchienpa.Columns.Add("collop", "Lớp");

            lstvchienpa.Columns[0].Width = 70;
            lstvchienpa.Columns[1].Width = 110;
            lstvchienpa.Columns[2].Width = 110;
            lstvchienpa.Columns[3].Width = 80;
            lstvchienpa.Columns[4].Width = 60;

            cbblop.Items.Add("LỚP A");
            cbblop.Items.Add("LỚP B");
        }

        private void lstvchienpa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            ListViewItem lstvitems = new ListViewItem();
            lstvitems.ImageKey = "colma";     
            lstvitems.Text = txtmasv.Text;
            lstvitems.SubItems.Add(txthoten.Text);
            lstvitems.SubItems.Add(txtdiachi.Text);
            lstvitems.SubItems.Add(dtpchienpa.Text);
            lstvitems.SubItems.Add(cbblop.Text);
            lstvchienpa.Items.Add(lstvitems);
            txtmasv.Clear();
            txthoten.Clear();
            txtdiachi.Clear();
            cbblop.SelectedIndex = -1;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (lstvchienpa.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstvchienpa.SelectedItems[0];
                selectedItem.Text = txtmasv.Text;
                selectedItem.SubItems[1].Text = txthoten.Text;
                selectedItem.SubItems[2].Text = txtdiachi.Text;
                selectedItem.SubItems[3].Text = dtpchienpa.Text;
                selectedItem.SubItems[4].Text = cbblop.Text;

                txtmasv.Clear();
                txthoten.Clear();
                txtdiachi.Clear();
                cbblop.SelectedIndex = -1;
            }
        }

        private void btnxoaitem_Click(object sender, EventArgs e)
        {
            if (lstvchienpa.SelectedItems.Count > 0)
            {
                lstvchienpa.Items.Remove(lstvchienpa.SelectedItems[0]);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
