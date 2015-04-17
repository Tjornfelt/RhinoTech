using RhinoTech.App.Classes.Cms;
using RhinoTech.App.Classes.Helpers;
using RhinoTech.App.Models.HelperModels;
using RhinoTech.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Models;
using RhinoTech.Core;

namespace RhinoTech.App.Controllers
{
    public class FrontPageController : MasterController
    {
        //
        // GET: /FrontPage/

        public ActionResult FrontPage(RenderModel renderModel)
        {
            FrontPageModel model = new FrontPageModel()
            {
                Header = CurrentPage.GetPropertyValue(DocTypes.Frontpage.Header),
                BodyText = CurrentPage.GetPropertyValue(DocTypes.Frontpage.BodyText),
                NewsItems = NewsItemHelpers.GetNewsItems(CurrentPage)
            };
            Test();
            return View(model);
        }

        private void Test()
        {
            Entities entities = new Entities();

            entities.GetProducts();
        }

        [Obsolete("Use NewsItemHelpers.GetNewsItems(CurrentPage) instead")]
        private IEnumerable<NewsItemTeaser> GetNewsItems()
        {
            var newsSection = CurrentPage.Children.FirstOrDefault(x => x.IsDocumentType(DocTypes.NewsSection));

            if (newsSection != null)
            {
                var newsItems = newsSection.Children.Where(x => x.DocumentTypeAlias == DocTypes.NewsItem);

                if(newsItems != null && newsItems.Any())

                foreach (var item in newsItems)
                {
                    yield return new NewsItemTeaser()
                    {
                        Header = item.GetPropertyValue(DocTypes.NewsItem.Header),
                        Date = item.GetPropertyValue(DocTypes.NewsItem.Date),
                        ShortDescription = item.GetPropertyValue(DocTypes.NewsItem.ShortDescription),
                        Url = item.Url
                    };
                }
            }
        }
    }
}