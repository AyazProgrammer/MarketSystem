using MarketSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSystem.Base
{
    internal interface IUserOperations
    {
        void AddUSer(Users users);
        void RemoveUSer(Users users);

        void GetAllUSer();

        

    }
}
