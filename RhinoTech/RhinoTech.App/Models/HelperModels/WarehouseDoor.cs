using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.HelperModels
{
    public class WarehouseDoor
    {
        public string Name { get; set; }
        public KeypadModel KeypadForm { get; set; } //KeypadForm indeholder nu både password og ID fra vores KeypadModel.
    }
}