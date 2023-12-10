using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostServer.Host
{
    // http://localhost:5009/api/orders

    public class OrdersController : ApiController
    {
        Order[] orders = new Order[]
        {
                new Order { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
                new Order { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
                new Order { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }
    }
     
    // http://localhost:5009/api/products
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
                new Product { Id = 1, Name = "Product 1" },
                new Product { Id = 2, Name = "Product 2" },
                new Product { Id = 3, Name = "Product 3" },
        };

        [HttpGet]
        public IEnumerable<Product> All()
        {
            return products;
        }
    }
}



public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}
