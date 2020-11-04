using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_shop_management
{
    public class CredentialRepository
    {
        DataAccess dataAccess;
        public CredentialRepository()
        {
            dataAccess = new DataAccess();
        }

        public User Validation(User ur)
        {
            string sql = "SELECT * FROM UserInfo WHERE Phone ='" + ur.Phone + "' AND [Password]='" + ur.Password + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            ur.UserID = (int)reader["UserId"];
            ur.Username = reader["Username"].ToString();
            ur.Password = reader["Password"].ToString();
            ur.Phone = (int)reader["Phone"];
            ur.Gender = reader["Gender"].ToString();
            ur.UserType = reader["UserType"].ToString();

            return ur;
        }
    }
}
