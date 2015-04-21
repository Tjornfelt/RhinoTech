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
    public class EditProductController : MasterController
    {
        public ActionResult EditProduct(int id)
        {
            Entities entities = new Entities();

            var dbProduct = entities.GetProductByID(id);

            EditProductModel model = new EditProductModel() {
                Header = "Edit product",

                ID = dbProduct.ID,
                Name = dbProduct.Name,
                SKU = dbProduct.SKU,
                
                Price = dbProduct.Price.ToString(),
                Type = dbProduct.Type,
                Description = dbProduct.Description.Replace("\\r", Environment.NewLine),
                Discontinued = dbProduct.Discontinued,
                Shelf = entities.GetShelfByProductID(dbProduct.ID),
                Amount = entities.GetShelfAmountByProductID(dbProduct.ID)
            };

            return View(model);
        }
    }
}