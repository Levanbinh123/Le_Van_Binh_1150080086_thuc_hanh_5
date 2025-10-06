using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace thuc
{
    public partial class Form1 : Form
    {
        string connStr = "server=localhost;user=spring;password=spring;database=qlsinhvien;";

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM sinhvien";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "INSERT INTO sinhvien (HoTen, NgaySinh, Lop, DiaChi) VALUES (@HoTen, @NgaySinh, @Lop, @DiaChi)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateNgaySinh.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Lop", txtLop.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Thêm sinh viên thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }

            int id = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["id"].Value);
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "UPDATE sinhvien SET HoTen=@HoTen, NgaySinh=@NgaySinh, Lop=@Lop, DiaChi=@DiaChi WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateNgaySinh.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Lop", txtLop.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            int id = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["id"].Value);
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string sql = "DELETE FROM sinhvien WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtHoTen.Text = dgvSinhVien.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                txtLop.Text = dgvSinhVien.Rows[e.RowIndex].Cells["Lop"].Value.ToString();
                txtDiaChi.Text = dgvSinhVien.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                dateNgaySinh.Value = Convert.ToDateTime(dgvSinhVien.Rows[e.RowIndex].Cells["NgaySinh"].Value);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
