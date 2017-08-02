using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetShop.Models
{
    public class ProductSearchOptions
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Property> Properties { get; set; }
    }
}