using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuhanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            double thanhTien = 0;
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (chkLayCaoRang.Checked)
                    thanhTien += 50000;

                if (chkTayTrangRang.Checked)
                    thanhTien += 100000;

                if (chkHanRang.Checked)
                    thanhTien += (int)nupHanRang.Value * 100000;

                if (chkBeRang.Checked)
                    thanhTien += (int)nupBeRang.Value * 10000;

                if (chkBocRang.Checked)
                    thanhTien += (int)nupBocRang.Value * 1000000;

                txtThanhTien.Text = thanhTien.ToString("N0") + " VND";
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtTenKH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKH.Text.Trim()))
            {
                e.Cancel = true;
                txtTenKH.Focus();
                err.SetError(txtTenKH, "Tên khách hàng không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTenKH, null);
            }
        }
    }
}
