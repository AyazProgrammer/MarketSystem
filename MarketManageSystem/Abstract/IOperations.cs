using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManageSystem.Abstract
{
    internal interface IOperations<T> where T : class
    {
        void Add(T item);

       
        List<T> GetAll();
        List<T> Filtrate(int id);

        List<T> Delete(T item);

        List<T> Update(T item);

        List<T> FindById (int id);

       
    }
}
