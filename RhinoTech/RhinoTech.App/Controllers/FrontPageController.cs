using RhinoTech.App.Classes.Cms;
using RhinoTech.App.Classes.Helpers;
using RhinoTech.App.Models.HelperModels;
using RhinoTech.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Models;
using RhinoTech.Core;

namespace RhinoTech.App.Controllers
{
    public class FrontPageController : MasterController
    {
        public ActionResult FrontPage()
        {
            FrontPageModel model = new FrontPageModel()
            {
                Header = CurrentPage.GetPropertyValue(DocTypes.Frontpage.Header),
                BodyText = CurrentPage.GetPropertyValue(DocTypes.Frontpage.BodyText),
                NewsItems = NewsItemHelpers.GetNewsItems(CurrentPage)
            };

            return View(model);
        }
    }
}