using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManageSystem.Abstract
{
    internal interface ICategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
