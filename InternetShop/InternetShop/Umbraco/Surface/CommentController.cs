using InternetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace InternetShop.Umbraco.Surface
{
    public class CommentController : SurfaceController
    {
        [HttpPost]
        public ActionResult Add(Comment c)
        {
            var newComment = Services.ContentService.CreateContent(c.SenderEmail + "_" + DateTime.Now.ToUniversalTime().ToString(), c.ProductId, "Comment");

            if (c.Disadvantages == null) c.Disadvantages = "";
            if (c.Advantages == null) c.Disadvantages = "";
            newComment.SetValue("addingTime", DateTime.Now);
            newComment.SetValue("messageText", c.MessageText);
            newComment.SetValue("advantages", c.Advantages);
            newComment.SetValue("disadvantages", c.Disadvantages);
            newComment.SetValue("estimate", c.Estimate);
            newComment.SetValue("senderEmail", c.SenderEmail);
            newComment.SetValue("senderName", c.SenderName);

            Services.ContentService.SaveAndPublishWithStatus(newComment);

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [HttpGet]
        public ActionResult Hello()
        {
            return new EmptyResult();
        }
    }
}