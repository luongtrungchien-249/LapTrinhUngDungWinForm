using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace BTH3
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {
            // Có thể thêm code khởi tạo nếu cần
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text.Trim();
            string pass = txtpass.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtuser.Focus();
                return;
            }

            try
            {
                string sql = "SELECT tendangnhap, matkhau, quyenhan FROM NhanVien " +
                           "WHERE tendangnhap = @user AND matkhau = @pass";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@user", user),
                    new SqlParameter("@pass", pass)
                };

                clsCSDL db = new clsCSDL(Program.Db.Connection.DataSource,
                    Program.Db.Connection.Database);

                using (SqlDataReader reader = db.ExecuteReader(sql, parameters))
                {
                    if (reader.Read())
                    {
                        string quyenhan = reader["quyenhan"].ToString();

                        MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        frmquanlynhanvien f = new frmquanlynhanvien();
                        f.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpass.Clear();
                        txtuser.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
