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
    public partial class CompanysAdministration : BaseRWindow
    {
         Companys _CurrentCompany;
        public CompanysAdministration()
        {
            InitializeComponent();
            LoadCompanies();
        }
        private void LoadSelectedCompany(int ID)
        {
            _CurrentCompany = Entities.GetCompanyByID(ID);
            tbAddress.Text = _CurrentCompany.Address;
            tbCity.Text = _CurrentCompany.City;
            tbCountry.Text = _CurrentCompany.Country;
            tbPostalCode.Text = _CurrentCompany.Postalcode.ToString();
            tbState.Text = _CurrentCompany.State;
        }
        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedCompany(cbCompany.SelectedIndex+1);
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
            DialogResult dr =new NewCompany().ShowDialog();
            if(dr == System.Windows.Forms.DialogResult.Cancel)
            {
                Log.System("user Canceled the action");
            }
            else if(dr == System.Windows.Forms.DialogResult.OK)
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
        private void tbCity_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Companys _CurrentCompany = new Companys();
            // check for holes in the data. cant have a user without initials.
            if (
                 !string.IsNullOrWhiteSpace(cbCompany.Text) &&
                 !string.IsNullOrWhiteSpace(tbAddress.Text) &&
                 !string.IsNullOrWhiteSpace(tbCity.Text) &&
                 !string.IsNullOrWhiteSpace(tbCountry.Text) &&
                 !string.IsNullOrWhiteSpace(tbPostalCode.Text))
            {
                _CurrentCompany.CompanyName = cbCompany.Text;
                _CurrentCompany.Address = tbAddress.Text;
                _CurrentCompany.City = tbCity.Text;
                _CurrentCompany.Country = tbCountry.Text;
                try { _CurrentCompany.Postalcode = Convert.ToInt32(tbPostalCode.Text); }
                catch { MessageBox.Show(Log.Error("Postalcode is not a number numbnuts!")); return; }
                _CurrentCompany.State = tbState.Text;
                try
                {
                    Entities.UpdateCompany(_CurrentCompany);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show(Log.System("Failed to add Company"));
                }
            }
            else
            {
                MessageBox.Show("Fill out the form numbnuts!");
            }
                    
        }
    }
}
