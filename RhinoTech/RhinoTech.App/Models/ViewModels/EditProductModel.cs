using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RhinoTech.Core;
using RhinoTech.App.Models.HelperModels;
using System.ComponentModel.DataAnnotations;

namespace RhinoTech.App.Models.ViewModels
{
    public class EditProductModel : ManagementProduct
    {
        public string Header { get; set; }
    }
}