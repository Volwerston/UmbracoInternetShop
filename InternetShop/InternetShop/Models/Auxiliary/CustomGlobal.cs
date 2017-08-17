using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web;
using System.Threading.Tasks;

namespace InternetShop.Models.Auxiliary
{
    public class CustomGlobal : UmbracoApplication
    {
        protected void Session_End(object sender, EventArgs e)
        {
            List<BasketEntry> entries = Session["basket"] as List<BasketEntry>;

            if(entries != null)
            {
                var contentService = ApplicationContext.Current.Services.ContentService;

                foreach (var entry in entries)
                {
                    IContent content = contentService.GetById(entry.Id);
                    content.SetValue("inStock", content.GetValue<int>("inStock") + entry.Items);
                    System.Threading.Tasks.Task.Run(() => contentService.SaveAndPublishWithStatus(content));
                }
            }
        }
    }
}