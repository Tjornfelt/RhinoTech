using RhinoTech.App.Models.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace RhinoTech.App.Controllers.SurfaceControllers
{
    //http://24days.in/umbraco/2012/creating-a-login-form-with-umbraco-mvc-surfacecontroller/

    public class MemberLoginSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        [HttpGet]
        [ActionName("MemberLogin")]
        public ActionResult MemberLoginGet()
        {
            return PartialView("_LoginForm", new MemberLoginModel());
        }

        [HttpPost]
        [ActionName("MemberLogin")]
        public JsonResult MemberLoginPost(MemberLoginModel model)
        {
            if (Membership.ValidateUser(model.Username, model.Password))
            {
                FormsAuthentication.SetAuthCookie(model.Username, model.RememberMe);
                return Json(true); //member is authenticated

            }
            else
            {
                return Json(false); //failed to authenticate member
            }
        }

        [HttpGet]
        public ActionResult MemberLogout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return Redirect("/");
        }
    }
}