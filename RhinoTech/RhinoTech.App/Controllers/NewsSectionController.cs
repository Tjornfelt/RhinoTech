using RhinoTech.App.Classes.Cms;
using RhinoTech.App.Classes.Helpers;
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
    public class NewsSectionController : MasterController
    {

        public ActionResult NewsSection()
        {
            NewsSectionModel model = new NewsSectionModel()
            {
                Header = CurrentPage.GetPropertyValue(DocTypes.NewsSection.Header),
                BodyText = CurrentPage.GetPropertyValue(DocTypes.NewsSection.BodyText),
                NewsItems = NewsItemHelpers.GetNewsItems(CurrentPage)
            };

            return View(model);
        }
    }
}