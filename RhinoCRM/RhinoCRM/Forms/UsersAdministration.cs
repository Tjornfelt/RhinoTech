using RhinoCRM.Core.Entityframework;
using SHUtils.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhinoCRM.Forms
{
    public partial class UsersAdministration : BaseRWindow
    {
        bool _newmode = false;
        bool NewMode
        {
            get { return _newmode; }
            set
            {
                Log.System(string.Format("Setting newmode = {0}", value));
                _newmode = value;
                // Flip the valuse dont whant it to be enabled when we are in new mode.
                cbUserID.Enabled = value ? false : true;
                // again deefrend walues for difrendt modes 
                btnUpdate.Text = value ? "Create" : "Update";
                if (value) // meaning if we are in new mode 
                {
                    // Clear form
                    tbFirstName.Text = "";
                    tbLastName.Text = "";
                    tbInitias.Text = "";
                    tbPassword.Text = "";

                    // reset the current user to a blank slate
                    _Currentuser = new Users();
                }
            }
        }
        Users _Currentuser;
        public UsersAdministration()
        {
            InitializeComponent();
            NewMode = false;
            LoadUser();
            cbUserID.SelectedIndex = 0;
        }
        private void LoadUser()
        {
            // clear so that we dont get a new list in the end of it other.
            cbUserID.Items.Clear();

            Users[] userlist = Entities.GetUsers().ToArray();
            foreach (Users user in userlist)
            {
                cbUserID.Items.Add(string.Format("{0:0000}", user.ID));
            }
        }
        private void LoadSelectedUser(int ID)
        {
            _Currentuser = Entities.GetUserByID(ID);
            tbFirstName.Text = _Currentuser.FirstName;
            tbLastName.Text = _Currentuser.LastName;
            tbInitias.Text = _Currentuser.Initials;
            tbPassword.Text = _Currentuser.Password;
            rbtnIsSales.Checked = _Currentuser.isSalesPerson;
            rbtnIsAdmin.Checked = _Currentuser.isAdmin;
            rbtnIsWorker.Checked = _Currentuser.isWorker;
        }
        private void NewUser()
        {
            Log.System(string.Format("Creating user: {0} with initials {1}", cbUserID.Text, tbInitias.Text));

            if (_Currentuser != null)
            {
                _Currentuser.isSalesPerson = rbtnIsSales.Checked;
                _Currentuser.isAdmin = rbtnIsAdmin.Checked;
                _Currentuser.isWorker = rbtnIsWorker.Checked;
                // check for holes in the data. cant have a user without initials.
                if (!string.IsNullOrWhiteSpace(tbFirstName.Text) &&
                    !string.IsNullOrWhiteSpace(tbLastName.Text) &&
                    !string.IsNullOrWhiteSpace(tbPassword.Text) &&
                    !string.IsNullOrWhiteSpace(tbInitias.Text))
                {
                    _Currentuser.FirstName = tbFirstName.Text;
                    _Currentuser.LastName = tbLastName.Text;
                    _Currentuser.Password = tbPassword.Text;
                    _Currentuser.Initials = tbInitias.Text;

                    try
                    {
                        Entities.AddUser(_Currentuser);
                        NewMode = false;
                        LoadUser();
                        // set to newest created user.
                        cbUserID.SelectedIndex = cbUserID.Items.Count - 1;
                    }
                    catch
                    {
                        Log.System("Log Failed");
                        MessageBox.Show("Log Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Fill out the form numbnuts!");
                }

            }
        }
        private void UpdateUser()
        {
            Log.System(string.Format("Updating user: {0} with initials {1}", cbUserID.Text, tbInitias.Text));

            if (_Currentuser != null)
            {
                _Currentuser.isSalesPerson = rbtnIsSales.Checked;
                _Currentuser.isAdmin = rbtnIsAdmin.Checked;
                _Currentuser.isWorker = rbtnIsWorker.Checked;
                // check for holes in the data. cant have a user without initials.
                if (!string.IsNullOrWhiteSpace(tbFirstName.Text) &&
                    !string.IsNullOrWhiteSpace(tbLastName.Text) &&
                    !string.IsNullOrWhiteSpace(tbPassword.Text) &&
                    !string.IsNullOrWhiteSpace(tbInitias.Text))
                {
                    _Currentuser.FirstName = tbFirstName.Text;
                    _Currentuser.LastName = tbLastName.Text;
                    _Currentuser.Password = tbPassword.Text;
                    _Currentuser.Initials = tbInitias.Text;

                    try
                    {
                        Entities.UpdateUser(_Currentuser);
                    }
                    catch
                    {
                        Log.System("Log Failed");
                        MessageBox.Show("Log Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Fill out the form numbnuts!");
                }

            }
        }
        private void cbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedUser(cbUserID.SelectedIndex + 1);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (NewMode)
            {
                NewUser();

            }
            else
            {
                UpdateUser();
            }

        }
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            NewMode = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (NewMode)
            {
                NewMode = false;
                cbUserID.SelectedIndex = 0;
            }
            else { this.Close(); }
        }
    }
}
