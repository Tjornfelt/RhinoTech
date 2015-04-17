using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.ViewModels
{
    public class NewsItemModel
    {
        public string Header { get; set; }
        public DateTime Date { get; set; }
        public IHtmlString BodyText { get; set; }
    }
}