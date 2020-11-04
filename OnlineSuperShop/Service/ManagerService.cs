using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_shop_management
{
    class ManagerService
    {
        ItemRepository itemRepo;
        SoldItemsRepository soldRepo;
        public ManagerService()
        {
            itemRepo = new ItemRepository();
            soldRepo = new SoldItemsRepository();
        }

        public List<Items> GetAll()
        {
            return itemRepo.GetAll();
        }
        public int Update(int newQuantity, string itemName)
        {
            return itemRepo.Update(newQuantity, itemName);
        }
        public int InsertSold(string itemName, int quantity, int earn, int sId)
        {
            return soldRepo.Insert(itemName, quantity, earn, sId);
        }
        public int UpdateQuantity(int quan , string itemname)
        {
            return itemRepo.Update(quan,itemname);
        }
        public int UpdatePrice(int price, string itemname)
        {
            return itemRepo.UpdatePrice(price, itemname);
        }
        public int UpdateItemType(string itemtype, string itemname)
        {
            return itemRepo.UpdateItemType(itemtype, itemname);
        }
        public int ItemInsert(string itemName , int quantity , int price , string itemType)
        {
            return itemRepo.Insert(itemName, quantity, price, itemType);
        }
        public int DeleteItem(string itemName)
        {
            return itemRepo.Delete(itemName);
        }
    }
}
