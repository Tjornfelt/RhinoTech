﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.ViewModels
{
    public class FrontPageModel
    {
        public string Header { get; set; }
        public IHtmlString BodyText { get; set; }
    }
}