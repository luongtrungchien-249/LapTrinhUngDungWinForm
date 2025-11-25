using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baiTH1bai12
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        string chuoitam = "";
        char toantu;
        double[] toanhang = new double[2];
        double ketqua;
        int buoc = 1;
        private void NumberButtons(object sender, EventArgs e)
        {
            Button b = sender as Button; 
            if (b == null) return; 
            if (b.Text == "0" && chuoitam.Length == 0) 
                return; // không cho nhập số 0 đầu tiên
            chuoitam += b.Text; 
            txthienthi.Text = chuoitam;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
       


      
       
       
        private void Form1_Load(object sender, EventArgs e)
        {
            txthienthi.Text = 0.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            buoc = 1;
            toanhang[0] = toanhang[1] = 0.0;
            ketqua = 0.0;
            toantu = ' ';
            chuoitam = "";
            txthienthi.Text = "0";
        }

        private void btncham_Click(object sender, EventArgs e)
        {
            if (!chuoitam.Contains('.'))
            {
                chuoitam = chuoitam + "."; txthienthi.Text = chuoitam;
            }
        }

        private void btncongtru_Click_1(object sender, EventArgs e)
        {
            if (chuoitam.Contains('-'))
            {
                chuoitam = chuoitam.Replace("-", "");
            }
            else
            {
                chuoitam = "-" + chuoitam;
            }
            txthienthi.Text = chuoitam;
        }
        private void Operations(object sender, EventArgs e)
        {
            char op = ' ';
            if (chuoitam.Length == 0) return;

            toanhang[0] = double.Parse(chuoitam);
            chuoitam = "";              // reset chuỗi nhập
            txthienthi.Text = "";       // QUAN TRỌNG: xoá màn hình để nhập số 2

            toantu = op;                // lưu toán tử
            buoc = 2;
        }
        private void btnbang_Click(object sender, EventArgs e)
        {
            if (buoc != 2 || chuoitam == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!");
                return;
            }

            toanhang[1] = double.Parse(chuoitam);

            switch (toantu)
            {
                case '+':
                    ketqua = toanhang[0] + toanhang[1];
                    break;

                case '-':
                    ketqua = toanhang[0] - toanhang[1];
                    break;

                case '*':
                    ketqua = toanhang[0] * toanhang[1];
                    break;

                case '/':
                    if (toanhang[1] == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!");
                        return;
                    }
                    ketqua = toanhang[0] / toanhang[1];
                    break;
            }

            txthienthi.Text = ketqua.ToString();

            // chuẩn bị tính tiếp
            toanhang[0] = ketqua;
            buoc = 1;
            chuoitam = "";
        }
    }
}
