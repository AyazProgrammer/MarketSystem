using MarketManageSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManageSystem.Concrete
{
    internal class PermissionManager
    {
        public string  CheckRolePermission(User user)
        {

            string result = "";

            if (user.Role != null)
            {
                if (user.Role == "Admin")
                {
                    result = "Admin";
                }
                else if (user.Role == "Seller")
                {
                    result = "Seller";
                }
                else if (user.Role == "Cashier")
                {
                    result = "cashier";
                }
             
              
            }
            return result;

        }
      

    }
}
