namespace Thuhanh2
{
        partial class Form1
        {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Label lblTenKH;
            private System.Windows.Forms.TextBox txtTenKH;
            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.CheckBox chkLayCaoRang;
            private System.Windows.Forms.CheckBox chkTayTrangRang;
            private System.Windows.Forms.CheckBox chkHanRang;
            private System.Windows.Forms.NumericUpDown nupHanRang;
            private System.Windows.Forms.CheckBox chkBeRang;
            private System.Windows.Forms.NumericUpDown nupBeRang;
            private System.Windows.Forms.CheckBox chkBocRang;
            private System.Windows.Forms.NumericUpDown nupBocRang;
            private System.Windows.Forms.Label lblThanhTien;
            private System.Windows.Forms.TextBox txtThanhTien;
            private System.Windows.Forms.Button btnTinhTien;
            private System.Windows.Forms.Button btnThoat;
            private System.Windows.Forms.ErrorProvider err;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
                this.components = new System.ComponentModel.Container();
                this.lblTitle = new System.Windows.Forms.Label();
                this.lblTenKH = new System.Windows.Forms.Label();
                this.txtTenKH = new System.Windows.Forms.TextBox();
                this.groupBox1 = new System.Windows.Forms.GroupBox();
                this.chkLayCaoRang = new System.Windows.Forms.CheckBox();
                this.chkTayTrangRang = new System.Windows.Forms.CheckBox();
                this.chkHanRang = new System.Windows.Forms.CheckBox();
                this.nupHanRang = new System.Windows.Forms.NumericUpDown();
                this.chkBeRang = new System.Windows.Forms.CheckBox();
                this.nupBeRang = new System.Windows.Forms.NumericUpDown();
                this.chkBocRang = new System.Windows.Forms.CheckBox();
                this.nupBocRang = new System.Windows.Forms.NumericUpDown();
                this.lblThanhTien = new System.Windows.Forms.Label();
                this.txtThanhTien = new System.Windows.Forms.TextBox();
                this.btnTinhTien = new System.Windows.Forms.Button();
                this.btnThoat = new System.Windows.Forms.Button();
                this.err = new System.Windows.Forms.ErrorProvider(this.components);

                this.groupBox1.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.nupHanRang)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.nupBeRang)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.nupBocRang)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
                this.SuspendLayout();

                this.lblTitle.BackColor = System.Drawing.Color.Green;
                this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
                this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
                this.lblTitle.ForeColor = System.Drawing.Color.White;
                this.lblTitle.Location = new System.Drawing.Point(0, 0);
                this.lblTitle.Name = "lblTitle";
                this.lblTitle.Size = new System.Drawing.Size(600, 50);
                this.lblTitle.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
                this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.lblTenKH.AutoSize = true;
                this.lblTenKH.Location = new System.Drawing.Point(20, 70);
                this.lblTenKH.Text = "Tên khách hàng:";
                this.txtTenKH.Location = new System.Drawing.Point(140, 67);
                this.txtTenKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenKH_Validating);
                this.groupBox1.Controls.Add(this.chkLayCaoRang);
                this.groupBox1.Controls.Add(this.chkTayTrangRang);
                this.groupBox1.Controls.Add(this.chkHanRang);
                this.groupBox1.Controls.Add(this.nupHanRang);
                this.groupBox1.Controls.Add(this.chkBeRang);
                this.groupBox1.Controls.Add(this.nupBeRang);
                this.groupBox1.Controls.Add(this.chkBocRang);
                this.groupBox1.Controls.Add(this.nupBocRang);
                this.groupBox1.Location = new System.Drawing.Point(20, 100);
                this.groupBox1.Size = new System.Drawing.Size(550, 150);
                this.groupBox1.Text = "Dịch vụ tại phòng khám";

                this.chkLayCaoRang.AutoSize = true;
                this.chkLayCaoRang.Location = new System.Drawing.Point(20, 25);
                this.chkLayCaoRang.Text = "Lấy cao răng - 50.000đ/2 hàm";
                this.chkTayTrangRang.AutoSize = true;
                this.chkTayTrangRang.Location = new System.Drawing.Point(20, 50);
                this.chkTayTrangRang.Text = "Tẩy trắng răng - 100.000đ/2 hàm";

                this.chkHanRang.AutoSize = true;
                this.chkHanRang.Location = new System.Drawing.Point(20, 75);
                this.chkHanRang.Text = "Hàn răng - 100.000đ/1 răng";

                this.nupHanRang.Location = new System.Drawing.Point(300, 73);
                this.nupHanRang.Minimum = 1;
                this.nupHanRang.Maximum = 32;
                this.nupHanRang.Value = 1;

                this.chkBeRang.AutoSize = true;
                this.chkBeRang.Location = new System.Drawing.Point(20, 100);
                this.chkBeRang.Text = "Bẻ răng - 10.000đ/1 răng";

                this.nupBeRang.Location = new System.Drawing.Point(300, 98);
                this.nupBeRang.Minimum = 1;
                this.nupBeRang.Maximum = 32;
                this.nupBeRang.Value = 1;
                this.chkBocRang.AutoSize = true;
                this.chkBocRang.Location = new System.Drawing.Point(20, 125);
                this.chkBocRang.Text = "Bọc răng - 1.000.000đ/1 răng";

                this.nupBocRang.Location = new System.Drawing.Point(300, 123);
                this.nupBocRang.Minimum = 1;
                this.nupBocRang.Maximum = 32;
                this.nupBocRang.Value = 1;

                this.lblThanhTien.AutoSize = true;
                this.lblThanhTien.Location = new System.Drawing.Point(20, 270);
                this.lblThanhTien.Text = "Thành tiền:";

      
                this.txtThanhTien.Location = new System.Drawing.Point(140, 267);
                this.txtThanhTien.ReadOnly = true;

           
                this.btnTinhTien.Location = new System.Drawing.Point(140, 310);
                this.btnTinhTien.Text = "Tính tiền";
                this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);

                this.btnThoat.Location = new System.Drawing.Point(250, 310);
                this.btnThoat.Text = "Thoát";
                this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

                this.err.ContainerControl = this;

                // Form1
                this.ClientSize = new System.Drawing.Size(600, 360);
                this.Controls.Add(this.lblTitle);
                this.Controls.Add(this.lblTenKH);
                this.Controls.Add(this.txtTenKH);
                this.Controls.Add(this.groupBox1);
                this.Controls.Add(this.lblThanhTien);
                this.Controls.Add(this.txtThanhTien);
                this.Controls.Add(this.btnTinhTien);
                this.Controls.Add(this.btnThoat);
                this.Name = "Form1";
                this.Text = "Phòng khám nha khoa Hải Âu";

                this.groupBox1.ResumeLayout(false);
                this.groupBox1.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.nupHanRang)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.nupBeRang)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.nupBocRang)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }
    }

