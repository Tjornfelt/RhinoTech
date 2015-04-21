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


    /// <summary>
    /// Not used anyway...keeping it in case i need functionality not thought of...
    /// </summary>
    public class EditProductSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        [HttpGet]
        [ActionName("EditProduct")]
        public ActionResult EditProduct(int id)
        {
            return PartialView("~/Views/EditProduct.cshtml");
        }

        [HttpPost]
        [ActionName("EditProduct")]
        public JsonResult EditProduct(EditProductModel p)
        {
            try
            {
                List<WarehouseShelfs> shelves = new List<WarehouseShelfs>();

                shelves.Add(new WarehouseShelfs()
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
    }
}