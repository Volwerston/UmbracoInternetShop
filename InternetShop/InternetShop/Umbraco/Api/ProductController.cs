using InternetShop.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Http;
using umbraco.NodeFactory;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web;
using Umbraco.Web.WebApi;

namespace InternetShop.Umbraco.Api
{
    public class ProductController : UmbracoApiController
    {
        [HttpPost]
        public IHttpActionResult Search([FromBody]ProductSearchOptions selectedItems)
        {
            try
            {
                var category = ApplicationContext.Services.ContentService.GetById(selectedItems.CategoryId);
                var products = category.Children();
                List<int> ids = new List<int>();

                foreach (var product in products)
                {
                    bool ok = true;

                    if(!string.IsNullOrEmpty(selectedItems.Name.Trim()) && !product.Name.Trim().ToLower().Contains(selectedItems.Name.Trim().ToLower()))
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

                return Ok(ids);
            }
            catch
            {
                return InternalServerError();
            }
        }

        [HttpGet]
        public string SayHello()
        {
            return "Hello World";
        }
    }
}
