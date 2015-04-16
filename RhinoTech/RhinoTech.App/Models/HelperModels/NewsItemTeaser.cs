using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.HelperModels
{
    public class NewsItemTeaser
    {
        public string Header { get; set; }
        public DateTime Date { get; set; }
        public string ShortDescription { get; set; }
        public string Url { get; set; }
    }
}