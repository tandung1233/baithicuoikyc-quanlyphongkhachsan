using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace UI
{
    public partial class QuanLyPhong : Form
    {
        BUS_PhongKhach pk = new BUS_PhongKhach();
        BUS_KhachHang kh = new BUS_KhachHang();
        public QuanLyPhong()
        {
            InitializeComponent();
        }


        public static string sql = @"server = MINHTIENIT; database = QuanLyKhachSan; uid  =sa; pwd = 123";
        public static SqlConnection con;

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            dgvDanhSachKhachHang.DataSource = kh.HienThiThongTinKhachHang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            dgvDanhSachPhongTrong.DataSource = pk.dlPhongTrong();
        }

        private void dgvDanhSachPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgvDanhSachPhongTrong.Rows.Count > 1)
            {
                DataGridViewRow row = dgvDanhSachPhongTrong.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells[0].Value.ToString();
                
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            bool check = true;
          
            try
            {
                if (con == null)
                    con = new SqlConnection(sql);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string s = dtpNgayThue.Value.ToString("dd/MM/yyyy");
                MessageBox.Show(s);
                string str = "insert into KhachHang (MaKhach,HoTen,SCMND,NgayThue,NgayKetThuc, MaPhong,ThanhTien) values ('" + txtMaKhachHang.Text + "', N'" + txtTenKhachHang.Text + "', '" + txtCMND.Text + "', '" + dtpNgayThue.Value.ToString("yyyy/MM/dd") + "', '" + dtpNgayKetThuc.Value.ToString("yyyy/MM/dd") + "', '" + txtMaPhong.Text + "'," + 0 + ")";
                SqlCommand cm = new SqlCommand(str, con);
                cm.ExecuteNonQuery();
            }catch
            {
                check = false;
            }
            
            if(check == true)
            {
                MessageBox.Show("Thêm Thành Công");

                bool x = pk.TinhTrang(txtMaPhong.Text, "Có Khách");
            }
            else
            {
                MessageBox.Show("Thêm Thất bại");
            } 
                

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
