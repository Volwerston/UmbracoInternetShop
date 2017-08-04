using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetShop.Models
{
    public class BasketEntry
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public double DiscountPercents { get; set; }
        public string Name { get; set; }
        public int Items { get; set; }
        public List<Property> Properties { get; set; }
    }
}