using RhinoCRM.Core.Entityframework;
using SHUtils.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhinoCRM.Forms
{
    public partial class NewCustomer : BaseRWindow
    {
        Customers _CurrentCustomer = new Customers();
        Companys _CurrentCompany;
        public NewCustomer()
        {
            InitializeComponent();
            LoadCompanies();
        }
        private void LoadSelectedCompany(int ID)
        {
            _CurrentCompany = Entities.GetCompanyByID(ID);
            _CurrentCustomer.CompanyID = ID;
        }
        private void LoadCompanies()
        {
            // clear so that we dont get a new list in the end of it other.
            cbCompany.Items.Clear();

            Companys[] Companies = Entities.GetCompanies().ToArray();
            foreach (Companys company in Companies)
            {
                cbCompany.Items.Add(string.Format("{0}", company.CompanyName));
            }
        }
        private void btnNewCompany_Click(object sender, EventArgs e)
        {
            Log.System("Opening new Company page.");
            DialogResult dr = new NewCompany().ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.Cancel)
            {
                Log.System("user Canceled the action");
            }
            else if (dr == System.Windows.Forms.DialogResult.OK)
            {
                LoadCompanies();
                // Select the newly created one.
                cbCompany.SelectedIndex = cbCompany.Items.Count - 1;
            }
            else
            {

                Log.System("Do not reconice the action");

            }
        }
        private void CreateCustomer()
        {
            Log.System(string.Format("Creating Customer: {0} {1}", tbFirstName.Text, tbLastname.Text));
            if (_CurrentCustomer != null)
            {


                // check for holes in the data. cant have a user without initials.
                if (!string.IsNullOrWhiteSpace(tbFirstName.Text) &&
                    !string.IsNullOrWhiteSpace(tbLastname.Text) &&
                    !string.IsNullOrWhiteSpace(tbPhoneACode.Text) &&
                    !string.IsNullOrWhiteSpace(tbPhoneNumber.Text))
                {
                    _CurrentCustomer.FirstName = tbFirstName.Text;
                    _CurrentCustomer.LastName = tbLastname.Text;
                    _CurrentCustomer.PhoneAreaCode = tbPhoneACode.Text;
                    try { _CurrentCustomer.PhonenNumber = Convert.ToInt32(tbPhoneNumber.Text); }
                    catch { MessageBox.Show(Log.Error("PhoneNumber is not a number numbnuts!")); return; }

                    try
                    {
                        Entities.AddCustomer(_CurrentCustomer);
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show(Log.System("Failed to update Customer"));
                    }
                }
                else
                {
                    MessageBox.Show("Fill out the form numbnuts!");
                }
            }
            else
            {
                Log.Error("Current customer is not set!");
            }
        }
        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_CurrentCustomer != null) { LoadSelectedCompany(cbCompany.SelectedIndex + 1); }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CreateCustomer();
        }
    }
}
