using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RhinoTech.App.Models.HelperModels;

namespace RhinoTech.App.Models.ViewModels
{
    public class WarehouseModel
    {
        public IEnumerable<WarehouseDoor> WarehouseDoors { get; set; } //Liste med døre fra vores WarehouseDoorModel ligges i WarehourseDoors
    }
}