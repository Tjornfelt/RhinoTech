using RhinoTech.App.Classes.Cms;
using RhinoTech.App.Models.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web;
using Umbraco.Core.Models;

namespace RhinoTech.App.Classes.Helpers
{
    public static class NewsItemHelpers
    {
        public static IEnumerable<NewsItemTeaser> GetNewsItems(IPublishedContent CurrentPage)
        {
            var frontPage = CurrentPage.AncestorOrSelf(1);

            var newsSection = frontPage.Children.FirstOrDefault(x => x.IsDocumentType(DocTypes.NewsSection));

            if (newsSection != null)
            {
                var newsItems = newsSection.Children.Where(x => x.DocumentTypeAlias == DocTypes.NewsItem);

                if (newsItems != null && newsItems.Any())

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