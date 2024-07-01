using MarketManageSystem.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MarketManageSystem.Abstract
{
    internal class IOperationManager<T> :PermissionManager,  IOperations<T> where T : class
    {
        public static List<T> itemList  = new List<T>();

       

        public virtual void Add( T item)
        {
            
           itemList.Add(item);
        }
      


        public virtual List<T> Delete(T item)
        {
            Type type = item.GetType();
            PropertyInfo[] properties = type.GetProperties();


            foreach (var property in properties)
            {
                Console.WriteLine($"{property}");
                for (int i = 0; i < itemList.Count; i++)
                {

                    ;
                    Type typeListItem = itemList[i].GetType();
                    PropertyInfo[] propertiesListItem = typeListItem.GetProperties();



                    foreach (var propertyListItem in propertiesListItem)
                    {
                        if (property.GetValue(item, null) == propertyListItem.GetValue(itemList[i]))
                        {
                          
                            itemList.RemoveAt(i);
                            continue;


                        }


                    }

                }

            }



            return itemList;
            
        }

        public List<T> Filtrate(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> FindById(int id)
        {
            List<T> findList = new List<T> ();
            foreach (var item in itemList)
            {
                PropertyInfo propertyId = item.GetType().GetProperty("Id");
                if (propertyId != null)
                {
                    var itemId = (int)propertyId.GetValue(item);
                    if (itemId == id)
                    {
                        findList.Add(item);
                    }
                }
            }

            return findList;
        }


        public List<T> GetAll()
        {
           
            return itemList;
        }

      

        public List<T> Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
