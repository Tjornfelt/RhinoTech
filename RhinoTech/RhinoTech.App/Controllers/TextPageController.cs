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
    public class TextPageController : MasterController
    {

        public ActionResult TextPage(RenderModel renderModel)
        {
            TextPageModel model = new TextPageModel()
            {
                Header = CurrentPage.GetPropertyValue(DocTypes.TextPage.Header),
                BodyText = CurrentPage.GetGridHtml(DocTypes.TextPage.BodyText.Alias),
            };

            return View(model);
        }
    }
}