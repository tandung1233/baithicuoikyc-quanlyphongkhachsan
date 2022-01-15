using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang kh = new DAL_KhachHang();

        public DataTable HienThiThongTinKhachHang()
        {
            return kh.LayDuLieuKhachHang();
        }

        public DataTable TimKhachHang(string t)
        {
            return kh.TimKhachHang(t);
        }

        public int LayNgay(string m)
        {
            return kh.LayNgay(m);
        }


        public bool XoaKhachHang(string m)
        {
            return kh.XoaKhachHang(m);
        }
    }

}
