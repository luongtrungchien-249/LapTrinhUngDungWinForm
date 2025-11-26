using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BTH2.BAI2;

namespace BTH2
{
    public partial class BAI2 : Form
    {
        public BAI2()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if ( result == DialogResult.Yes)
            //{
            //    Close();
            //}
        }



        public class FlagManager
        {
            private Dictionary<string, PictureBox> flags;

            public FlagManager(Dictionary<string, PictureBox> flagControls)
            {
                flags = flagControls;
            }

            // Ẩn tất cả cờ
            private void HideAll()
            {
                foreach (var item in flags.Values)
                    item.Visible = false;
            }

            // Hiển thị 1 cờ theo key
            public void ShowFlag(string name)
            {
                HideAll();
                if (flags.ContainsKey(name))
                    flags[name].Visible = true;
            }
        }





        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //if (raditaly.Checked == true)
            //{
            //    ptbitaly.Visible = true;
            //    ptbusa.Visible = false;
            //    ptbvn.Visible = false;
            //    ptbphilip.Visible = false;
            //}
            if (raditaly.Checked)
                flagManager.ShowFlag("italy");
        }

        private void radvn_CheckedChanged(object sender, EventArgs e)
        {
            //if (radvn.Checked == true)
            //{
            //    ptbvn.Visible = true;
            //    ptbusa.Visible = false;
            //    ptbitaly.Visible = false;
            //    ptbphilip.Visible = false;
            //}
            if (radvn.Checked)
                flagManager.ShowFlag("vn");
        }

        private void ptbvn_Click(object sender, EventArgs e)
        {

        }
        private FlagManager flagManager;

        private void BAI2_Load(object sender, EventArgs e)
        {


            //ptbvn.Visible = false;
            //ptbusa.Visible = false;
            //ptbitaly.Visible = false;
            //ptbphilip.Visible = false;
            flagManager = new FlagManager(new Dictionary<string, PictureBox>
            {
                 { "vn", ptbvn },
                  { "usa", ptbusa },
                 { "italy", ptbitaly },
                  { "philip", ptbphilip }
            });
        }

        private void radusa_CheckedChanged(object sender, EventArgs e)
        {
            //if (radusa.Checked == true)
            //{
            //    ptbusa.Visible = true;
            //    ptbvn.Visible = false;
            //    ptbitaly.Visible = false;
            //    ptbphilip.Visible = false;
            //}
            if (radusa.Checked)
                flagManager.ShowFlag("usa");
        }

        private void radphilipine_CheckedChanged(object sender, EventArgs e)
        {
            //if (radphilipine.Checked == true)
            //{
            //    ptbphilip.Visible = true;
            //    ptbusa.Visible = false;
            //    ptbvn.Visible = false;
            //    ptbitaly.Visible = false;
            //}
            if (radphilipine.Checked)
                flagManager.ShowFlag("philip");
        }
    }
}
