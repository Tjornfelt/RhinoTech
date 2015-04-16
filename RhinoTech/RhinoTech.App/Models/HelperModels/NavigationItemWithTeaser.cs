using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.HelperModels
{
    public class NavigationItemWithTeaser : NavigationItem
    {
        public string Header { get; set; }
        public string ShortDescription { get; set; }
    }
}