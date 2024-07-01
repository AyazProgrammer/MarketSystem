using MarketManageSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManageSystem
{
    internal class Product:BaseProduct,ICategory
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double Count { get; set; }

        public double Price { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
