using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmBanAn : Form
    {
        private string connectionString = "your_connection_string_here"; // Thay thế bằng chuỗi kết nối thật của bạn

        public frmBanAn()
        {
            InitializeComponent();
        }

        public DataTable GetDataTable(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    return null;
                }
            }
        }

        public bool ExcuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return false;
                }
            }
        }

        public void LoadDuLieu()
        {
            string query = "SELECT * FROM BanAn";
            DataTable dt = GetDataTable(query);
            if (dt != null)
            {
                dgBanAn.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO BanAn (TenBan, TrangThai) VALUES (@TenBan, @TrangThai)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenBan", txtTenBan.Text),
                new SqlParameter("@TrangThai", chkTrangThai.Checked)
            };
            if (ExcuteNonQuery(query, parameters))
            {
                MessageBox.Show("Thêm thành công!");
                LoadDuLieu();
            }
            else
            {
                MessageBox.Show("Lỗi, không thêm được");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE BanAn SET TenBan = @TenBan, TrangThai = @TrangThai WHERE MaBanAn = @MaBanAn";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenBan", txtTenBan.Text),
                new SqlParameter("@TrangThai", chkTrangThai.Checked),
                new SqlParameter("@MaBanAn", txtMaBanAn.Text)
            };
            if (ExcuteNonQuery(query, parameters))
            {
                MessageBox.Show("Sửa thành công");
                LoadDuLieu();
            }
            else
            {
                MessageBox.Show("Không thể sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM BanAn WHERE MaBanAn = @MaBanAn";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaBanAn", txtMaBanAn.Text)
            };
            if (ExcuteNonQuery(query, parameters))
            {
                MessageBox.Show("Xóa thành công");
                LoadDuLieu();
            }
            else
            {
                MessageBox.Show("Không thể xóa!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BanAn WHERE TenBan = @TenBan";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenBan", txtTenBan.Text)
            };
            DataTable dt = GetDataTable(query, parameters);
            if (dt != null && dt.Rows.Count > 0)
            {
                dgBanAn.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy bàn ăn!");
            }
        }
    }
}