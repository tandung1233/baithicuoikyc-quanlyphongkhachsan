using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace UI
{
    public partial class DangNhap : Form
    {
        BUS_TaiKhoan bs = new BUS_TaiKhoan();
        public DangNhap()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu Hoặc Tài Khoản");
            } else
            {
                DataTable x = bs.NguoiDung();
                int size = x.Rows.Count;

                bool check = false;
                for (int i = 0; i < size; i++)
                {
                    if(txtTaiKhoan.Text == x.Rows[i]["TaiKhoan"].ToString() && txtMatKhau.Text == x.Rows[i]["MatKhau"].ToString())
                    {
                        check = true;
                        break;
                    }    
                }    

                if(check == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    mySave.kt = !mySave.kt;
                    Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai");

                } 
                    
            }

        }
    }
}
