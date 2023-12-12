using SelfHostServer.Host.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostServer.Host.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly Order[] orders = new Order[]
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
}
