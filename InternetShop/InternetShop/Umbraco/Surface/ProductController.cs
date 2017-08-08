using InternetShop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;

namespace InternetShop.Umbraco.Surface
{
    public class ProductController : SurfaceController
    {
        [HttpPost]
        public ActionResult Search(ProductSearchOptions selectedItems)
        {
            try
            {
                if (selectedItems.Name == null) selectedItems.Name = "";
                if (selectedItems.Properties == null) selectedItems.Properties = new List<Models.Property>();

                var category = ApplicationContext.Services.ContentService.GetById(selectedItems.CategoryId);
                var products = category.Children();
                List<int> ids = new List<int>();

                foreach (var product in products)
                {
                    bool ok = true;

                    if (!string.IsNullOrEmpty(selectedItems.Name.Trim()) && !product.Name.Trim().ToLower().Contains(selectedItems.Name.Trim().ToLower()))
                    {
                        continue;
                    }

                    dynamic res = JsonConvert.DeserializeObject((string)product.Properties["propertiesValues"].Value);

                    for (int i = 0; i < selectedItems.Properties.Count; ++i)
                    {
                        dynamic currRow = res.cells.First;

                        while (currRow != null)
                        {
                            if (currRow.First.value == selectedItems.Properties[i].Name)
                            {
                                foreach (var propValue in selectedItems.Properties[i].Values)
                                {
                                    int counter = 1;
                                    while (ok && currRow[counter] != null)
                                    {
                                        if (currRow[counter].value == propValue)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            if (currRow[++counter] == null || currRow[counter].value == "") ok = false;
                                        }
                                    }

                                    if (!ok) break;
                                }

                                break;
                            }
                            else
                            {
                                if (currRow.Next == null) ok = false;
                                currRow = currRow.Next;
                            }
                        }

                        if (!ok) break;
                    }

                    if (ok)
                    {
                        ids.Add(product.Id);
                    }
                }

                return PartialView("Partials/ProductList", ids);
            }
            catch
            {
                return PartialView("Partials/ProductList", new List<int>());
            }
        }
    }
}