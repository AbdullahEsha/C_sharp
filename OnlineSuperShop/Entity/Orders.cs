using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_shop_management
{
    public class Orders
    {
        public int Id { set; get; }
        public string ItemName { set; get; }
        public int Quantity { set; get; }
        public int Payment { set; get; }
        public string Location { set; get; }
    }
}
