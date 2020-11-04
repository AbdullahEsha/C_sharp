using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_shop_management
{
    class SignUpService
    {
        SignUpRepository signRepo;
        CVRepository cvRepo;
        public SignUpService()
        {
            signRepo = new SignUpRepository();
            cvRepo =  new CVRepository();
        }
        public int UserRegistration(string name, string password, int phone, string gender, string type)
        {
            return signRepo.Register(name, password, phone, gender, type);
        }
        public User GetUserInfo(User ur)
        {
            return signRepo.GetUser(ur);
        }
        public int CVInsert(CV c)
        {
            return cvRepo.Insert(c);
        }
        public int CheckDuplicate(int phone)
        {
            return signRepo.Duplicate(phone);
        }
    }
}
