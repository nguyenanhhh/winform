using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietTre_KLTN
{
    class Adapter
    {
        public static string ConnStr = "Data Source=LAPTOP-84CTG406\\SQLEXPRESS;Initial Catalog=2121000995_LeThiQuynhTruc_21DTK2;Integrated Security=True";
    }
    //public SqlDataReader RunQuery(string sql)
    //{
    //    string ConnStr = null;
    //    SqlConnection sqlConn = new SqlConnection(ConnStr);
    //    sqlConn.Open();
    //    SqlCommand command;
    //    SqlDataReader dataReader;
    //    command = new SqlCommand(sql, sqlConn);
    //    dataReader = command.ExecuteReader();
    //    return dataReader;
    //}
}
