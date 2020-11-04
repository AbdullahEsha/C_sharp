using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_shop_management
{
    class LoginService
    {
        CredentialRepository credRepo;
        UserRepository userRepo;

        public LoginService()
        {
            credRepo = new CredentialRepository();
            userRepo = new UserRepository();
        }

        public User LoginValidation(User ur)
        {
            return credRepo.Validation(ur);
        }

        public int UserUpdate(string password, int phone)
        {
            return userRepo.Update(password, phone);
        }
    }
}
