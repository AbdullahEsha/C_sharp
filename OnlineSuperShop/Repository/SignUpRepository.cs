using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_shop_management
{
    public class SignUpRepository
    {
        DataAccess dataAccess;
        public SignUpRepository()
        {
            dataAccess = new DataAccess();
        }

        public int Register(string name, string password, int phone, string gender, string type)
        {
            string sql = "INSERT INTO UserInfo([UserName],[Password],Phone,[Gender],[Usertype]) VALUES('" + name + "','" + password + "','" + phone + "','" + gender + "','" + type + "')";
            return dataAccess.ExecuteQuery(sql);
        }

        public User GetUser(User ur)
        {
            try
            {

                string sql = "SELECT * FROM UserInfo WHERE Phone='" + ur.Phone + "' AND Password='" + ur.Password + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                ur.UserID = (int)reader["UserId"];
                ur.Username = reader["UserName"].ToString();
                ur.Password = reader["Password"].ToString();
                ur.Phone = (int)reader["Phone"];
                ur.Gender = reader["Gender"].ToString();
                ur.UserType = reader["UserType"].ToString();

                return ur;

            }
            catch (Exception)
            {
                return null;
            }
        }
        public int Duplicate(int phone)
        {
            try
            {
                string sql = "SELECT COUNT(Phone) FROM UserInfo where Phone= '"+ phone+"' ";
                return dataAccess.ExecuteCountQuery(sql);
            }
            catch(Exception)
            {
                return -1;
            }
        }
    }
}
