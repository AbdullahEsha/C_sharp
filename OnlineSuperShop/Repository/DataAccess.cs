using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Ice_Cream_shop_management
{
    public class DataAccess
    {
        static SqlConnection connection;
        static SqlCommand command;

        public DataAccess()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-45MJD4G;Initial Catalog=SuperDB;Integrated Security=True");
            connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteNonQuery();
        }

        public int ExecuteCountQuery(string sql)
        {
            command = new SqlCommand(sql, connection);
            return (int)command.ExecuteScalar();
        }
        public void Dispose()
        {
            connection.Close();
        }
        ~DataAccess()
        {
            connection.Close();
        }
    }
    
}
