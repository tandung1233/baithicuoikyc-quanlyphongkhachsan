using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BUS;

namespace UI
{
    public partial class QuanLyKhachHang : Form
    {
        BUS_KhachHang kh = new BUS_KhachHang();
        BUS_PhongKhach pk = new BUS_PhongKhach();
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
           


            DataTable ListKh = kh.HienThiThongTinKhachHang();
            int size = ListKh.Rows.Count;
            DataTable Listpk = pk.HienThiPhong();
            int sizepk = Listpk.Rows.Count;

            /*for (int i = 0; i < sizepk; i++)
            {
                double dongia = double.Parse(Listpk.Rows[i]["DonGia"].ToString());
                MessageBox.Show(dongia.ToString());
            }*/

            for (int i = 0; i < size; i++)
            {
                double SoTien = 0;
                for (int j = 0; j < sizepk; j++)
                {
                    if (ListKh.Rows[i]["MaPhong"].ToString() == Listpk.Rows[j]["MaPhong"].ToString())
                    {
                        SoTien = double.Parse(Listpk.Rows[j]["DonGia"].ToString());
                        break;
                    }
                }

                ListKh.Rows[i]["ThanhTien"] = (SoTien * int.Parse(ListKh.Rows[i]["SoNgay"].ToString())).ToString();

            }


            dgvDanhSachKhachHang.DataSource = ListKh;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable ListKh = kh.HienThiThongTinKhachHang();
            int size = ListKh.Rows.Count;
            for (int i = 0; i < size - 1; i++)
            {
                MessageBox.Show(ListKh.Rows[i]["SoNgay"].ToString());
            }
        }
        DataGridViewRow row = null;
        private void dgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (dgvDanhSachKhachHang.Rows.Count > 1)
            {
                 row = dgvDanhSachKhachHang.Rows[e.RowIndex];
                txtMaKh.Text = row.Cells[0].Value.ToString();
                txtTenKh.Text = row.Cells[1].Value.ToString();
                txtCMND.Text = row.Cells[2].Value.ToString();
                txtMaPhong.Text = row.Cells[5].Value.ToString();
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(row != null)
            {
                bool check = kh.XoaKhachHang(txtMaKh.Text);
                
                if (check == true)
                {
                    pk.TinhTrang(txtMaPhong.Text, "Trống");
                    MessageBox.Show("Thanh toán thành công");
                    DataTable ListKh = kh.HienThiThongTinKhachHang();
                    int size = ListKh.Rows.Count;
                    DataTable Listpk = pk.HienThiPhong();
                    int sizepk = Listpk.Rows.Count;

                    /*for (int i = 0; i < sizepk; i++)
                    {
                        double dongia = double.Parse(Listpk.Rows[i]["DonGia"].ToString());
                        MessageBox.Show(dongia.ToString());
                    }*/

                    for (int i = 0; i < size; i++)
                    {
                        double SoTien = 0;
                        for (int j = 0; j < sizepk; j++)
                        {
                            if (ListKh.Rows[i]["MaPhong"].ToString() == Listpk.Rows[j]["MaPhong"].ToString())
                            {
                                SoTien = double.Parse(Listpk.Rows[j]["DonGia"].ToString());
                                break;
                            }
                        }

                        ListKh.Rows[i]["ThanhTien"] = (SoTien * int.Parse(ListKh.Rows[i]["SoNgay"].ToString())).ToString();

                    }


                    dgvDanhSachKhachHang.DataSource = ListKh;
                } 
            }    
        }
    }
}
