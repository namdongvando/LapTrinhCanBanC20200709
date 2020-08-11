using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyNhanVien
{

    class Adapter
    {
        public static string ConnStr = "Data Source=PC26;Initial Catalog=QLHD;Integrated Security=True";

        public SqlDataReader RunQuery(string sql)
        {

            SqlConnection sqlConn = new SqlConnection(ConnStr);
            sqlConn.Open();
            //string sql = "select * from NhanVien";
            SqlCommand command;
            SqlDataReader dataReader;
            command = new SqlCommand(sql, sqlConn);
            //command.ExecuteReader();
            dataReader = command.ExecuteReader();
            return dataReader;
        }
        public bool SaveQuery(string sql)
        {
            SqlConnection sqlConn = new SqlConnection(ConnStr);
            sqlConn.Open();
            SqlCommand command;
            command = new SqlCommand(sql, sqlConn);
            int kt = command.ExecuteNonQuery();
            return kt > 0;
        }
    }
}
