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
    public partial class frmQuanLyDonHang : Form
    {
        private string connectionString = "Data Source=YOUR_SERVER;Initial Catalog=YOUR_DATABASE;Integrated Security=True;";
        public frmQuanLyDonHang()
        {
            InitializeComponent();
        }
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
        public void LoadDuLieu()
        {
            string query = "SELECT * FROM DonHang";
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
        private void frmQuanLyDonHang_Load(object sender, EventArgs e)
        {
            LoadComboBox(cboMaKhachHang, "SELECT MaKH FROM KhachHang");
            LoadComboBox(cboMaNhanVien, "SELECT MaNV FROM NhanVien");
            LoadComboBox(cboMaBanAn, "SELECT MaBan FROM BanAn");
            LoadDuLieu();
        }
        // Thêm sửa xóa
        private void btnTHEM_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO DonHang (MaDon, MaKH, MaNV, MaBan, TongTien) VALUES (@MaDon, @MaKH, @MaNV, @MaBan, @TongTien)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddRange(new SqlParameter[]
                        {
                    new SqlParameter("@MaDon", txtMaDonHang.Text),
                    new SqlParameter("@MaKH", cboMaKhachHang.SelectedValue),
                    new SqlParameter("@MaNV", cboMaNhanVien.SelectedValue),
                    new SqlParameter("@MaBan", cboMaBanAn.SelectedValue),
                    new SqlParameter("@TongTien", txtTongTien.Text)
                        });

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm đơn hàng thành công!");
                        LoadDuLieu(); // Cập nhật danh sách đơn hàng
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
            string query = "UPDATE DonHang SET MaKH = @MaKH, MaNV = @MaNV, MaBan = @MaBan, TongTien = @TongTien WHERE MaDon = @MaDon";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddRange(new SqlParameter[]
                        {
                    new SqlParameter("@MaKH", cboMaKhachHang.SelectedValue),
                    new SqlParameter("@MaNV", cboMaNhanVien.SelectedValue),
                    new SqlParameter("@MaBan", cboMaBanAn.SelectedValue),
                    new SqlParameter("@TongTien", txtTongTien.Text),
                    new SqlParameter("@MaDon", txtMaDonHang.Text)
                        });

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật đơn hàng thành công!");
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
            string query = "DELETE FROM DonHang WHERE MaDon = @MaDon";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddRange(new SqlParameter[]
                        {
                    new SqlParameter("@MaDon", txtMaDonHang.Text)
                        });

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa đơn hàng thành công!");
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
