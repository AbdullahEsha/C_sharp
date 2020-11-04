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
    class OrderRepository
    {
        DataAccess dataAccess;
        public OrderRepository()
        {
            dataAccess = new DataAccess();
        }

        public List<Orders> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM OrdersInfo";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Orders> o = new List<Orders>();
                while (reader.Read())
                {
                    Orders or = new Orders();
                    or.Id = (int)reader["OrderID"];
                    or.ItemName = reader["ItemName"].ToString();
                    or.Quantity = (int)reader["Quantity"];
                    or.Payment = (int)reader["Payment"];
                    or.Location = reader["Location"].ToString();
                    o.Add(or);
                }
                return o;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Insert(Orders o)
        {
            try
            {
                string sql = "INSERT INTO OrdersInfo ( [ItemName], Quantity, Payment, [Location]) VALUES ('" + o.ItemName + "','" + o.Quantity + "','" + o.Payment + "','" + o.Location + "')";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public  int Delete(int id)
        {
            try
            {
                string sql = "DELETE FROM OrdersInfo WHERE OrderID='" + id + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }

    }
}
