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
    public class NewProductController : MasterController
    {
        public ActionResult NewProduct()
        {
            NewProductModel model = new NewProductModel()
            {
                Header = "Create a new product"
            };

            return View(model);
        }
    }
}