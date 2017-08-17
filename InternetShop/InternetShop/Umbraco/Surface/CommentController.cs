using InternetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace InternetShop.Umbraco.Surface
{
    public class CommentController : SurfaceController
    {
        [HttpPost]
        public ActionResult Add(Comment c)
        {
            try
            {
                var newComment = Services.ContentService.CreateContent(c.SenderEmail + "_" + DateTime.Now.ToUniversalTime().ToString(), c.ProductId, "Comment");

                if(c.Advantages != null)
                {
                    var umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
                    int count = umbracoHelper.TypedContent(c.ProductId).Children().Where(z => !string.IsNullOrEmpty(z.GetPropertyValue<string>("advantages"))).Select(x => x.GetPropertyValue<string>("senderEmail")).Where(y => y == c.SenderEmail).Count();

                    if(count != 0)
                    {
                        throw new Exception("You have already estimated this product");
                    }
                }

                if (c.Disadvantages == null) c.Disadvantages = "";
                if (c.Advantages == null) c.Disadvantages = "";
                newComment.SetValue("addingTime", DateTime.Now);
                newComment.SetValue("messageText", c.MessageText);
                newComment.SetValue("advantages", c.Advantages);
                newComment.SetValue("disadvantages", c.Disadvantages);
                newComment.SetValue("estimate", c.Estimate);
                newComment.SetValue("senderEmail", c.SenderEmail);
                newComment.SetValue("senderName", c.SenderName);

                System.Threading.Tasks.Task.Run(() => Services.ContentService.SaveAndPublishWithStatus(newComment));

                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}