using ProductCodeFirst.Data;
using ProductCodeFirst.Models;

namespace ProductCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            //Add data to Product table
            Product p = new Product() { Name = "Product 3", Description = "This is product #3", Price = 1600 };
            dbContext.Products.Add(p);
            dbContext.SaveChanges();

            //Add data to Order table
            Order o = new Order()
            {
                Address = "Jordan",
                CreatedAt = DateTime.Parse("2014-08-20 00:06:35")
            };
            dbContext.Orders.Add(o);
            dbContext.SaveChanges();

            Console.WriteLine("==========Products==========");
            //get all products
            var products = dbContext.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Description);
            }
            Console.WriteLine("===========Orders===========");
            //get all orders    
            var orders = dbContext.Orders.ToList();
            foreach (var order in orders)
            {
                Console.WriteLine(order.Address);
                Console.WriteLine(order.CreatedAt);
            }

            //update product => 1 , name
            var productEdit = dbContext.Products.Find(1);
            productEdit.Name = "Product 1";
            dbContext.SaveChanges();

            //update order created at
            var orderEdit = dbContext.Orders.Find(1);
            orderEdit.CreatedAt = DateTime.Parse("10/05/2012");
            dbContext.SaveChanges();

            //remove product with id 2
            var productDel = dbContext.Products.Find(2);
            dbContext.Products.Remove(productDel);
            dbContext.SaveChanges();

            //remove order with id 3
            var orderDel = dbContext.Orders.Find(3);
            dbContext.Orders.Remove(orderDel);
            dbContext.SaveChanges();

        }
    }
}
