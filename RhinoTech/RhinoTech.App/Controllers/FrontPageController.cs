using RhinoTech.App.Classes.Cms;
using RhinoTech.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace RhinoTech.App.Controllers
{
    public class FrontPageController : MasterController
    {
        //
        // GET: /FrontPage/

        public ActionResult FrontPage(RenderModel renderModel)
        {
            FrontPageModel model = new FrontPageModel()
            {
                Header = CurrentPage.GetPropertyValue(DocTypes.Frontpage.Header),
                BodyText = CurrentPage.GetPropertyValue(DocTypes.Frontpage.BodyText),
            };

            return View(model);
        }
    }
}