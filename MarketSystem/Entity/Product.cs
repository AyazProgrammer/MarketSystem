using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSystem.Entity
{
    internal class Product
    {
        public int Id { get; set; }
     
        public double Count { get; set; }

        public int CategoryId { get; set; }
        public string ProductName { get; set; }

        public double Price { get; set; }
    }
}
