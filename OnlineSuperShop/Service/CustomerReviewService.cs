using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_shop_management
{
    class CustomerReviewService
    {
        ReviewRepository reviewRepo;

        public CustomerReviewService()
        {
            reviewRepo = new ReviewRepository();
        }

        public int Insert(Reviews r)
        {
            return reviewRepo.Insert(r);
        }
        public List<Reviews> GetAll()
        {
            return reviewRepo.GetAll();
        }
    }
}
