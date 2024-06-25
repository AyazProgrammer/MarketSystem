

using MarketSystem.Base;
using MarketSystem.Entity;
using MarketSystem.manager;


Users admin1 = new Admin() { Id=1, Name="admin",Password="123a" };

Users seller1 = new Seller() {Id=2, Name="seller", Password="1234" };

List<Seller> seller = new List<Seller>();
List<Cashier> cashiers = new List<Cashier>();
List<Admin> admins = new List<Admin>();


Users Seller = new Seller();





AdminManager adminManager = new AdminManager();
CashierManager cashierManager = new CashierManager();





//-------------------------------------------------Users Operation--------------------------------------------------------);
adminManager.AddUSer(admin1);
adminManager.AddUSer(seller1);

adminManager.GetAllUSer();
adminManager.RemoveUSer(seller1);


//------------------------------------------------- Product Operation---------------------------------------------------------




//add product

adminManager.Add(new Product { Id = 1, ProductName = "alma", Count = 3, Price = 45, CategoryId = 2 });
adminManager.Add(new Product() { Id = 2, ProductName = "armud", Count = 3, Price = 45, CategoryId = 3 });
adminManager.Add(new Product { Id = 3, ProductName = "banan", Count = 3, Price = 45, CategoryId = 2 });
adminManager.Add(new Product { Id = 4, ProductName = "kivi", Count = 3, Price = 45, CategoryId = 3 });

// get all product
List<Product> list = adminManager.GetAll();

// get product Filter
List<Product> Getlist = cashierManager.Filtrate(3);

// get product by Id
List<Product> Getlist2 = cashierManager.GetById(1);


//sell product
List<Product> Getlist3 = cashierManager.Sell(4);
//delete product
adminManager.Delete(3);

// Update product
Product productNew = new Product { Id = 1, ProductName = "siqaret", Count = 3, Price = 45, CategoryId = 2 };
adminManager.Update(productNew);


Console.WriteLine("--------------------------------------------------------Get All Products---------------------------------------------------");
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"Id: {list[i].Id}, name:{list[i].ProductName}, price:{list[i].Price}, Count:{list.Count}, category:{list[i].CategoryId} ");
}
Console.WriteLine("--------------------------------------------------------Category ID filterate Products---------------------------------------------------");
for (int i = 0; i < Getlist.Count; i++)
{
    Console.WriteLine($"Id: {Getlist[i].Id}, name:{Getlist[i].ProductName}, price:{Getlist[i].Price}, Count:{Getlist.Count}, category:{Getlist[i].CategoryId} ");
}
Console.WriteLine("--------------------------------------------------------get by ID filterate Products---------------------------------------------------");

for (int i = 0; i < Getlist2.Count; i++)
{
    Console.WriteLine($"Id: {Getlist2[i].Id}, name:{Getlist2[i].ProductName}, price:{Getlist2[i].Price}, Count:{Getlist2.Count}, category:{Getlist2[i].CategoryId} ");
}


Console.WriteLine("--------------------------------------------------------sell list----------------------------------------------------------------");

for (int i = 0; i < Getlist3.Count; i++)
{
    Console.WriteLine($"Id: {Getlist3[i].Id}, name:{Getlist3[i].ProductName}, price:{Getlist3[i].Price}, Count:{Getlist3.Count}, category:{Getlist3[i].CategoryId} ");
}






