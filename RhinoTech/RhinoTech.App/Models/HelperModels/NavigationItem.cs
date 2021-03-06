﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.HelperModels
{
    public class NavigationItem
    {
        public int NodeID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool Active { get; set; }
        public IEnumerable<NavigationItem> Children { get; set; }
    }
}