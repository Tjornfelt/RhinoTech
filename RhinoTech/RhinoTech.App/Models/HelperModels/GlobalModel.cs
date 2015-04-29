using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.HelperModels
{
    public class GlobalModel
    {
        public GlobalModel()
        {
            //Make sure the lists are never null when the class is instantiated.
            MainMenu = Enumerable.Empty<NavigationItem>();
            BreadCrumbs = Enumerable.Empty<NavigationItem>();
        }
        public IEnumerable<NavigationItem> MainMenu { get; set; }
        public IEnumerable<NavigationItem> BreadCrumbs { get; set; }
    }
}