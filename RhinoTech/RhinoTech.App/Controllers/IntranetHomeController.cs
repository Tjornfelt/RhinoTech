using RhinoTech.App.Classes.Cms;
using RhinoTech.App.Mappers;
using RhinoTech.App.Models.HelperModels;
using RhinoTech.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace RhinoTech.App.Controllers
{
    public class IntranetHomeController : MasterController
    {

        public ActionResult IntranetHome(RenderModel renderModel)
        {
            IntranetHomeModel model = new IntranetHomeModel()
            {
                Header = CurrentPage.GetPropertyValue(DocTypes.IntranetHome.Header),
                BodyText = CurrentPage.GetPropertyValue(DocTypes.IntranetHome.BodyText),
                Sections = GetSections() 
            };
            return View(model);
        }

        private IEnumerable<NavigationItemWithTeaser> GetSections()
        {
            IEnumerable<NavigationItem> sections = NavigationItemMapper.Map<NavigationItem>(CurrentPage, CurrentPage);

            if (sections != null && sections.Any())
            {
                //Enrich the sections with header and short description - they are not mapped in the navigation item mapper, but added as an extension for the model
                foreach (var item in sections)
                {
                    var page = Umbraco.TypedContent(item.NodeID);

                    yield return new NavigationItemWithTeaser()
                    {
                        Active = item.Active,
                        Children = item.Children,
                        Header = page.GetPropertyValue<string>("header"),
                        Name = item.Name,
                        NodeID = item.NodeID,
                        ShortDescription = page.GetPropertyValue<string>("shortDescription"),
                        Url = item.Url
                    };
                }
            }
        }
    }
}