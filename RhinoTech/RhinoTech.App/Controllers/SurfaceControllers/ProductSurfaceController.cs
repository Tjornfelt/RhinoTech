using RhinoTech.App.Classes.Helpers;
using RhinoTech.App.Models.HelperModels;
using RhinoTech.App.Models.ViewModels;
using RhinoTech.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Core.Models;
using Umbraco.Core.Services;

namespace RhinoTech.App.Controllers.SurfaceControllers
{

    public class ProductSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        [HttpPost]
        [ActionName("EditProduct")]
        public JsonResult EditProduct(ManagementProduct p)
        {
            try
            {
                List<WarehouseShelf> shelves = new List<WarehouseShelf>();

                shelves.Add(new WarehouseShelf()
                {
                    Amount = p.Amount,
                    Shelf = p.Shelf
                });

                Product edittedProduct = new Product()
                {
                    ID = p.ID,
                    Name = p.Name,
                    SKU = p.SKU,
                    Type = p.Type,
                    Description = p.Description,
                    WarehouseShelfs = shelves
                };

                edittedProduct.Price = Double.Parse(p.Price.Replace('.', ','));

                Entities e = new Entities();

                e.UpdateProduct(edittedProduct);

                //Add entry to log about user activity
                IMember member = SessionHelpers.GetCurrentMember(ApplicationContext.Services.MemberService);
                string logMessage = "Member updated product:" + "ID: " + p.ID + ", SKU: " + p.SKU + ", Name: " + p.Name + ", Price: " + p.Price + ", Type: " + p.Type + ", Description: " + p.Description + ", Shelf: " + p.Shelf + ", Amount: " + p.Amount;
                e.AddLogEntry(member.Name, DateTime.Now, LogHelpers.TypeUpdate, logMessage);

                return Json(true);
            }
            catch(Exception)
            {
                return Json(false);
            }
        }

        [HttpPost]
        [ActionName("DeleteProduct")]
        public JsonResult DeleteProduct(int ID)
        {
            Entities e = new Entities();

            var result = e.DeleteProduct(ID);

            if (result)
            {
                //Add entry to log about user activity
                IMember member = SessionHelpers.GetCurrentMember(ApplicationContext.Services.MemberService);
                string logMessage = "Member marked product as discontinued, ProductID: " + ID;
                e.AddLogEntry(member.Name, DateTime.Now, LogHelpers.TypeDelete, logMessage);
                return Json(true);
            }
            return Json(false);
        }

        [HttpPost]
        [ActionName("EnableProduct")]
        public JsonResult EnableProduct(int ID)
        {
            Entities e = new Entities();

            var result = e.EnableProduct(ID);

            if (result)
            {
                //Add entry to log about user activity
                IMember member = SessionHelpers.GetCurrentMember(ApplicationContext.Services.MemberService);
                string logMessage = "Member re-enabled product to active state, ProductID: " + ID;
                e.AddLogEntry(member.Name, DateTime.Now, LogHelpers.TypeUpdate, logMessage);
                return Json(true);
            }

            return Json(false);
        }

        [HttpPost]
        [ActionName("NewProduct")]
        public JsonResult NewProduct(ManagementProduct p)
        {
            try
            {
                // Products always have exactly one shelf entity associated with it in order to distinguish amount.
                // The shelf identifier (not the pk) is allowed to be the same as another row, since multiple products can occupy the same shelf space.

                List<WarehouseShelf> shelves = new List<WarehouseShelf>();

                shelves.Add(new WarehouseShelf()
                {
                    Amount = p.Amount,
                    Shelf = p.Shelf
                });

                Product newProduct = new Product()
                {
                    Name = p.Name,
                    SKU = p.SKU,
                    Type = p.Type,
                    Description = p.Description,
                    WarehouseShelfs = shelves
                };

                newProduct.Price = Double.Parse(p.Price.Replace('.', ','));

                Entities e = new Entities();

                e.CreateProduct(newProduct);

                //Add entry to log about user activity
                IMember member = SessionHelpers.GetCurrentMember(ApplicationContext.Services.MemberService);
                string logMessage = "Member created a new product:" + "ID: " + p.ID + ", SKU: " + p.SKU + ", Name: " + p.Name + ", Price: " + p.Price + ", Type: " + p.Type + ", Description: " + p.Description + ", Shelf: " + p.Shelf + ", Amount: " + p.Amount;
                e.AddLogEntry(member.Name, DateTime.Now, LogHelpers.TypeCreate, logMessage);

                return Json(true);
            }
            catch (Exception)
            {
                return Json(false);
            }
        }
    }
}