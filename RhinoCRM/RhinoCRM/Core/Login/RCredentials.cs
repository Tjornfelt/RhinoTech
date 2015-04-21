using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoCRM.Core.Login
{      

   internal class RCredentials
    {   
       internal enum securitytoken
       {
           isWorker,
           isSales,
           isAdmin,
           isNoOne
       }
        public RCredentials(string Usr, string Pswrd,securitytoken secure)
        {
            Username = Usr;
            Password = Pswrd;
            SecurityToken = secure;
        }
        internal securitytoken SecurityToken { get; set; }
        internal string Username { get; set; }
        [Obsolete("Should be incrypted")]
        internal string Password { get; set; }
        // ------------------------------------
        // Test Code to get Grupes for a user.
        // --------------------------------------
        //internal List<string> GetGroupNames()
        //{
        //    var pc = new PrincipalContext(ContextType.Domain);
        //    var src = UserPrincipal.FindByIdentity(pc, Username).GetGroups(pc);
        //    var result = new List<string>();
        //    src.ToList().ForEach(sr => result.Add(sr.SamAccountName));
        //    return result;
        //}
    }
}
