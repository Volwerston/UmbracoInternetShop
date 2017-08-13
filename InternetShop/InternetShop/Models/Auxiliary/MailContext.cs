using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetShop.Models.Auxiliary
{
    public class MailContext
    {
        public List<BasketEntry> Entries { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Town { get; set; }
    }
}