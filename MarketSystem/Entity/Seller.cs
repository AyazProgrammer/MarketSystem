using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketSystem.Base;

namespace MarketSystem.Entity
{
    internal class Seller : Users
    {
 
        public decimal SalesTarget { get; set; }
        public decimal AchievedSales { get; set; }
    }
}
