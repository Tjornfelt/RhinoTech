using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;

namespace RhinoTech.App.Classes.Helpers
{
    public static class SessionHelpers
    {
        /// <summary>
        /// Gets the current logged in umbraco member. The memberService can be created in an umbraco controller context
        /// </summary>
        /// <param name="memberService"></param>
        /// <returns></returns>
        public static IMember GetCurrentMember(IMemberService memberService)
        {
            //Add entry to log about user activity
            MembershipUser currentUser = Membership.GetUser();

            var username = currentUser.UserName;
            return memberService.GetByUsername(username);


        }
    }
}