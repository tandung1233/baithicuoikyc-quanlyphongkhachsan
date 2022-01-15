using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DAL_KhachHang : DBConection
    {
        public DataTable LayDuLieuKhachHang()
        {

            return DBConection.LayDuLieuCuaKhachHang(@"select *from KhachHang");
        }


        public DataTable TimKhachHang(string t)
        {
            return DBConection.LayDuLieu(@"select *from KhachHang where HoTen like N'" + t + "%'");
        }

        public int LayNgay(string m)
        {
            string s = @"select DATEDIFF(day, NgayThue, NgayKetThuc) 
            from KhachHang where MaKhach = '"+m+"'";
            return DBConection.LayNgay(s);
        }

        public bool XoaKhachHang(string m)
        {
            string s = @"delete KhachHang where MaKhach = '"+m+"'";

            return DBConection.XuLy(s);
        }


    }
}
