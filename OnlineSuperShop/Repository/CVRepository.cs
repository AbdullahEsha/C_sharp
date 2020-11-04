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
    public class CVRepository
    {
        DataAccess dataAccess;
        public CVRepository()
        {
            dataAccess = new DataAccess();
        }

        public List<CV> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM CVInfo";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<CV> c = new List<CV>();
                while (reader.Read())
                {
                    CV cv = new CV();
                    cv.UserName = reader["UserName"].ToString();
                    cv.Dob = (DateTime)reader["DOB"];
                    cv.Phone = (int)reader["Phone"];
                    cv.JobType = reader["JobType"].ToString();
                    cv.Gender = reader["Gender"].ToString(); 
                    cv.JobPost = reader["JobPost"].ToString();
                    cv.Qualification = reader["Qualification"].ToString();
                    cv.Experience = reader["Experience"].ToString();
                    cv.Skills = reader["Skills"].ToString();
                    //cv.Image= (byte)reader["Image"];
                    c.Add(cv);
                }
                return c;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Insert(CV c)
        {
            try
            {
                string sql = "INSERT INTO CVInfo ( [UserName], [DOB], Phone,[JobType],[Gender],[JobPost],[Qualification],[Experience],[Skills])  VALUES ('" + c.UserName+ "','" + c.Dob + "','"+ c.Phone + "','" + c.JobType+"','"+c.Gender+"','"+c.JobPost+"','"+c.Qualification+"','"+c.Experience+"','"+c.Skills+"')";
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
                string sql = "DELETE FROM CVInfo WHERE Phone='" + phone + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
    
     
}
