using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MarketManageSystem.Concrete
{
    internal class ViewManager<T>
    {
        public void show (List<T> list)
        {
            List<T> items = new List<T>();
            if (list == null|| list.Count==0)
            {
                Console.WriteLine("siyahida hec bir element yoxdur");
            }
            else
            {
                foreach (var item in list)
                {
                  // if unknown property name and property count
                    Type type = item.GetType();
                    PropertyInfo[] properties = type.GetProperties();

                    foreach (var property in properties)
                    {
                      // if (property.PropertyType == typeof(T))
                        Console.Write($"{property.Name}: {property.GetValue(item, null)} ");
                    }
                    Console.WriteLine(); 
                }
            }
        }


        
    }
}
