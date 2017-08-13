using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace InternetShop.Models.Auxiliary
{
    public class MailFooterBuilder : IBuilder<string, MailContext>
    {
        public MailContext Context { get; set; }

        public string Build()
        {
            StringBuilder toReturn = new StringBuilder();

            double overallPrice = Context.Entries.Select(x => x.Items * x.Price * (1 - x.DiscountPercents / 100)).Aggregate((a, b) => a + b);

            toReturn.Append(string.Format("<h3 style='text-align: center'><b>Overall price: </b> {0} $ </h3> <br/>", Math.Round(overallPrice, 2)));
            toReturn.Append(string.Format("<p>Your products will be soon delivered to {0},{1} </p><br/>", Context.Town, Context.Country));
            toReturn.Append("Kind regards, <br/> Internet Shop");

            return toReturn.ToString();
        }
    }
}