using MarketSystem.Base;
using MarketSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSystem.manager
{
    internal class AdminManager : OperationManager,IUserOperations
    {
        List<Users> allUsers = new List<Users>();






        public override void Add(Product item)
        {
            base.Add(item);
        }

        public void AddUSer(Users users)
        {
            allUsers.Add(users);
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

        public void GetAllUSer()
        {
            for (int i = 0; i < allUsers.Count; i++)
            {
                Console.WriteLine($"id:{allUsers[i].Id}, name:{allUsers[i].Name}, password: {allUsers[i].Password}");
            }
        }

       

        public override List<Product> GetById(int id)
        {
            return base.GetById(id);
        }

        public void RemoveUSer(Users  users)
        {
            for (int i = 0; i < allUsers.Count; i++)
            {
                if(allUsers[i].Id==users.Id)
                {
                    allUsers.RemoveAt(i);
                }
            }
        }

        public override void Update(Product item)
        {
            base.Update(item);
        }
    }
}
