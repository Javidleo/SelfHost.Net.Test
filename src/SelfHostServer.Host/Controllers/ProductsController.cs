using SelfHostServer.Host.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostServer.Host.Controllers
{
    // http://localhost:5009/api/products
    public class ProductsController : ApiController
    {
        private readonly Product[] products = new Product[]
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
