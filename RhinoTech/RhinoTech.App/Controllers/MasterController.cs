using RhinoTech.App.Mappers;
using RhinoTech.App.Models.HelperModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;


namespace RhinoTech.App.Controllers
{
    public class MasterController : RenderMvcController
    {
        protected override ViewResult View(string viewName, string masterName, object model)
        {
            //Set APP culture, for number formats and such.
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");


            IPublishedContent frontPage = CurrentPage.AncestorOrSelf(1);

            ViewBag.Global = new GlobalModel
            {
                MainMenu = NavigationItemMapper.Map<NavigationItem>(frontPage, CurrentPage)
            };


            return base.View(viewName, masterName, model);
        }
    }
}