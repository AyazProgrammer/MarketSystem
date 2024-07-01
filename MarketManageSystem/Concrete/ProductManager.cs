using MarketManageSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManageSystem.Concrete
{
    internal class ProductManager : IOperationManager<BaseProduct>
    {
        public static List<BaseProduct> SellItemList = new List<BaseProduct>();

        UserManager UserManager = new UserManager();

        public List<BaseProduct> SellProduct(BaseProduct product, User user)
        {

            if (UserManager.CheckRolePermission(user)=="Seller")
            {
                SellItemList.Add(product);
                base.Delete(product);
                return SellItemList;
            }
            else
            {
                Console.WriteLine("Only sellers");
                return SellItemList; 
            }
       
        }

        List<BaseProduct> ReturnProduct(BaseProduct product)
        {
            SellItemList.Remove(product);
            base.Add(product);

            return SellItemList;
        }

    }
}
