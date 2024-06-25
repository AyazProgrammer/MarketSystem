using MarketSystem.Base;
using MarketSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSystem.manager
{
    internal class SellerManager : OperationManager
    {
        public override void Add(Product item)
        {
            base.Add(item);
        }

        public override void Delete(int id)
        {
            base.Delete(id);
        }

        public override List<Product> Filtrate(int id)
        {
            return base.Filtrate(id);
        }

        public override List<Product> GetAll()
        {
            return base.GetAll();
        }

        public override List<Product> GetById(int id)
        {
            return base.GetById(id);
        }

        public override void Update(Product item)
        {
            base.Update(item);
        }
    }
}
