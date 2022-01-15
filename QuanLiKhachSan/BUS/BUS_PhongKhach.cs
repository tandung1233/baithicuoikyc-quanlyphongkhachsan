using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
 
    public class BUS_PhongKhach
    {
        DAL_PhongKhachSan phong = new DAL_PhongKhachSan();
        public DataTable dlPhongTrong()
        {
            return phong.DuLieuPhongTrong();
        }

        public DataTable HienThiPhong()
        {
            return phong.HienThiPhong();    
        }

        public bool ThemPhong(string m, string t, int sg, double dg, string tt)
        {
            return phong.ThemPhong(m, t, sg, dg, tt);
        }


        public bool TinhTrang(string m, string tt)
        {
            return phong.TinhTrang(m, tt);
        }

        public bool SuaPhong(string m, string t, int sg, double dg, string tt)
        {
            return phong.SuaPhong(m, t, sg, dg, tt);
        }


        public bool XoaPhong(string m)
        {
            return phong.XoaPhong(m);
        }
    }
}
