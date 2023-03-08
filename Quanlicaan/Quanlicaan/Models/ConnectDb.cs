using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Quanlicaan.Models
{
    public class ConnectDb
    {
        public static SqlConnection ConnectionDb()
        {
            //   var connectionStringBuilder = new SqlConnectionStringBuilder();
            //    connectionStringBuilder["Server"] = @"TOANLV\SQLEXPRESS";
            //    connectionStringBuilder["Initial Catalog"] = "QuanLiCaAn";
            //    connectionStringBuilder["User ID"] = "sa";
            //    connectionStringBuilder["Password"] = "123456";

            //    string connectionString = connectionStringBuilder.ToString();

            string connectionString = @"Data Source=TQSANG1403\SQLEXPRESS;Initial Catalog=QuanLiCaAn;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }


    }
}