using RhinoCRM.Core.Entityframework;
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
        Users _Currentuser;
        public UsersAdministration()
        {
            InitializeComponent();
            LoadUser();
        }
        private void LoadUser()
        {
            Users[] userlist = Entities.GetUsers().ToArray();
            foreach(Users user in userlist)
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
        private void cbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedUser(cbUserID.SelectedIndex + 1);
        }
        private void button3_Click(object sender, EventArgs e)
        {      
            if (!string.IsNullOrWhiteSpace(tbLastName.Text) && _Currentuser != null)
            {
                _Currentuser.FirstName = tbLastName.Text;

            }
            if (_Currentuser != null)
            {
                _Currentuser.isSalesPerson = rbtnIsSales.Checked;
            }
            if (_Currentuser != null)
            {
                _Currentuser.isWorker = rbtnIsWorker.Checked;
            }  
            if (!string.IsNullOrWhiteSpace(tbFirstName.Text) && _Currentuser != null)
            {
                _Currentuser.FirstName = tbFirstName.Text;                
            }  
            if (_Currentuser != null)
            {
                _Currentuser.isAdmin = rbtnIsAdmin.Checked;
            } 
            if (!string.IsNullOrWhiteSpace(tbPassword.Text)&& _Currentuser != null)
            {
                _Currentuser.FirstName = tbPassword.Text;
            } 
            if (!string.IsNullOrWhiteSpace(tbInitias.Text) && _Currentuser != null)
            {
                _Currentuser.FirstName = tbInitias.Text;
            }
        }
    }
}
