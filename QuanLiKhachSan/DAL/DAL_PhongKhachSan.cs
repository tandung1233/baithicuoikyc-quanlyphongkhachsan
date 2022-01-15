using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_PhongKhachSan : DBConection
    {
        public DataTable DuLieuPhongTrong()
        {
            return DBConection.LayDuLieu(@"select *from Phong where TinhTrang like N'Trống'");
        }

        public DataTable HienThiPhong()
        {
            return DBConection.LayDuLieu(@"select *from Phong");
        }

        public bool ThemPhong(string m, string t, int sg, double dg, string tt)
        {
            string str = @"insert into Phong(MaPhong, TenPhong, SoGiuong, DonGia, TinhTrang) values('" + m + "', N'" + t + "', " + sg + ", " + dg + ", N'" + tt + "')";
            return DBConection.XuLy(str);
        }

        public bool SuaPhong(string m, string t, int sg, double dg, string tt)
        {
            string str = @"update Phong set TenPhong = N'"+t+"', SoGiuong = "+sg+", DonGia = "+dg+",TinhTrang = N'"+tt+"' where MaPhong = '"+m+"' ";
            return DBConection.XuLy(str);
        }

       
        public bool TinhTrang(string m, string tt)
        {
            return DBConection.XuLy(@"update Phong set TinhTrang = N'" + tt + "' where MaPhong = '" + m + "'");
        }

        public bool XoaPhong(string m)
        {
            return DBConection.XuLy(@"delete Phong where MaPhong = '"+m+"'");
        }
    }
}
