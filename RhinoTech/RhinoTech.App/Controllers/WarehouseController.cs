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

namespace RhinoTech.App.Controllers
{
    public class WarehouseController : MasterController
    {
        //
        // GET: /FrontPage/

        public ActionResult Warehouse()
        {
            WarehouseModel model = new WarehouseModel()
            {
                WarehouseDoors = GetWarehouseDoors()
                //KeypadModel  = new Models.HelperModels.KeypadModel()
            };

            return View(model);
        }

        private IEnumerable<WarehouseDoor> GetWarehouseDoors()
        {
            int i = 0;
            while (i < 4) //loop så længe i er under 4 (0,1,2,3)
	        {
                string id = string.Empty;
                string password = string.Empty;
                string name = string.Empty;
                if (i == 0)
                {
                    name = "Storage 1 Door";    //assign name baseret på loop.
                    id = "door-1";      //assign id baseret på loop.
                }
                else if (i == 1)
                {
                    name = "Storage 2 Door";
                    id = "door-2";
                }
                else if (i == 2)
                {
                    name = "Office Door";
                    id = "door-3";
                }
                else if (i == 3)
                {
                    name = "Accessories Door";
                    id = "door-4";
                }

                i++; 

                yield return new WarehouseDoor()
                {
                    KeypadForm = new KeypadModel()
                    {
                        Id = id
                    },
                    Name = name
                };
	        }
        }
    }
}