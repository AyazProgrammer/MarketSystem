

using MarketManageSystem;
using MarketManageSystem.Abstract;
using MarketManageSystem.Concrete;
using System.Data;

Product product1 = new Product() { Id = 1, CategoryId = 2, Count = 3, Name="pomidor",Price=5455};
Product product2 = new Product() { Id = 1, CategoryId = 3, Count = 3, Name="kartof",Price=3000 };
User user1 = new User() { Id = 1, Name = "admin",UserName= "Ayaz123", Password = "12334", Role="User" };
User user2 = new User() { Id = 1, Name = "admin",UserName= "Elnur123", Password = "12334"  };

ProductManager productManager = new ProductManager();
UserManager userManager = new UserManager();
ViewManager<BaseUser> viewForUser = new ViewManager<BaseUser>();
ViewManager<BaseProduct> viewForProduct = new ViewManager<BaseProduct>();

Product deleteProduct = new Product() {Id=1, CategoryId=3,Count=3,Price=4000, Name="badimcan" };
Product changeProduct = new Product() { Id = 1, CategoryId = 3, Count = 3, Name = "qarpiz", Price = 3000 };
Product UpdateProduct = new Product() { Id = 1, CategoryId = 2, Count = 3, Name = "yemis", Price = 5455 };

// add item

userManager.Add(user2);

productManager.Add(product1);
productManager.Add(product2);




//delete product
productManager.Delete(deleteProduct);

productManager.Update(changeProduct);
// find by Id item
Console.WriteLine("------------------------------------find by Id --------------------");
viewForProduct.show(productManager.FindById(1));


productManager.SellProduct(product1, user1);
productManager.SellProduct(product2, user1);
// getAll items and show view
Console.WriteLine("------------------------------------get All Item--------------------");
viewForProduct.show(productManager.GetAll());

viewForUser.show(userManager.GetAll());

Console.WriteLine("------------------------------------get All Item--------------------");





