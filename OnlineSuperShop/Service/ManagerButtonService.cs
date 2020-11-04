using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_shop_management
{
    class ManagerButtonService
    {
        SoldItemsRepository soldRepo;
        UserRepository userRepo;

        public ManagerButtonService()
        {
            soldRepo = new SoldItemsRepository();
            userRepo = new UserRepository();
        }     
        public List<User> UserTypeMember(string type)
        {
            return userRepo.GetTypeMember(type);
        }
        public int UserInsert(string username, string password, int phone, string gender, string usertype)
        {
            return userRepo.Insert(username, password, phone, gender, usertype);
        }
        public int UserDelete(int phone)
        {
            return userRepo.Delete(phone);
        }
        public int UserNameUpdate(string name, int phone)
        {
            return userRepo.Update(name, phone);
        }
       
    }
}
