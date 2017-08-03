using InternetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace InternetShop.Umbraco.Api
{
    public class BasketController : SurfaceController
    {
        [HttpPost]
        public string AddProductToBasket(BasketEntry entry)
        {
            try
            {
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

                return "OK";
            }
            catch
            {
                return "OK";
            }
        }
    }
}