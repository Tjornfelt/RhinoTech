﻿using RhinoTech.App.Classes.Cms;
using RhinoTech.App.Models.HelperModels;
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
    public class ContactPageController : MasterController
    {
        //
        // GET: /FrontPage/

        public ActionResult ContactPage(RenderModel renderModel)
        {
            ContactPageModel model = new ContactPageModel()
            {
                Header = CurrentPage.GetPropertyValue(DocTypes.ContactPage.Header),
                BodyText = CurrentPage.GetPropertyValue(DocTypes.ContactPage.BodyText),
                ContactForm = new ContactFormModel()
            };
            model.ContactForm.ID = CurrentPage.Id.ToString();
            model.ContactForm.ThanksText = "Besked afsendt. Vi vender tilbage snarest muligt.";

            return View(model);
        }
    }
}