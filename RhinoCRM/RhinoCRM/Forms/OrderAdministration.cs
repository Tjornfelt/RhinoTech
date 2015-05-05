using RhinoCRM.Core.Entityframework;
using RhinoCRM.Core.Login;
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
    public partial class OrderAdministration : BaseRWindow
    {
        bool OrderItemsEdited = false;
        Orders _CurrentOrder;
        Customers _CurrentCustomer;
        Companys _CurrentCompany;
        RCredentials _Credentials;
        public OrderAdministration()
        {
            InitializeComponent();
        }
        private void LoadOrder()
        {
            Log.System("Rebuilding list.");
            if (_CurrentOrder != null)
            {
                this.getOrderItemsByIDTableAdapter.Fill(this.rCMSDataSet.GetOrderItemsByID, _CurrentOrder.ID);
                _CurrentCustomer = Entities.GetCustomersByID(_CurrentOrder.CustomerID);
                _CurrentCompany = Entities.GetCompanyByID(_CurrentCustomer.CompanyID);
                if (_CurrentCustomer != null)
                {
                    tbCustomerNumber.Text = string.Format("{0:0000}", _CurrentCustomer.ID);
                    tbFirstName.Text = _CurrentCustomer.FirstName;
                    tbLastname.Text = _CurrentCustomer.LastName;
                    tbPhoneACode.Text = _CurrentCustomer.PhoneAreaCode;
                    tbPhoneNumber.Text = _CurrentCustomer.PhonenNumber.ToString();
                    if (_CurrentCompany != null)
                    {
                        tbCompanyName.Text = _CurrentCompany.CompanyName;
                        tbAddress.Text = _CurrentCompany.Address;
                        tbCity.Text = _CurrentCompany.City;
                        tbCountry.Text = _CurrentCompany.Country;
                        tbPostalCode.Text = _CurrentCompany.Postalcode.ToString();
                        tbState.Text = _CurrentCompany.State;
                    }
                }
            }
            OrderItemsEdited = false;
            Log.System("Finished Rebuilding list.");
        }
        private void OrderAdministration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rCMSDataSet.GetOrdersInfo' table. You can move, or remove it, as needed.
            this.getOrdersInfoTableAdapter.Fill(this.rCMSDataSet.GetOrdersInfo);
         
        }
        private void dgvOrdersOverview_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrdersOverview.SelectedRows != null)
            {
                foreach (DataGridViewRow row in dgvOrdersOverview.SelectedRows)
                {
                    int id;
                    int.TryParse(row.Cells[0].Value.ToString(), out id);
                    _CurrentOrder = Entities.GetOrderByID(id);
                    if (OrderItemsEdited)
                    {
                       if(MessageBox.Show("Save Shipping Changes ?","Attention!",MessageBoxButtons.YesNo)== System.Windows.Forms.DialogResult.Yes)
                       {
                           foreach(DataGridViewRow itemrow in dgvOrderItems.Rows)
                           {
                               int itemid;
                               int.TryParse(itemrow.Cells[0].Value.ToString(), out itemid);
                               bool itemValue;
                               bool.TryParse(itemrow.Cells[4].Value.ToString(), out itemValue);
                               Entities.UpdateOrderItemShipped(itemValue, itemid);
                           }
                       }
                    }
                    LoadOrder();
                }
            }

        }
        private void dgvOrderItems_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            OrderItemsEdited = true;
        }

        private void OrderAdministration_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(OrderItemsEdited)
            {
                dgvOrdersOverview_SelectionChanged(sender, e);
            }
        }
    }
}
