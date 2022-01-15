using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Lock_Unlock(mySave.kt);
        }

        void Lock_Unlock(bool KT)
        {
            mnuDangNhap.Enabled  = KT;
            mnDangXuat.Enabled =  mnuQuanLyKhach.Enabled = mnQuanLyPhong.Enabled = !KT;
        }


        public void HienThi(object Form)
        {
            if (this.panelLoad.Controls.Count > 0)
            {
                this.panelLoad.Controls.RemoveAt(0);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelLoad.Controls.Add(f);
            this.panelLoad.Tag = f;
            f.Show();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void thôngTinPhòngTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThi(new QuanLyPhong());
        }

        private void hiểnThịThôngTinPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThi(new QuanLyChucNangPhong());
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThi(new QuanLyKhachHang());
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.ShowDialog();

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.kt);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            mySave.kt = !mySave.kt;
            Lock_Unlock(mySave.kt);
        }
    }
}
