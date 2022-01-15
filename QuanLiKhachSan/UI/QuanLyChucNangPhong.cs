using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;
using System.Windows.Forms;

namespace UI
{
    public partial class QuanLyChucNangPhong : Form
    {
        BUS_PhongKhach pk = new BUS_PhongKhach();
        public QuanLyChucNangPhong()
        {
            InitializeComponent();
        }

        private void dgvDanhSachPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgvDanhSachPhongTrong.Rows.Count > 1)
            {
                DataGridViewRow row = dgvDanhSachPhongTrong.Rows[e.RowIndex];
                txtMaSua.Text = row.Cells[0].Value.ToString();
                txtTenSua.Text = row.Cells[1].Value.ToString();
                txtGiuongSua.Text = row.Cells[2].Value.ToString();
                txtGiaSua.Text = row.Cells[3].Value.ToString();
                txtTinhTrangSua.Text = row.Cells[4].Value.ToString();
            }
        }

        private void QuanLyChucNangPhong_Load(object sender, EventArgs e)
        {
            dgvDanhSachPhongTrong.DataSource = pk.HienThiPhong();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            bool check = pk.ThemPhong(txtMaPhong.Text, txtTen.Text, int.Parse(txtSoGiuong.Text), double.Parse(txtDonGia.Text), "Trống");
            if (check == true)
            {
                dgvDanhSachPhongTrong.DataSource = pk.HienThiPhong();
                MessageBox.Show("Thêm thành Công");

            }
            else
            {
                MessageBox.Show("Mã Phòng trùng");
            }





        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool check = pk.XoaPhong(txtMaCanXoa.Text);
                if(check == true)
                {
                    dgvDanhSachPhongTrong.DataSource = pk.HienThiPhong();
                    MessageBox.Show("Xóa thành công");
                }    
            }    
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = pk.SuaPhong(txtMaSua.Text, txtTenSua.Text, int.Parse(txtGiuongSua.Text), double.Parse(txtGiaSua.Text), txtTinhTrangSua.Text);
            if(check == true)
            {

                dgvDanhSachPhongTrong.DataSource = pk.HienThiPhong();
                MessageBox.Show("Sửa Thành Công");
            }
            else
            {
                MessageBox.Show("Không Thành CÔng");
            } 
                
          

        }
    }
}
