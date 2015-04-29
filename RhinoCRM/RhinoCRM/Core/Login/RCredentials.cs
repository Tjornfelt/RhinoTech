using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhinoCRM.Core.Login
{

    public class RCredentials
    {
        public enum securitytoken
        {
            isWorker,
            isSales,
            isAdmin
        }
        public RCredentials(string usr, string pswrd, securitytoken secure, int userID)
        {
            Username = usr;
            Password = pswrd;
            SecurityToken = secure;
            UserID = userID;
        }

        internal securitytoken SecurityToken { get; set; }
        internal string Username { get; set; }
        [Obsolete("Should be incrypted")]
        internal string Password { get; set; }
        internal int UserID { get; set; }
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
