using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_shop_management
{
    class ReviewRepository
    {
        DataAccess dataAccess;
        public ReviewRepository()
        {
            dataAccess = new DataAccess();
        }
        public List<Reviews> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM ReviewInfo";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Reviews> r = new List<Reviews>();
                while (reader.Read())
                {
                    Reviews re= new Reviews();
                    re.Id = (int)reader["ID"];
                    re.ItemName = reader["ItemName"].ToString();
                    re.Review = reader["Review"].ToString();
                    re.Rating = reader["Rating"].ToString();
                    r.Add(re);
                }
                return r;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public int Insert(Reviews re)
        {
            try
            {
                string sql = "INSERT INTO ReviewInfo ( [ItemName], [Review], [Rating]) VALUES ('" + re.ItemName + "','" + re.Review + "', '" + re.Rating + "')";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int Delete(int id)
        {
            try
            {
                string sql = "DELETE FROM ReviewInfo WHERE ID='" + id + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
