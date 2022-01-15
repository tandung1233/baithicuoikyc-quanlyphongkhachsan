using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConection
    {
        public static string sql = @"server = MAYTINH\SQLEXPRESS; database = QuanLyKhachSan; uid  =sa; pwd = 123456";
        public static SqlConnection con;


        public static int LayNgay(string c)
        {
            if (con == null)
                con = new SqlConnection(sql);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            SqlCommand cm = new SqlCommand(c, con);

            object data = cm.ExecuteScalar();
            int x = (int)data;

            return x;
        }


        public static DataTable LayDuLieu(string dulieu)
        {
            con = new SqlConnection(sql);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand(dulieu, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            dt.Columns.Add("STT");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["STT"] = (i + 1).ToString();
            }

            return dt;
        }

        public static DataTable LayDuLieuCuaKhachHang(string dulieu)
        {
            con = new SqlConnection(sql);
            DataTable dt = new DataTable();
            SqlCommand cm = new SqlCommand(dulieu, con );
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            dt.Columns.Add("SoNgay");

            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string s = @"select DATEDIFF(day, NgayThue, NgayKetThuc) 
                from KhachHang where MaKhach = '"+ dt.Rows[i]["MaKhach"]+"'";
                dt.Rows[i]["SoNgay"] = LayNgay(s).ToString();
            }

            return dt;
        }


       

        public static bool XuLy(string c)
        {
            try
            {
             

                if (con== null)
                    con = new SqlConnection(sql);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cm = new SqlCommand(c, con);
                cm.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }

            return true;
        }


        
    }
}
