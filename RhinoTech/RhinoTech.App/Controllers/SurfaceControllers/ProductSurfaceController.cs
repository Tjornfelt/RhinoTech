using RhinoTech.App.Models.HelperModels;
using RhinoTech.App.Models.ViewModels;
using RhinoTech.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace RhinoTech.App.Controllers.SurfaceControllers
{
    //http://24days.in/umbraco/2012/creating-a-login-form-with-umbraco-mvc-surfacecontroller/

    public class ProductSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        /*
        [HttpGet]
        [ActionName("EditProduct")]
        public ActionResult EditProduct(int id)
        {
            return PartialView("~/Views/EditProduct.cshtml");
        }*/

        [HttpPost]
        [ActionName("EditProduct")]
        public JsonResult EditProduct(ManagementProduct p)
        {
            try
            {
                List<WarehouseShelf> shelves = new List<WarehouseShelf>();

                shelves.Add(new WarehouseShelf()
                {
                    Amount = p.Amount,
                    Shelf = p.Shelf
                });

                Product edittedProduct = new Product()
                {
                    ID = p.ID,
                    Name = p.Name,
                    SKU = p.SKU,
                    Type = p.Type,
                    Description = p.Description,
                    WarehouseShelfs = shelves
                };

                edittedProduct.Price = Double.Parse(p.Price.Replace('.', ','));


                Entities e = new Entities();

                e.UpdateProduct(edittedProduct);

                return Json(true);
            }
            catch(Exception)
            {
                return Json(false);
            }
        }

        [HttpPost]
        [ActionName("DeleteProduct")]
        public ActionResult DeleteProduct(int ID)
        {

            return PartialView("~/Views/EditProduct.cshtml");
        }

        [HttpPost]
        [ActionName("NewProduct")]
        public JsonResult NewProduct(ManagementProduct p)
        {
            try
            {
                // Products always have exactly one shelf entity associated with it in order to distinguish amount.
                // The shelf identifier (not the pk) is allowed to be the same as another row, since multiple products can occupy the same shelf space.

                List<WarehouseShelf> shelves = new List<WarehouseShelf>();

                shelves.Add(new WarehouseShelf()
                {
                    Amount = p.Amount,
                    Shelf = p.Shelf
                });

                Product newProduct = new Product()
                {
                    Name = p.Name,
                    SKU = p.SKU,
                    Type = p.Type,
                    Description = p.Description,
                    WarehouseShelfs = shelves
                };

                newProduct.Price = Double.Parse(p.Price.Replace('.', ','));


                Entities e = new Entities();

                e.UpdateProduct(newProduct);

                return Json(true);
            }
            catch (Exception)
            {
                return Json(false);
            }
        }
    }
}