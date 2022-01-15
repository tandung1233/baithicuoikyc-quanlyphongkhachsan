using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace DAL
{
    public class  DAL_TaiKhoan :DBConection
    {
        public DataTable NguoiDung()
        {
            return DBConection.LayDuLieu("select *from QuanLyTaiKhoan");
        }
    }
}
