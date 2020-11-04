using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_shop_management
{
    class OwnerService
    {
        SoldItemsRepository soldRepo;
        UserRepository userRepo;
        CVRepository cvRepo;
        ReviewRepository revRepo;

        public OwnerService()
        {
            soldRepo = new SoldItemsRepository();
            userRepo = new UserRepository();
            cvRepo = new CVRepository();
            revRepo = new ReviewRepository();
        }
        public List<SoldItems> SoldItemsGetAll()
        {
            return soldRepo.GetAll();
        }
        public List<SoldItems> GetSearchItems(string item)
        {
            return soldRepo.GetSearchItem(item);
        }
        public List<User> GetTypeMember(string type)
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
        public List<CV> CVGetAll()
        {
            return cvRepo.GetAll();
        }
        public int ReviewDelete(int id)
        {
            return revRepo.Delete(id);
        }
        public List<Reviews> ReviewGetAll()
        {
            return revRepo.GetAll();
        }
        public int CVDelete(int Phone)
        {
            return cvRepo.Delete(Phone);
        }
    }
}
