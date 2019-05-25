using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dvinespark.Models
{
    public class ShoppingCart
    {
        public List<Product> Products { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}