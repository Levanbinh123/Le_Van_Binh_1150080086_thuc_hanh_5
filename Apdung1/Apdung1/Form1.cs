using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apdung1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm tính Ước số chung lớn nhất (USCLN)
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Hàm tính Bội số chung nhỏ nhất (BSCNN)
        private int BSCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtA.Text.Trim());
                int b = Convert.ToInt32(txtB.Text.Trim());

                if (radUSCLN.Checked) // Nếu chọn USCLN
                {
                    txtKetQua.Text = "USCLN = " + UCLN(a, b).ToString();
                }
                else if (radBSCNN.Checked) // Nếu chọn BSCNN
                {
                    txtKetQua.Text = "BSCNN = " + BSCNN(a, b).ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn USCLN hoặc BSCNN!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?",
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
