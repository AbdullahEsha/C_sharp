using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_shop_management
{
    class SalesmanService
    {
        OrderRepository orderRepo;
        SoldItemsRepository soldRepo;
        public SalesmanService()
        {
            orderRepo = new OrderRepository();
            soldRepo = new SoldItemsRepository();
        }

        public List<Orders> GetAll()
        {
            return orderRepo.GetAll();
        }

        public int Delete(int id)
        {
            return orderRepo.Delete(id);
        }

        public int InsertSold(string itemName, int quantity, int earn, int sId)
        {
            return soldRepo.Insert(itemName, quantity, earn, sId);
        }
    }
}
