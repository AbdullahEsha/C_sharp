using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ice_Cream_shop_management
{
    class SoldItemsRepository
    {
        DataAccess dataAccess;
        public SoldItemsRepository()
        {
            dataAccess = new DataAccess();
        }

        public List<SoldItems> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM SoldItemInfo";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<SoldItems> s = new List<SoldItems>();
                while (reader.Read())
                {
                    SoldItems si = new SoldItems();
                    si.ItemName = reader["ItemName"].ToString();
                    si.Quantity = (int)reader["Quantity"];
                    si.Earn = (int)reader["Earn"];
                    si.SId = (int)reader["SId"];
                    s.Add(si);
                }
                return s;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Insert(string itemName, int quantity, int earn, int sId)
        {
            try
            {
                string sql = "INSERT INTO SoldItemInfo ( [ItemName], Quantity, Earn, [SId]) VALUES ('" + itemName + "','" + quantity + "','" + earn + "','" + sId + "')";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public List<SoldItems> GetSearchItem(string item)
        {
            try
            {
                string sql = "SELECT * FROM SoldItemInfo WHERE [ItemName]='" + item + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<SoldItems> s = new List<SoldItems>();
                while (reader.Read())
                {
                    SoldItems si = new SoldItems();
                    si.ItemName = reader["ItemName"].ToString();
                    si.Quantity = (int)reader["Quantity"];
                    si.Earn = (int)reader["Earn"];
                    si.SId = (int)reader["SId"];
                    s.Add(si);
                }
                return s;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
