using RhinoTech.App.Classes.Cms;
using RhinoTech.App.Models.HelperModels;
using RhinoTech.App.Models.ViewModels;
using RhinoTech.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace RhinoTech.App.Controllers
{
    public class ProductManagementController : MasterController
    {
        public ActionResult ProductManagement(RenderModel renderModel)
        {
            ProductManagementModel model = new ProductManagementModel()
            {
                Products = GetProducts(),
                EditProductPage = GetEditPage(),
                NewProductPage = GetNewProductPage()
            };

            return View(model);
        }

        private NavigationItem GetNewProductPage()
        {
            var editNode = CurrentPage.Children.FirstOrDefault(x => x.DocumentTypeAlias == DocTypes.NewProduct);

            if (editNode != null)
            {
                return new NavigationItem()
                {
                    Name = editNode.Name,
                    Url = editNode.Url
                };
            }
            return null;
        }

        private NavigationItem GetEditPage()
        {
            var editNode = CurrentPage.Children.FirstOrDefault(x => x.DocumentTypeAlias == DocTypes.EditProduct);

            if (editNode != null)
            {
                return new NavigationItem()
                {
                    Name = editNode.Name,
                    Url = editNode.Url
                };
            }
            return null;
        }

        private IEnumerable<ManagementProduct> GetProducts()
        {
            Entities entities = new Entities();

            var dbProducts = entities.GetProducts().ToList();

            foreach (var dbProduct in dbProducts)
            {
                yield return new ManagementProduct()
                {
                    ID = dbProduct.ID,
                    SKU = dbProduct.SKU,
                    Name = dbProduct.Name,
                    Price = dbProduct.Price.ToString(),
                    Description = dbProduct.Description,
                    Discontinued = dbProduct.Discontinued,
                    Type = dbProduct.Type,
                    Shelf = entities.GetShelfByProductID(dbProduct.ID)
                };
            }

        }
    }
}