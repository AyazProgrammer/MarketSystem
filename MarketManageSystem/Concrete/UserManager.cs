using MarketManageSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MarketManageSystem.Concrete
{
    internal class UserManager:IOperationManager<BaseUser>
    {

        private IOperationManager<BaseUser> operationManager = new IOperationManager<BaseUser>();

        

        PermissionManager permissionManager = new PermissionManager();
        public override void Add(BaseUser item)
        {
            operationManager.
           
            base.Add(item);
        }

        public override List<BaseUser> Delete(BaseUser item)
        {
            return base.Delete(item);
        }
       


    }
     
}
