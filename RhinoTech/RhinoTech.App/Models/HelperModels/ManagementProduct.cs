using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.HelperModels
{
    public class ManagementProduct
    {
        public int ID { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool Discontinued { get; set; }
        public string Shelf { get; set; }
        public int Amount { get; set; }
    }
}