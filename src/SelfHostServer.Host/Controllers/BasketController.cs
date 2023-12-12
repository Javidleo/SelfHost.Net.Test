using SelfHostServer.Host.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SelfHostServer.Host.Controllers
{
    public class BasketController : ApiController
    {
        static List<BasketItem> BasketItems = new List<BasketItem>();

        [HttpPost]
        public string AddItemToBasket([FromBody] BasketItem item)
        {
            if (string.IsNullOrEmpty(item.Name))
                return "Name is null Please Enter a Name";

            BasketItems.Add(item);
            return "Item Added";
        }

        [HttpGet]
        public IEnumerable<BasketItem> GetBasketItems()
        {
            return BasketItems;
        }
        [HttpGet]
        public BasketItem GetByName([FromUri] string name)
        {
            var item = BasketItems.FirstOrDefault(i => i.Name == name);

            if (item is null)
                return new BasketItem();

            return item;
        }


    }
}
