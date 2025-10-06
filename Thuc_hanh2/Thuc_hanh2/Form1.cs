using System;
using System.Windows.Forms;

namespace Thuc_hanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lvSinhVien.View = View.Details;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;

            lvSinhVien.Columns.Add("Họ tên", 150);
            lvSinhVien.Columns.Add("Ngày sinh", 100);
            lvSinhVien.Columns.Add("Lớp", 100);
            lvSinhVien.Columns.Add("Địa chỉ", 150);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = new ListViewItem(txtHoTen.Text);
            item.SubItems.Add(dtNgaySinh.Value.ToShortDateString());
            item.SubItems.Add(txtLop.Text);
            item.SubItems.Add(txtDiaChi.Text);

            lvSinhVien.Items.Add(item);

          
            txtHoTen.Clear();
            txtLop.Clear();
            txtDiaChi.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = lvSinhVien.SelectedItems[0];
            item.SubItems[0].Text = txtHoTen.Text;
            item.SubItems[1].Text = dtNgaySinh.Value.ToShortDateString();
            item.SubItems[2].Text = txtLop.Text;
            item.SubItems[3].Text = txtDiaChi.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lvSinhVien.SelectedItems[0];
                txtHoTen.Text = item.SubItems[0].Text;
                dtNgaySinh.Text = item.SubItems[1].Text;
                txtLop.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
            }
        }
    }
}
