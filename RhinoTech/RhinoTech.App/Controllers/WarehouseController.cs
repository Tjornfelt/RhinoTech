﻿using RhinoTech.App.Classes.Cms;
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
    public class WarehouseController : MasterController
    {
        //
        // GET: /FrontPage/

        public ActionResult Warehouse(RenderModel renderModel)
        {


            return View(renderModel);
        }
    }
}