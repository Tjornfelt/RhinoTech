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
    public class NewsItemController : MasterController
    {

        public ActionResult NewsItem(RenderModel renderModel)
        {
            NewsItemModel model = new NewsItemModel()
            {
                Header = CurrentPage.GetPropertyValue(DocTypes.NewsItem.Header),
                BodyText = CurrentPage.GetGridHtml(DocTypes.NewsItem.BodyText.Alias),
                Date = CurrentPage.GetPropertyValue(DocTypes.NewsItem.Date)
            };

            return View(model);
        }
    }
}