using System;
using System.Windows.Forms;

namespace baiTH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtlogin.Text;
            thongbao += "\n\rMật khẩu là: ";
            thongbao += this.txtpass.Text;
            if (this.chkghinho.Checked == true)
            {
                { thongbao += "\n\rBạn có ghi nhớ."; }
                MessageBox.Show(thongbao, "Thông báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtlogin.Text = "";
            txtpass.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
