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
    public partial class NewCompany : BaseRWindow
    {
       
        public NewCompany()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Companys _CurrentCompany = new Companys();
            // check for holes in the data. cant have a user without initials.
            if (
                 !string.IsNullOrWhiteSpace(tbCompanyName.Text) && 
                 !string.IsNullOrWhiteSpace(tbAddress.Text) &&
                 !string.IsNullOrWhiteSpace(tbCity.Text) &&
                 !string.IsNullOrWhiteSpace(tbCountry.Text) &&
                 !string.IsNullOrWhiteSpace(tbPostalCode.Text))
            {
                _CurrentCompany.CompanyName = tbCompanyName.Text;
                _CurrentCompany.Address = tbAddress.Text;
                _CurrentCompany.City = tbCity.Text;
                _CurrentCompany.Country = tbCountry.Text;
                try{_CurrentCompany.Postalcode = Convert.ToInt32(tbPostalCode.Text);}
                catch { MessageBox.Show(Log.Error("Postalcode is not a number numbnuts!")); return; }
                _CurrentCompany.State = tbState.Text;
                try
                {
                    Entities.AddCompany(_CurrentCompany);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show( Log.System("Failed to add Company"));
                }
            }
            else
            {
                MessageBox.Show("Fill out the form numbnuts!");
            }
        }
    }
}
