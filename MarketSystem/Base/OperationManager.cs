using MarketSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSystem.Base
{
    internal abstract class OperationManager : IOperations1<Product>
    {

        private static List<Product> products = new List<Product>();

        private static List<Product> sellsItems = new List<Product>();




        public virtual void Add(Product item)
        {
            products.Add(item);
         

        }

        public virtual void Delete(int id)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id)
                {
                    products.Remove(products[i]);
                }
            }
        }



        public virtual List<Product> GetAll()
        {
            return products;
        }

        public virtual List<Product> Filtrate(int id)

        {
            List<Product> getItems = new List<Product>();
            foreach (Product item in products)
            {
                if (item.CategoryId == id)
                {
                    getItems.Add(item);
                }
            }
            return getItems;
        }

        public void Update(Product item, List<Product> itemList)
        {
            throw new NotImplementedException();
        }

        public virtual List<Product> GetById(int id)
        {
            List<Product> getIdItems = new List<Product>();
            foreach (Product item in products)
            {
                if (item.Id == id)
                {
                    getIdItems.Add(item);
                }
            }
            return getIdItems;
        }

        public List<Product> Sell(int id)
        {
           
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id)
                {
                    sellsItems.Add(products[i]);
                }
            }
            return sellsItems;
        }

        public virtual void Update(Product item)
        {

            for(int i = 0;i < products.Count;i++)
            {
                if (products[i].Id == item.Id)
                {
                    products[i].Id = item.Id;
                    products[i].ProductName = item.ProductName;


                }
            }
         

        }

      
    }
}
        
    

