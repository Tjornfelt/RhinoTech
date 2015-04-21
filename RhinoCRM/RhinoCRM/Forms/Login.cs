
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using SHUtils.Logging;
using System.DirectoryServices.ActiveDirectory;
using System.Data.SqlClient;
using RhinoCRM.Core.Login;
using RhinoCRM.Core.Entityframework;

namespace RhinoCRM.Forms
{
    public partial class Login : Form
    {
        internal RCredentials _Credentials;
        Entities _e = new Entities();
        public Login()
        {
            InitializeComponent();
        }
        private void PerformSQLLogin()
        {
            string Password = tbPassword.Text;
            string Username = tbUsername.Text;
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                Users u = _e.VerifySQLUserByLogin(Username, Password);
                if (u != null)
                {
                    Log.System(string.Format("User typed in correct Creds"));
                    _Credentials = new RCredentials(Username, Password, GetSQLCredentials(u.ID));
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    return;
                }
            }
            Log.System(string.Format("User typed in wrong Creds"));
            MessageBox.Show("Failed to log, username or password is incorrect");
        }
        private Task PerformSQLLoginAsync()
        {
            return Task.Run((Action)PerformSQLLogin);
        }   
        private RCredentials.securitytoken GetSQLCredentials(int ID)
        {
            return _e.GetUserSecuretokenbyID(ID);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await PerformSQLLoginAsync();
        }       
    }
}
        /* OLD AD TEST CODE
        [Obsolete("Proper AD Handling and Async")]
        private void PerformADLogin()
        {
            // create a "principal context" - e.g. your domain (could be machine, too)
            using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, _Domain))
            {
                try
                {
                    //validate the credentials
                    bool isValid = pc.ValidateCredentials(_Username, tbPassword.Text);
                    if (isValid)
                    {
                        Log.System(string.Format("User typed in correct Creds"));
                        _Credentials = new RCredentials(_Username, tbPassword.Text,GetSQLCredentials());  
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        Log.System(string.Format("User typed in wrong Creds"));
                        MessageBox.Show("Failed to log, username or password is incorrect");
                    }
                }
                catch (Exception ex)
                {
                    Log.System(string.Format("Failed to log in : exeption {0} ", ex));
                    MessageBox.Show("Failed to log");
                }
            }
        }
        private Task PerformADLoginAsync()
        {
            return Task.Run((Action)PerformADLogin);
        }     
    */