using RhinoTech.App.Models.HelperModels;
using RhinoTech.App.Models.ViewModels;
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
        public ActionResult EditProduct(EditProductModel form)
        {

            //form.Name

            //form.Price.Replace(',', '.');

            return PartialView("~/Views/EditProduct.cshtml");
        }
    }
}