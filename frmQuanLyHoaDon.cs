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

namespace QuanLyNhaHang
{
    public partial class frmQuanLyHoaDon : Form
    {
        private string connectionString = "Data Source=YOUR_SERVER;Initial Catalog=YOUR_DATABASE;Integrated Security=True;";
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }
        public void LoadDuLieu()
        {
            string query = "SELECT * FROM HoaDon";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgDonHang.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        // Phương thức nạp dữ liệu vào ComboBox
        private void LoadComboBox(ComboBox cbo, string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbo.DataSource = dt;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            LoadComboBox(cboMaKhachHang, "SELECT MaKhachHang FROM KhachHang");
            LoadComboBox(cboMaNhanVien, "SELECT MaNhanVien FROM NhanVien");

        }

        // thêm sửa xóa
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO HoaDon (MaHD, NgayLap, MaKH, MaNV, TongTien) VALUES (@MaHD, @NgayLap, @MaKH, @MaNV, @TongTien)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(new SqlParameter[]
                        {
                            new SqlParameter("@MaHD", txtMaHoaDon.Text),
                            new SqlParameter("@NgayLap", dtpNgayLap.Value),
                            new SqlParameter("@MaKH", cboMaKhachHang.SelectedValue),
                            new SqlParameter("@MaNV", cboMaNhanVien.SelectedValue),
                            new SqlParameter("@TongTien", txtTongTien.Text)
                        });

                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm hóa đơn thành công!");
                        LoadDuLieu();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE HoaDon SET NgayLap = @NgayLap, MaKH = @MaKH, MaNV = @MaNV, TongTien = @TongTien WHERE MaHD = @MaHD";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(new SqlParameter[]
                        {
                            new SqlParameter("@MaHD", txtMaHoaDon.Text),
                            new SqlParameter("@NgayLap", dtpNgayLap.Value),
                            new SqlParameter("@MaKH", cboMaKhachHang.SelectedValue),
                            new SqlParameter("@MaNV", cboMaNhanVien.SelectedValue),
                            new SqlParameter("@TongTien", txtTongTien.Text)
                        });

                        command.ExecuteNonQuery();
                        MessageBox.Show("Sửa hóa đơn thành công!");
                        LoadDuLieu();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM HoaDon WHERE MaHD = @MaHD";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@MaHD", txtMaHoaDon.Text));

                        command.ExecuteNonQuery();
                        MessageBox.Show("Xóa hóa đơn thành công!");
                        LoadDuLieu();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

    }
}
