using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuc_hanh3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

    
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?",
                "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Close();
        }

     
        private void btnInput_Click(object sender, EventArgs e)
        {
            int a;
            string num = txtInput.Text.Trim();
            if (int.TryParse(num, out a))
            {
                lsbDaySo.Items.Add(a);
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                MessageBox.Show("Không phải số nguyên! Hãy nhập lại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            }
            else
            {
                for (int i = 0; i < lsbDaySo.Items.Count; i++)
                {
                    lsbDaySo.Items[i] = (int)lsbDaySo.Items[i] + 2;
                }
            }
        }

        private void btnChanDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            }
            else
            {
                for (int i = 0; i < lsbDaySo.Items.Count; i++)
                {
                    if ((int)lsbDaySo.Items[i] % 2 == 0)
                    {
                        lsbDaySo.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnLeCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            }
            else
            {
                for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
                {
                    if ((int)lsbDaySo.Items[i] % 2 != 0)
                    {
                        lsbDaySo.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            }
            else if (lsbDaySo.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn số cần xóa!", "Thông báo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (lsbDaySo.SelectedIndex != -1)
                {
                    lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
                }
            }
        }

        // Xóa phần tử đầu tiên
        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            }
            else
            {
                lsbDaySo.Items.RemoveAt(0);
            }
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            }
            else
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
            }
        }

        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }
    }
}
