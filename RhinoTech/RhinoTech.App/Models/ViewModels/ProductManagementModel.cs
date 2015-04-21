using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RhinoTech.Core;
using RhinoTech.App.Models.HelperModels;

namespace RhinoTech.App.Models.ViewModels
{
    public class ProductManagementModel
    {
        public IEnumerable<ManagementProduct> Products { get; set; }
        public NavigationItem EditProductPage { get; set; }
        public NavigationItem NewProductPage { get; set; }
    }
}