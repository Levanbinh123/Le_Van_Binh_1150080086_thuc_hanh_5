namespace thuc_hanh3
{

    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChanDau = new System.Windows.Forms.Button();
            this.btnLeCuoi = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnXoaDaySo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            this.lblTitle.BackColor = System.Drawing.Color.Turquoise;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ứng dụng xử lý dãy số";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Location = new System.Drawing.Point(20, 60);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(65, 16);
            this.lblNhapSo.TabIndex = 1;
            this.lblNhapSo.Text = "Nhập số:";

            this.txtInput.Location = new System.Drawing.Point(100, 57);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(150, 22);
            this.txtInput.TabIndex = 2;

            this.btnInput.Location = new System.Drawing.Point(270, 55);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(80, 25);
            this.btnInput.TabIndex = 3;
            this.btnInput.Text = "Nhập số";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);

            this.lsbDaySo.FormattingEnabled = true;
            this.lsbDaySo.ItemHeight = 16;
            this.lsbDaySo.Location = new System.Drawing.Point(20, 100);
            this.lsbDaySo.Name = "lsbDaySo";
            this.lsbDaySo.Size = new System.Drawing.Size(180, 260);
            this.lsbDaySo.TabIndex = 4;

            this.groupBox1.Controls.Add(this.btnTang2);
            this.groupBox1.Controls.Add(this.btnChanDau);
            this.groupBox1.Controls.Add(this.btnLeCuoi);
            this.groupBox1.Controls.Add(this.btnXoaChon);
            this.groupBox1.Controls.Add(this.btnXoaDau);
            this.groupBox1.Controls.Add(this.btnXoaCuoi);
            this.groupBox1.Location = new System.Drawing.Point(220, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 260);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";

            this.btnTang2.Location = new System.Drawing.Point(20, 30);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(150, 30);
            this.btnTang2.TabIndex = 0;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);

            this.btnChanDau.Location = new System.Drawing.Point(20, 70);
            this.btnChanDau.Name = "btnChanDau";
            this.btnChanDau.Size = new System.Drawing.Size(150, 30);
            this.btnChanDau.TabIndex = 1;
            this.btnChanDau.Text = "Chọn số chẵn đầu";
            this.btnChanDau.UseVisualStyleBackColor = true;
            this.btnChanDau.Click += new System.EventHandler(this.btnChanDau_Click);

            this.btnLeCuoi.Location = new System.Drawing.Point(20, 110);
            this.btnLeCuoi.Name = "btnLeCuoi";
            this.btnLeCuoi.Size = new System.Drawing.Size(150, 30);
            this.btnLeCuoi.TabIndex = 2;
            this.btnLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnLeCuoi.UseVisualStyleBackColor = true;
            this.btnLeCuoi.Click += new System.EventHandler(this.btnLeCuoi_Click);

            this.btnXoaChon.Location = new System.Drawing.Point(20, 150);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(150, 30);
            this.btnXoaChon.TabIndex = 3;
            this.btnXoaChon.Text = "Xóa phần tử chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);

            this.btnXoaDau.Location = new System.Drawing.Point(20, 190);
            this.btnXoaDau.Name = "btnXoaDau";
            this.btnXoaDau.Size = new System.Drawing.Size(150, 30);
            this.btnXoaDau.TabIndex = 4;
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.UseVisualStyleBackColor = true;
            this.btnXoaDau.Click += new System.EventHandler(this.btnXoaDau_Click);

            this.btnXoaCuoi.Location = new System.Drawing.Point(20, 230);
            this.btnXoaCuoi.Name = "btnXoaCuoi";
            this.btnXoaCuoi.Size = new System.Drawing.Size(150, 30);
            this.btnXoaCuoi.TabIndex = 5;
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.UseVisualStyleBackColor = true;
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);

            this.btnXoaDaySo.BackColor = System.Drawing.Color.Gray;
            this.btnXoaDaySo.ForeColor = System.Drawing.Color.White;
            this.btnXoaDaySo.Location = new System.Drawing.Point(220, 380);
            this.btnXoaDaySo.Name = "btnXoaDaySo";
            this.btnXoaDaySo.Size = new System.Drawing.Size(120, 35);
            this.btnXoaDaySo.TabIndex = 6;
            this.btnXoaDaySo.Text = "Xóa dãy số";
            this.btnXoaDaySo.UseVisualStyleBackColor = false;
            this.btnXoaDaySo.Click += new System.EventHandler(this.btnXoaDaySo_Click);

            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(20, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Kết thúc ứng dụng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnXoaDaySo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsbDaySo);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblNhapSo);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Ứng dụng xử lý dãy số";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.ListBox lsbDaySo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnChanDau;
        private System.Windows.Forms.Button btnLeCuoi;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button btnXoaDaySo;
        private System.Windows.Forms.Button btnClose;
    } }
    