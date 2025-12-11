using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH3
{
    public partial class frmquanlynhanvien : Form
    {


        private clsCSDL db;

        public frmquanlynhanvien()
        {
            InitializeComponent();
            db = new clsCSDL(Program.Db.Connection.DataSource,
                           Program.Db.Connection.Database);
        }

        private void createcolumn()
        {
            dgrvbaith3.Columns.Add("colmanv", "Mã Nhân Viên");
            dgrvbaith3.Columns.Add("coltennv", "Tên Nhân viên");
            dgrvbaith3.Columns.Add("coldiachi", "Địa chỉ");
            dgrvbaith3.Columns.Add("coltendangnhap", "Tên đăng nhập");
            dgrvbaith3.Columns.Add("colquyenhan", "Quyền hạn");

            dgrvbaith3.Columns[0].Width = 100;
            dgrvbaith3.Columns[1].Width = 150;
            dgrvbaith3.Columns[2].Width = 200;
            dgrvbaith3.Columns[3].Width = 120;
            dgrvbaith3.Columns[4].Width = 80;
        }

        private void dgrvbaith3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgrvbaith3.Rows[e.RowIndex];
                txtmanv.Text = row.Cells["colmanv"].Value?.ToString() ?? "";
                txttennv.Text = row.Cells["coltennv"].Value?.ToString() ?? "";
                txtdiachi.Text = row.Cells["coldiachi"].Value?.ToString() ?? "";
                txtuser.Text = row.Cells["coltendangnhap"].Value?.ToString() ?? "";
                cboquyen.Text = row.Cells["colquyenhan"].Value?.ToString() ?? "";
            }
        }

        private void LoadData()
        {
            try
            {
                dgrvbaith3.Rows.Clear();

                string sql = "SELECT manhanvien, hoten, diachi, tendangnhap, quyenhan FROM NhanVien";

                using (SqlDataReader dr = db.ExecuteReader(sql))
                {
                    while (dr.Read())
                    {
                        dgrvbaith3.Rows.Add(
                            dr["manhanvien"].ToString(),
                            dr["hoten"].ToString(),
                            dr["diachi"].ToString(),
                            dr["tendangnhap"].ToString(),
                            dr["quyenhan"].ToString()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmquanlynhanvien_Load(object sender, EventArgs e)
        {
            dgrvbaith3.Rows.Clear();
            createcolumn();
            LoadData();

            cboquyen.Items.Clear();
            cboquyen.Items.Add("admin");
            cboquyen.Items.Add("user");
            cboquyen.SelectedIndex = 1;
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtmanv.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txttennv.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtdiachi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtuser.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtuser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cboquyen.Text))
            {
                MessageBox.Show("Vui lòng chọn quyền hạn!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboquyen.Focus();
                return;
            }

            try
            {
                string sql = @"INSERT INTO NhanVien (manhanvien, hoten, diachi, tendangnhap, quyenhan) 
                             VALUES (@manv, @tennv, @diachi, @user, @quyen)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@manv", txtmanv.Text.Trim()),
                    new SqlParameter("@tennv", txttennv.Text.Trim()),
                    new SqlParameter("@diachi", txtdiachi.Text.Trim()),
                    new SqlParameter("@user", txtuser.Text.Trim()),
                    new SqlParameter("@quyen", cboquyen.Text.Trim())
                };

                int result = db.ExecuteNonQuery(sql, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                    LoadData();
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    MessageBox.Show("Mã nhân viên hoặc tên đăng nhập đã tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi: " + sqlEx.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txtmanv.Clear();
            txttennv.Clear();
            txtdiachi.Clear();
            txtuser.Clear();
            cboquyen.SelectedIndex = 1;
            txtmanv.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn nhân viên chưa
            if (string.IsNullOrWhiteSpace(txtmanv.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txttennv.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtdiachi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtuser.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtuser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cboquyen.Text))
            {
                MessageBox.Show("Vui lòng chọn quyền hạn!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboquyen.Focus();
                return;
            }

            // Xác nhận trước khi sửa
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn cập nhật thông tin nhân viên '{txtmanv.Text}'?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                string sql = @"UPDATE NhanVien 
                             SET hoten = @tennv, 
                                 diachi = @diachi, 
                                 tendangnhap = @user, 
                                 quyenhan = @quyen 
                             WHERE manhanvien = @manv";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@manv", txtmanv.Text.Trim()),
                    new SqlParameter("@tennv", txttennv.Text.Trim()),
                    new SqlParameter("@diachi", txtdiachi.Text.Trim()),
                    new SqlParameter("@user", txtuser.Text.Trim()),
                    new SqlParameter("@quyen", cboquyen.Text.Trim())
                };

                int rowsAffected = db.ExecuteNonQuery(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên cần cập nhật!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật: " + sqlEx.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã chọn nhân viên chưa
            if (string.IsNullOrWhiteSpace(txtmanv.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận trước khi xóa
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa nhân viên '{txtmanv.Text} - {txttennv.Text}'?\n\nHành động này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            try
            {
                string sql = "DELETE FROM NhanVien WHERE manhanvien = @manv";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@manv", txtmanv.Text.Trim())
                };

                int rowsAffected = db.ExecuteNonQuery(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên cần xóa!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547)
                {
                    MessageBox.Show("Không thể xóa nhân viên này vì có dữ liệu liên quan!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi xóa: " + sqlEx.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

