using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetShop.Models
{
    public class BasketEntry
    {
        public string Name { get; set; }
        public int Items { get; set; }
        public List<Property> Properties { get; set; }
    }
}