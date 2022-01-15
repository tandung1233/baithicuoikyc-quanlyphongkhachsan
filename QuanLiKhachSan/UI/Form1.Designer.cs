
namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLyPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịThôngTinPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhòngTrốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyKhach = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHeThong,
            this.mnQuanLyPhong,
            this.mnuQuanLyKhach});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1466, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnHeThong
            // 
            this.mnHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnDangXuat,
            this.mnuThoat});
            this.mnHeThong.Name = "mnHeThong";
            this.mnHeThong.Size = new System.Drawing.Size(88, 24);
            this.mnHeThong.Text = "Hệ Thống";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(224, 26);
            this.mnuDangNhap.Text = "Đăng Nhập";
            this.mnuDangNhap.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(224, 26);
            this.mnDangXuat.Text = "Đăng Xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(224, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnQuanLyPhong
            // 
            this.mnQuanLyPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiểnThịThôngTinPhòngToolStripMenuItem,
            this.thôngTinPhòngTrốngToolStripMenuItem});
            this.mnQuanLyPhong.Name = "mnQuanLyPhong";
            this.mnQuanLyPhong.Size = new System.Drawing.Size(121, 24);
            this.mnQuanLyPhong.Text = "Quản Lý Phòng";
            this.mnQuanLyPhong.Click += new System.EventHandler(this.quảnLýPhòngToolStripMenuItem_Click);
            // 
            // hiểnThịThôngTinPhòngToolStripMenuItem
            // 
            this.hiểnThịThôngTinPhòngToolStripMenuItem.Name = "hiểnThịThôngTinPhòngToolStripMenuItem";
            this.hiểnThịThôngTinPhòngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hiểnThịThôngTinPhòngToolStripMenuItem.Text = "Quản Lý Phòng";
            this.hiểnThịThôngTinPhòngToolStripMenuItem.Click += new System.EventHandler(this.hiểnThịThôngTinPhòngToolStripMenuItem_Click);
            // 
            // thôngTinPhòngTrốngToolStripMenuItem
            // 
            this.thôngTinPhòngTrốngToolStripMenuItem.Name = "thôngTinPhòngTrốngToolStripMenuItem";
            this.thôngTinPhòngTrốngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinPhòngTrốngToolStripMenuItem.Text = "Tìm Và Đặt Phòng";
            this.thôngTinPhòngTrốngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinPhòngTrốngToolStripMenuItem_Click);
            // 
            // mnuQuanLyKhach
            // 
            this.mnuQuanLyKhach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchKháchHàngToolStripMenuItem});
            this.mnuQuanLyKhach.Name = "mnuQuanLyKhach";
            this.mnuQuanLyKhach.Size = new System.Drawing.Size(159, 24);
            this.mnuQuanLyKhach.Text = "Quản Lý Khách Hàng";
            // 
            // danhSáchKháchHàngToolStripMenuItem
            // 
            this.danhSáchKháchHàngToolStripMenuItem.Name = "danhSáchKháchHàngToolStripMenuItem";
            this.danhSáchKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.danhSáchKháchHàngToolStripMenuItem.Text = "Thông Tin Khách Đặt Phòng";
            this.danhSáchKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.danhSáchKháchHàngToolStripMenuItem_Click);
            // 
            // panelLoad
            // 
            this.panelLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLoad.Location = new System.Drawing.Point(0, 35);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(1466, 688);
            this.panelLoad.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 723);
            this.Controls.Add(this.panelLoad);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnQuanLyPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyKhach;
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.ToolStripMenuItem hiểnThịThôngTinPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinPhòngTrốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchKháchHàngToolStripMenuItem;
    }
}

