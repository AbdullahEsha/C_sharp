using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_shop_management
{
    class CustomerService
    {
        ItemRepository itemRepo;
        OrderRepository orderRipo;
        public CustomerService()
        {
            itemRepo = new ItemRepository();
            orderRipo = new OrderRepository();
        }

        public List<Items> GetAll(string item)
        {
            return itemRepo.GetAll(item);
        }

        public int Insert(Orders o)
        {
            return orderRipo.Insert(o);
        }

        public int Update(int newQuantity, string itemName)
        {
            return itemRepo.Update(newQuantity, itemName);
        }
    }
}
