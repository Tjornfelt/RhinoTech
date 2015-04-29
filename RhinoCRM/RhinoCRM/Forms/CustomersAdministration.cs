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
    public partial class CustomersAdministration : BaseRWindow
    {
        Customers _CurrentCustomer;
        Companys _CurrentCompany;
        public CustomersAdministration()
        {
            InitializeComponent();
            LoadCompanies();
            LoadCustomers();
        }
        private void LoadSelectedCustomer(int ID)
        {
            _CurrentCustomer = Entities.GetCustomersByID(ID);
            tbFirstName.Text = _CurrentCustomer.FirstName;
            tbLastname.Text = _CurrentCustomer.LastName;
            tbPhoneACode.Text = _CurrentCustomer.PhoneAreaCode;
            tbPhoneNumber.Text = _CurrentCustomer.PhonenNumber.ToString();
            cbCompany.SelectedIndex = _CurrentCustomer.CompanyID - 1;
        }
        private void LoadSelectedCompany(int ID)
        {
            _CurrentCompany = Entities.GetCompanyByID(ID);
            _CurrentCustomer.CompanyID = ID;
            tbAddress.Text = _CurrentCompany.Address;
            tbCity.Text = _CurrentCompany.City;
            tbCountry.Text = _CurrentCompany.Country;
            tbPostalCode.Text = _CurrentCompany.Postalcode.ToString();
            tbState.Text = _CurrentCompany.State;
        }
        private void LoadCustomers()
        {
            // clear so that we dont get a new list in the end of it other.
            cbCustomerID.Items.Clear();
            Customers[] customers = Entities.GetCustomers().ToArray();
            foreach (Customers customer in customers)
            {
                cbCustomerID.Items.Add(string.Format("{0}", customer.ID));
            }
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
        private void UpdateUser()
        {
            Log.System(string.Format("Updating Customer: {0} {1} with ID {3}", tbFirstName.Text, tbLastname.Text,cbCustomerID.Text));

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
                        Entities.UpdateCustomer(_CurrentCustomer);
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
        private void cbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedCustomer(cbCustomerID.SelectedIndex + 1);
        }
        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_CurrentCustomer != null) { LoadSelectedCompany(cbCompany.SelectedIndex + 1); }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            Log.System("Opening new Customer page.");
            DialogResult dr = new NewCustomer().ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.Cancel)
            {
                Log.System("user Canceled the action");
            }
            else if (dr == System.Windows.Forms.DialogResult.OK)
            {
                LoadCustomers();
                LoadCompanies();
                // Select the newly created one.
                cbCustomerID.SelectedIndex = cbCustomerID.Items.Count - 1;
            }
            else
            {
                Log.System("Do not reconice the action");
            }
        }
      
    }
}
