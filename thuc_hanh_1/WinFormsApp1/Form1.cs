using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public class MonAn
        {
            public string TenMon { get; set; }
            public int SoLuong { get; set; }
        }

        private List<MonAn> danhSachMon = new List<MonAn>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            cbBan.Items.AddRange(new string[] { "Bàn 1", "Bàn 2", "Bàn 3", "Bàn 4", "Bàn 5" });
            cbBan.SelectedIndex = 0;

            lvMonAn.View = View.Details;
            lvMonAn.Columns.Add("Tên món", 200);
            lvMonAn.Columns.Add("Số lượng", 100);
            lvMonAn.FullRowSelect = true;
            lvMonAn.GridLines = true;

            foreach (Control ctl in groupMonAn.Controls)
            {
                if (ctl is Button btn)
                {
                    btn.Click += BtnMon_Click;
                }
            }
        }

    
        private void BtnMon_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string tenMon = btn.Text;

            var mon = danhSachMon.FirstOrDefault(m => m.TenMon == tenMon);
            if (mon != null)
            {
                mon.SoLuong++;
            }
            else
            {
                danhSachMon.Add(new MonAn { TenMon = tenMon, SoLuong = 1 });
            }

            CapNhatListView();
        }

        private void CapNhatListView()
        {
            lvMonAn.Items.Clear();
            foreach (var mon in danhSachMon)
            {
                var item = new ListViewItem(mon.TenMon);
                item.SubItems.Add(mon.SoLuong.ToString());
                lvMonAn.Items.Add(item);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            danhSachMon.Clear();
            lvMonAn.Items.Clear();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cbBan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi order!");
                return;
            }

            if (danhSachMon.Count == 0)
            {
                MessageBox.Show("Chưa có món nào được chọn!");
                return;
            }

            string tenBan = cbBan.SelectedItem.ToString();
            string filePath = "order.txt";

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"Bàn: {tenBan} - Thời gian: {DateTime.Now}");
                foreach (var mon in danhSachMon)
                    sw.WriteLine($"{mon.TenMon}\t{mon.SoLuong}");
            }

            MessageBox.Show("Đơn hàng đã được gửi xuống bếp (đã lưu file order.txt)");
        }
    }
}
