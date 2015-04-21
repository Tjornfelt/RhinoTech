
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
using RhinoCRM.Core;
using RhinoCRM.Core.Entityframework;
using RhinoCRM.Core.Login;

namespace RhinoCRM.Forms
{
    public partial class Login : Form
    {
        internal RCredentials _Credentials;
        internal string _LocalMachine = Environment.MachineName;
        internal string _DefaultDomain;
        internal string _Username;
        internal string _Domain;
        public Login()
        {
            InitializeComponent();
            try
            {
                Domain d = Domain.GetComputerDomain();
                lLoginTo.Text= _DefaultDomain = d.Name;
            }
            catch
            {
                _DefaultDomain = _LocalMachine;
                lLoginTo.Text = _DefaultDomain;
            }

        }

        [Obsolete("Proper AD Handling and Async")]
        private RCredentials.securitytoken GetSQLCredentials()
        {

            Entities e = new Entities();
            return e.GetUserSecuretoken(_Username);
        }
        [Obsolete("Proper AD Handling and Async")]
        private void PerformLogin()
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }          
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if(tbUsername.Text.Contains(@"\\"))            
            {
                string[] s = (tbUsername.Text.Split('\\'));

                _Domain = lLoginTo.Text = s[2];
                if (s.Length == 4) _Username = s[3];
                else _Username = "";
            }
            else if (tbUsername.Text.Contains("@"))
            {
                string[] s = (tbUsername.Text.Split('@'));
                _Username = s[0];
                _Domain = lLoginTo.Text = s[1];
            }
            else
            {
                _Domain= lLoginTo.Text = _DefaultDomain;
                _Username = tbUsername.Text;
            }
        }
    }
}
