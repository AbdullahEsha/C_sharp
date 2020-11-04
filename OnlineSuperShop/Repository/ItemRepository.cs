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
    public class ItemRepository
    {
        DataAccess dataAccess;
        public ItemRepository()
        {
            dataAccess = new DataAccess();
        }
        public List<Items> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM ItemInfo";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Items> i = new List<Items>();
                while (reader.Read())
                {
                    Items itm = new Items();
                    itm.ItemName = reader["ItemName"].ToString();
                    itm.Quantity = (int)reader["Quantity"];
                    itm.Price = (int)reader["Price"];
                    itm.ItemType = reader["ItemType"].ToString();
                    i.Add(itm);
                }
                return i;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Insert(string itemName , int quantity , int price , string itemType)
        {
            try
            {
                string sql = "INSERT INTO ItemInfo ( [ItemName], Quantity, Price, [ItemType]) VALUES ('" + itemName + "','" + quantity + "','" 
                    + price + "','" + itemType + "')";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public List<Items> GetAll(string item)
        {
            try
            {
                string sql = "SELECT * FROM ItemInfo WHERE [ItemType]='" + item + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Items> i1 = new List<Items>();
                while (reader.Read())
                {
                    Items itm1 = new Items();
                    itm1.ItemName = reader["ItemName"].ToString();
                    itm1.Quantity = (int)reader["Quantity"];
                    itm1.Price = (int)reader["Price"];
                    //itm1.ItemType = reader["ItemType"].ToString();
                    i1.Add(itm1);
                }
                return i1;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Update(int nQuantity, string itemName)
        {
            try
            {
                string sql = "UPDATE ItemInfo SET Quantity='" + nQuantity + "' WHERE [ItemName]='" + itemName + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public int UpdatePrice(int price, string itemName)
        {
            try
            {
                string sql = "UPDATE ItemInfo SET Price='" + price + "' WHERE [ItemName]='" + itemName + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public int UpdateItemType(string itemType, string itemName)
        {
            try
            {
                string sql = "UPDATE ItemInfo SET ItemType='" + itemType + "' WHERE [ItemName]='" + itemName + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Delete(string itemName)
        {
            try
            {
                string sql = "DELETE FROM ItemInfo WHERE [ItemName]='" + itemName + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }  
    }
}
