using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmMonAn : Form
    {
        public frmMonAn()
        {
            InitializeComponent();
        }
        private string connectionString = "your_connection_string_here"; // Thay thế bằng chuỗi kết nối thật của bạn
        public void LoadDuLieu()
        {
            string query = "SELECT * FROM MonAn";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgMonAn.DataSource = dt;
            }
        }

        private bool ExecuteNonQuery(string query, SqlParameter[] parameters)
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

        private void frmQuanLyMonAn_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO BanAn (TenBan, SoChoNgoi) VALUES (@TenBan, @SoChoNgoi)";
            SqlParameter[] parameters =
            {
                
            };

            if (ExecuteNonQuery(query, parameters))
            {
                MessageBox.Show("Thêm bàn ăn thành công!");
                LoadDuLieu();
            }
            else
            {
                MessageBox.Show("Thêm bàn ăn thất bại.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE BanAn SET TenBan = @TenBan, SoChoNgoi = @SoChoNgoi WHERE MaBan = @MaBan";
            SqlParameter[] parameters =
            {

            };

            if (ExecuteNonQuery(query, parameters))
            {
                MessageBox.Show("Cập nhật bàn ăn thành công!");
                LoadDuLieu();
            }
            else
            {
                MessageBox.Show("Cập nhật bàn ăn thất bại.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM BanAn WHERE MaBan = @MaBan";
            SqlParameter[] parameters =
            {
                
            };

            if (ExecuteNonQuery(query, parameters))
            {
                MessageBox.Show("Xóa bàn ăn thành công!");
                LoadDuLieu();
            }
            else
            {
                MessageBox.Show("Xóa bàn ăn thất bại.");
            }
        }
    }
}
