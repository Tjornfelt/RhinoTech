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

namespace RhinoTech.App.Controllers.SurfaceControllers
{
    //http://24days.in/umbraco/2012/creating-a-login-form-with-umbraco-mvc-surfacecontroller/

    public class WarehouseSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {


        [HttpPost]
        [ActionName("ToggleDoor")]
        public JsonResult ToggleDoor(KeypadModel keypad) //Instansiere keypad som objekt til at hente "ID" og "Password" fra vores KeypadModel.
        {

            switch (keypad.Id) //Switch Case ud fra ID.
            {
                case "door-1":
                    return Json(new { door = "door-1", result = keypad.Password == WarehouseHelpers.Door1Password }); //Check for hardcoded password for Dør 1 i vores WarehouseHelper Model
                case "door-2":
                    return Json(new { door = "door-2", result = keypad.Password == WarehouseHelpers.Door2Password }); //Check for hardcoded password for Dør 2 i vores WarehouseHelper Model
                case "door-3":
                    return Json(new { door = "door-3", result = keypad.Password == WarehouseHelpers.Door3Password }); //Check for hardcoded password for Dør 3 i vores WarehouseHelper Model
                case "door-4":
                    return Json(new { door = "door-4", result = keypad.Password == WarehouseHelpers.Door4Password }); //Check for hardcoded password for Dør 4 i vores WarehouseHelper Model
                default:
                    return Json(false); // Hvis passwordet ikke matcher returnér false
            }

            /*
            Entities e = new Entities();

            //Add entry to log about user activity
            IMember member = SessionHelpers.GetCurrentMember(ApplicationContext.Services.MemberService);
            string logMessage = "Member updated product:" + "ID: " + p.ID + ", SKU: " + p.SKU + ", Name: " + p.Name + ", Price: " + p.Price + ", Type: " + p.Type + ", Description: " + p.Description + ", Shelf: " + p.Shelf + ", Amount: " + p.Amount;
            e.AddLogEntry(member.Name, DateTime.Now, LogHelpers.TypeUpdate, logMessage);*/

        }

    }
}