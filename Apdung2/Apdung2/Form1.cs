using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apdung2
{

    public partial class Form1 : Form
    {
        // Danh sách mật khẩu cho từng nhóm
        private readonly Dictionary<string, List<string>> passwords = new Dictionary<string, List<string>>()
        {
            {"Phát triển công nghệ", new List<string> {"1496", "2673"}},
            {"Nghiên cứu viên", new List<string> {"7462"}},
            {"Thiết kế mô hình", new List<string> {"8884", "3842", "3383"}}
        };

        public Form1()
        {
            InitializeComponent();
        }

        // Xử lý khi bấm phím số
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPassword.Text += btn.Text;
        }

        // Xóa password
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        // Kiểm tra mật khẩu
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string pwd = txtPassword.Text.Trim();
            string nhom = "Không có";
            string ketqua = "Từ chối!";

            foreach (var kvp in passwords)
            {
                if (kvp.Value.Contains(pwd))
                {
                    nhom = kvp.Key;
                    ketqua = "Chấp nhận!";
                    break;
                }
            }

            // Ghi vào log
            ListViewItem item = new ListViewItem(DateTime.Now.ToString());
            item.SubItems.Add(nhom);
            item.SubItems.Add(ketqua);
            lvLog.Items.Add(item);

            txtPassword.Clear();
        }

        // Báo động
        private void btnRing_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Báo độnd", "RING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
