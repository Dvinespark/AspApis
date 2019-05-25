using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dvinespark.Models;

namespace Dvinespark.Controllers
{
    public static class MyExtensionMethod
    {
        public static int SumIds(this ShoppingCart shoppingCart)
        {
            var result = 0;
            foreach(Product product in shoppingCart.Products)
            {
                result += product.Id;
            }
            return result;
        }
    }
}