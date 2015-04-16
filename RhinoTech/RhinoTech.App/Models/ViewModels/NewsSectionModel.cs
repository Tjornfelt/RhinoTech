using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.ViewModels
{
    public class NewsSectionModel
    {
        public string Header { get; set; }
        public IHtmlString BodyText { get; set; }

        public IEnumerable<HelperModels.NewsItemTeaser> NewsItems { get; set; }
    }
}