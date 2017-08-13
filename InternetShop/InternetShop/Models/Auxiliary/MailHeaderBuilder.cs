using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace InternetShop.Models.Auxiliary
{
    public class MailHeaderBuilder : IBuilder<string, MailContext>
    {
        public MailContext Context { get; set; }

        public string Build()
        {
            StringBuilder toReturn = new StringBuilder();

            toReturn.Append(string.Format("Dear {0} {1}, <br/>", Context.Name, Context.Surname));
            toReturn.Append("Here is the list of your orders: <br/>");

            return toReturn.ToString();
        }
    }
}