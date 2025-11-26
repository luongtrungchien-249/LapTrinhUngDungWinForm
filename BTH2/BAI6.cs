using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTH2
{
    public partial class BAI6 : Form
    {
        public BAI6()
        {
            InitializeComponent();
        }
        private void CreatNode()
        {

        }
        

        private void BAI6_Load(object sender, EventArgs e)
        {
            for (int i = 65; i <= 90; i++) // Duyệt qua các chữ cái
            {
                string kt = ((char)i).ToString(); // chuyển từ số về ký tự và sang xâu
                trvchienpa.Nodes.Add(kt, kt); // Thêm node vào Tree
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string key = txtfirstname.Text[0].ToString(); // Lấy mã ASCII của ký tự đầu tiên
            if (trvchienpa.Nodes.ContainsKey(key)) // Kiểm tra xem có node cha không
            {
                trvchienpa.Nodes[key].Nodes.Add(txtfirstname.Text + txtlastname.Text); // Thêm node con
            }
            else
            {
                MessageBox.Show("Chữ cái đầu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
