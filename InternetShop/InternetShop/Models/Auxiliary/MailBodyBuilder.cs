using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace InternetShop.Models.Auxiliary
{
    public class MailBodyBuilder : IBuilder<string, MailContext>
    {
        public MailContext Context { get; set; }

        public string Build()
        {
            StringBuilder toReturn = new StringBuilder();

            foreach(var entry in Context.Entries)
            {
                toReturn.Append("<div style='border: 1px solid black; width: 100%;'>");
                toReturn.Append(string.Format("<h3 style='text-align: center'>{0}</h3>", entry.Name));
                
                foreach(var property in entry.Properties)
                {
                    toReturn.Append(string.Format("<p style='text-align: center'><b>{0} :</b>{1}</p>", property.Name, property.Values[0]));
                }

                toReturn.Append(string.Format("<br/><p style='text-align: center'><b>Price :</b> {0} $ </p>", entry.Items*entry.Price*(1 - entry.DiscountPercents/100)));
                toReturn.Append("<br/></div>");
            }

            return toReturn.ToString();
        }
    }
}