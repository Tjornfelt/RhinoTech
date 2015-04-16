using RhinoTech.App.Models.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.ViewModels
{
    public class IntranetHomeModel
    {
        public string Header { get; set; }
        public IHtmlString BodyText { get; set; }
        public IEnumerable<NavigationItemWithTeaser> Sections { get; set; }
    }
}