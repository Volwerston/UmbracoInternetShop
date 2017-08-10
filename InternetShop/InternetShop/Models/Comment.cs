using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetShop.Models
{
    public class Comment
    {
        public string MessageText { get; set; }
        public string Advantages { set; get; }
        public string Disadvantages { get; set; }
        public int Estimate { set; get; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public int ProductId { get; set; }
    }
}