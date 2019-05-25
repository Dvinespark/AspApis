using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dvinespark.Models;

namespace Dvinespark.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ShoppingCart shoppingCart = new ShoppingCart()
            {
                Products = new List<Product>()
                {
                    new Product
                    {
                        Id = 1,
                        Name = "Apple"
                    },
                    new Product
                    {
                        Id =3,
                        Name = "Banana"
                    }
                }
            };
            int result = shoppingCart.SumIds();
            return Content(result.ToString());
        }
    }
}