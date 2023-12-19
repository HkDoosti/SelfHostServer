using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer2.Host
{
    public class OredrsController:ApiController
    {
        Order[] orders=new Order[] 
        {
            new Order{ id=1, Name="Tomato Soup" ,Category="Groceries",Price=1 },
            new Order{ id=2, Name="Yo-yo" ,Category="Toys",Price=3.37M },
            new Order{ id=3, Name="Hammer" ,Category="Hardwar",Price=16.99M }
        };
         public IEnumerable<Order> GetOrders()
        {
            return orders;


        }

    }
    public class ProductsController : ApiController
    {
        Product[] Products = new Product[]
        {
            new Product{ id=1, Name="Product1"  },
            new Product{ id=2, Name="Product2"  },
            new Product{id = 3, Name = "Product3"}
        };
        [HttpGet]
        public IEnumerable<Product> All()
        {
            return Products;
        }

    }
}
public class Product
{
    public int id { get; set; }
    public string Name { get; set; }
  
}
public class Order
{
    public int id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}