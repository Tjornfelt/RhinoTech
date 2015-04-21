using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.HelperModels
{
    public class GlobalModel
    {
        public IEnumerable<NavigationItem> MainMenu { get; set; }
        public IEnumerable<NavigationItem> BreadCrumbs { get; set; }
    }
}