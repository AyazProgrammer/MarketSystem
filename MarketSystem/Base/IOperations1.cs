
namespace MarketSystem.Base
{
    internal interface IOperations1<T> where T : class
    {


        // get mehtod for product
        void Add(T item);
        List<T> GetAll ();
        List<T> Filtrate(int id);

        void Delete (int id);

        void Update (T item);

        List<T> GetById(int id);

        // sell method

        List<T>Sell(int id);


    }
}