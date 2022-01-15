using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }


        public void LoadForm(object Form)
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
            LoadForm(new QuanLyPhong());
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

    }
}
