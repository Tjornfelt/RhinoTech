using RhinoTech.App.Models.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RhinoTech.App.Models.ViewModels
{
    public class NewsSectionModel
    {
        public NewsSectionModel()
        {
            //Make sure the list is never null when the class is instantiated.
            NewsItems = Enumerable.Empty<NewsItemTeaser>();
        }

        public string Header { get; set; }
        public IHtmlString BodyText { get; set; }

        public IEnumerable<NewsItemTeaser> NewsItems { get; set; }
    }
}