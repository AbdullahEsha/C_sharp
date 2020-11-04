using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ice_Cream_shop_management
{
    class UserRepository
    {
         DataAccess dataAccess;
         public UserRepository()
        {
            dataAccess = new DataAccess();
        }

        public List<User> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM UserInfo";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<User> u = new List<User>();
                while (reader.Read())
                {
                    User ur = new User();
                    ur.UserID = (int)reader["UserID"];
                    ur.Username = reader["UserName"].ToString();
                    ur.Phone = (int)reader["Phone"];
                    ur.Gender = reader["Gender"].ToString();
                    ur.UserType = reader["UserType"].ToString();
                    u.Add(ur);
                }
                return u;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<User> GetTypeMember(string type)
        {
            try
            {
                string sql = "SELECT * FROM UserInfo WHERE [UserType]='" + type + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<User> u = new List<User>();
                while (reader.Read())
                {
                    User ur = new User();
                    ur.UserID = (int)reader["UserID"];
                    ur.Username = reader["UserName"].ToString();
                    ur.Phone = (int)reader["Phone"];
                    ur.Gender = reader["Gender"].ToString();
                    ur.UserType = reader["UserType"].ToString();
                    u.Add(ur);
                }
                return u;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public int Insert(string userName, string password, int phone, string gender , string userType)
        {

            try
            {
                string sql = "INSERT INTO UserInfo ( [UserName], [Password], Phone, [Gender], [UserType] ) VALUES ('" + userName + "','" + password + "','"
                    + phone + "','" + gender + "','" + userType + "')";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public int Update(string password , int phone )
        {
            try
            {
                string sql = "UPDATE UserInfo SET Password='" + password + "' WHERE Phone='" + phone + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int Delete(int phone)
        {
            try
            {
                string sql = "DELETE FROM UserInfo WHERE Phone='" + phone + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
