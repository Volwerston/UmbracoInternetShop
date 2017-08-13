using InternetShop.Models;
using InternetShop.Models.Auxiliary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace InternetShop.Umbraco.Api
{
    public class BasketController : SurfaceController
    {
        [HttpPost]
        public ActionResult Purchase(MailContext c)
        {
            try
            {
                List<BasketEntry> entries = Session["basket"] as List<BasketEntry>;

                if(entries == null)
                {
                    throw new Exception("Session has expired");
                }
                else if(entries.Count() == 0)
                {
                    throw new Exception("No items in the basket were found");
                }

                c.Entries = entries;

                List<IBuilder<string, MailContext>> builders = new List<IBuilder<string, MailContext>>()
                {
                     new MailHeaderBuilder()
                     {
                          Context = c
                     },
                     new MailBodyBuilder()
                     {
                         Context = c
                     },
                     new MailFooterBuilder()
                     {
                         Context = c
                     }
                };

                IDirector<string, MailContext> director = new MailDirector(builders);

                director.Act();

                Session["basket"] = null;

                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            catch(Exception e)
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        public string GetBasketEntries()
        {
            List<BasketEntry> entries = Session["basket"] as List<BasketEntry>;
            List<string> productImgsBase64 = new List<string>();
            List<Tuple<string, BasketEntry>> toReturn = new List<Tuple<string, BasketEntry>>();

            if(entries == null)
            {
                entries = new List<BasketEntry>();
            }
            else
            {
                foreach(var entry in entries)
                {
                    var umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
                    IPublishedContent content = umbracoHelper.TypedContent(entry.Id);
                    var carouselItem = content.GetPropertyValue<IEnumerable<IPublishedContent>>("carousel").FirstOrDefault();
                    StringBuilder img64Holder = new StringBuilder();
                    if(carouselItem != null)
                    {
                        img64Holder.Append(carouselItem.GetPropertyValue<IPublishedContent>("image").Url);
                    }

                    toReturn.Add(new Tuple<string, BasketEntry>(img64Holder.ToString(), entry));
                }
            }

            return JsonConvert.SerializeObject(toReturn);
        }

        [HttpPost]
        public ActionResult PostToServer(List<BasketEntry> entries)
        {
            try
            {
                Session["basket"] = entries;
                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }
        }


        [HttpPost]
        public ActionResult AddProductToBasket(BasketEntry entry)
        {
            try
            {
                entry.Price = new UmbracoHelper(UmbracoContext.Current).TypedContent(entry.Id).GetPropertyValue<double>("price");
                entry.DiscountPercents = new UmbracoHelper(UmbracoContext.Current).TypedContent(entry.Id).GetPropertyValue<int>("discount");

                List<BasketEntry> entries = Session["basket"] as List<BasketEntry>;
                if (entries == null)
                {
                    Session["basket"] = new List<BasketEntry>() { entry };
                }
                else
                {
                    bool found = false;

                    var comp = entries.Where(x => x.Name == entry.Name);

                    foreach (var pr in comp)
                    {

                        bool suitable = true;

                        if (pr.Properties.Count() != entry.Properties.Count())
                        {
                            suitable = false;
                        }

                        if (suitable)
                        {
                            var entryProp = entry.Properties.OrderBy(x => x.Name).ToList();
                            var currProp = pr.Properties.OrderBy(x => x.Name).ToList();

                            for (int i = 0; i < entryProp.Count(); ++i)
                            {
                                if (entryProp[i].Name != currProp[i].Name || entryProp[i].Values[0] != currProp[i].Values[0])
                                {
                                    suitable = false;
                                    break;
                                }
                            }
                        }

                        if (suitable)
                        {
                            found = true;
                            pr.Items += entry.Items;
                            break;
                        }
                    }


                    if (!found)
                    {
                        entries.Add(entry);
                    }

                    Session["basket"] = entries;
                }

                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }
        }
    }
}