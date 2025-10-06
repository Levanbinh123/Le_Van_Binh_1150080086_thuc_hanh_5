namespace WinFormsApp1
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupMonAn = new System.Windows.Forms.GroupBox();
            this.btnBunBoHue = new System.Windows.Forms.Button();
            this.btnDuiGaRan = new System.Windows.Forms.Button();
            this.btnBugerBoNuong = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnCaVienChien = new System.Windows.Forms.Button();
            this.btnMyXaoHaiSan = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btn7up = new System.Windows.Forms.Button();
            this.btnKhoaiTayChien = new System.Windows.Forms.Button();
            this.btnOcRangMuoi = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnBanhMiOpLa = new System.Windows.Forms.Button();
            this.btnComChienTrung = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.labelBan = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lvMonAn = new System.Windows.Forms.ListView();
            this.groupMonAn.SuspendLayout();
            this.SuspendLayout();
      
            this.labelTitle.BackColor = System.Drawing.Color.Green;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(100, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(400, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Quán ăn nhanh Hưng Thịnh";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    
            this.groupMonAn.Controls.Add(this.btnBunBoHue);
            this.groupMonAn.Controls.Add(this.btnDuiGaRan);
            this.groupMonAn.Controls.Add(this.btnBugerBoNuong);
            this.groupMonAn.Controls.Add(this.btnCafe);
            this.groupMonAn.Controls.Add(this.btnPepsi);
            this.groupMonAn.Controls.Add(this.btnCaVienChien);
            this.groupMonAn.Controls.Add(this.btnMyXaoHaiSan);
            this.groupMonAn.Controls.Add(this.btnCam);
            this.groupMonAn.Controls.Add(this.btn7up);
            this.groupMonAn.Controls.Add(this.btnKhoaiTayChien);
            this.groupMonAn.Controls.Add(this.btnOcRangMuoi);
            this.groupMonAn.Controls.Add(this.btnLipton);
            this.groupMonAn.Controls.Add(this.btnCoca);
            this.groupMonAn.Controls.Add(this.btnBanhMiOpLa);
            this.groupMonAn.Controls.Add(this.btnComChienTrung);
            this.groupMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupMonAn.Location = new System.Drawing.Point(30, 70);
            this.groupMonAn.Name = "groupMonAn";
            this.groupMonAn.Size = new System.Drawing.Size(550, 200);
            this.groupMonAn.TabIndex = 1;
            this.groupMonAn.TabStop = false;
            this.groupMonAn.Text = "Danh sách món ăn:";
         
            int x = 20, y = 30, w = 120, h = 35, spacing = 10;
   
            this.btnComChienTrung.Location = new System.Drawing.Point(20, 30);
            this.btnComChienTrung.Size = new System.Drawing.Size(120, 35);
            this.btnComChienTrung.Text = "Cơm chiên trứng";

            this.btnBanhMiOpLa.Location = new System.Drawing.Point(150, 30);
            this.btnBanhMiOpLa.Size = new System.Drawing.Size(120, 35);
            this.btnBanhMiOpLa.Text = "Bánh mì ốp la";

            this.btnCoca.Location = new System.Drawing.Point(280, 30);
            this.btnCoca.Size = new System.Drawing.Size(120, 35);
            this.btnCoca.Text = "Coca";

            this.btnLipton.Location = new System.Drawing.Point(410, 30);
            this.btnLipton.Size = new System.Drawing.Size(120, 35);
            this.btnLipton.Text = "Lipton";

            this.btnOcRangMuoi.Location = new System.Drawing.Point(20, 70);
            this.btnOcRangMuoi.Size = new System.Drawing.Size(120, 35);
            this.btnOcRangMuoi.Text = "Ốc rang muối";

            this.btnKhoaiTayChien.Location = new System.Drawing.Point(150, 70);
            this.btnKhoaiTayChien.Size = new System.Drawing.Size(120, 35);
            this.btnKhoaiTayChien.Text = "Khoai tây chiên";

            this.btn7up.Location = new System.Drawing.Point(280, 70);
            this.btn7up.Size = new System.Drawing.Size(120, 35);
            this.btn7up.Text = "7 up";

            this.btnCam.Location = new System.Drawing.Point(410, 70);
            this.btnCam.Size = new System.Drawing.Size(120, 35);
            this.btnCam.Text = "Cam";
            this.btnMyXaoHaiSan.Location = new System.Drawing.Point(20, 110);
            this.btnMyXaoHaiSan.Size = new System.Drawing.Size(120, 35);
            this.btnMyXaoHaiSan.Text = "Mỳ xào hải sản";

            this.btnCaVienChien.Location = new System.Drawing.Point(150, 110);
            this.btnCaVienChien.Size = new System.Drawing.Size(120, 35);
            this.btnCaVienChien.Text = "Cá viên chiên";

            this.btnPepsi.Location = new System.Drawing.Point(280, 110);
            this.btnPepsi.Size = new System.Drawing.Size(120, 35);
            this.btnPepsi.Text = "Pepsi";

            this.btnCafe.Location = new System.Drawing.Point(410, 110);
            this.btnCafe.Size = new System.Drawing.Size(120, 35);
            this.btnCafe.Text = "Cafe";

            this.btnBugerBoNuong.Location = new System.Drawing.Point(20, 150);
            this.btnBugerBoNuong.Size = new System.Drawing.Size(120, 35);
            this.btnBugerBoNuong.Text = "Buger bò nướng";

            this.btnDuiGaRan.Location = new System.Drawing.Point(150, 150);
            this.btnDuiGaRan.Size = new System.Drawing.Size(120, 35);
            this.btnDuiGaRan.Text = "Đùi gà rán";

            this.btnBunBoHue.Location = new System.Drawing.Point(280, 150);
            this.btnBunBoHue.Size = new System.Drawing.Size(120, 35);
            this.btnBunBoHue.Text = "Bún bò Huế";

            this.btnXoa.Location = new System.Drawing.Point(30, 280);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
       
            this.cbBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBan.Location = new System.Drawing.Point(180, 285);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(100, 21);
            this.cbBan.TabIndex = 3;
          
            this.labelBan.AutoSize = true;
            this.labelBan.Location = new System.Drawing.Point(120, 290);
            this.labelBan.Name = "labelBan";
            this.labelBan.Size = new System.Drawing.Size(55, 13);
            this.labelBan.Text = "Chọn bàn:";
           
            this.btnOrder.Location = new System.Drawing.Point(300, 280);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 30);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
        
            this.lvMonAn.Location = new System.Drawing.Point(30, 320);
            this.lvMonAn.Name = "lvMonAn";
            this.lvMonAn.Size = new System.Drawing.Size(550, 180);
            this.lvMonAn.TabIndex = 5;
            this.lvMonAn.UseCompatibleStateImageBehavior = false;
       
            this.ClientSize = new System.Drawing.Size(620, 530);
            this.Controls.Add(this.lvMonAn);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.labelBan);
            this.Controls.Add(this.cbBan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupMonAn);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Quán ăn nhanh Hưng Thịnh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupMonAn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

 

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupMonAn;
        private System.Windows.Forms.Button btnComChienTrung;
        private System.Windows.Forms.Button btnBanhMiOpLa;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btnLipton;
        private System.Windows.Forms.Button btnOcRangMuoi;
        private System.Windows.Forms.Button btnKhoaiTayChien;
        private System.Windows.Forms.Button btn7up;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnMyXaoHaiSan;
        private System.Windows.Forms.Button btnCaVienChien;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btnBugerBoNuong;
        private System.Windows.Forms.Button btnDuiGaRan;
        private System.Windows.Forms.Button btnBunBoHue;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbBan;
        private System.Windows.Forms.Label labelBan;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListView lvMonAn;
    }
}
