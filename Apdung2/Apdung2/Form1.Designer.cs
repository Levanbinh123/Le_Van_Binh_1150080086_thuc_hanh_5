using System.Windows.Forms;

namespace Apdung2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnRing;
        private System.Windows.Forms.ListView lvLog;

        private void InitializeComponent()
        {
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();
            this.lvLog = new System.Windows.Forms.ListView();
            this.SuspendLayout();

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(100, 20);
            this.txtPassword.Size = new System.Drawing.Size(250, 22);
            this.txtPassword.UseSystemPasswordChar = true;

            // Buttons số
            int x = 50, y = 60;
            for (int i = 1; i <= 9; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Size = new System.Drawing.Size(50, 40);
                btn.Location = new System.Drawing.Point(x, y);
                btn.Click += new System.EventHandler(this.btnNum_Click);
                this.Controls.Add(btn);

                x += 60;
                if (i % 3 == 0) { x = 50; y += 50; }
            }

            // btnClear
            this.btnClear.Text = "Clear";
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(250, 60);
            this.btnClear.Size = new System.Drawing.Size(80, 40);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnEnter
            this.btnEnter.Text = "Enter";
            this.btnEnter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEnter.Location = new System.Drawing.Point(250, 110);
            this.btnEnter.Size = new System.Drawing.Size(80, 40);
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);

            // btnRing
            this.btnRing.Text = "RING";
            this.btnRing.BackColor = System.Drawing.Color.Red;
            this.btnRing.Location = new System.Drawing.Point(250, 160);
            this.btnRing.Size = new System.Drawing.Size(80, 40);
            this.btnRing.Click += new System.EventHandler(this.btnRing_Click);

            // lvLog
            this.lvLog.Location = new System.Drawing.Point(20, 220);
            this.lvLog.Size = new System.Drawing.Size(400, 200);
            this.lvLog.View = View.Details;
            this.lvLog.Columns.Add("Ngày giờ", 150);
            this.lvLog.Columns.Add("Nhóm", 120);
            this.lvLog.Columns.Add("Kết quả", 100);

            // Form1
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnRing);
            this.Controls.Add(this.lvLog);
            this.Text = "Security Panel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

