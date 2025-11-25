using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblhienthi_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtinput.Text = "";
            txthienthi.Text = "";
        }

        private void radthuong_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtHienthi_Click(object sender, EventArgs e)
        {
            if (radthuong.Checked)
            {
                this.txthienthi.Text = txtinput.Text.ToLower();
            }
            if (radhoa.Checked)
            {
                this.txthienthi.Text = txtinput.Text.ToUpper();
            }
            else
            {
                this.txthienthi.Text.ToLower();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtinput_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txthienthi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
