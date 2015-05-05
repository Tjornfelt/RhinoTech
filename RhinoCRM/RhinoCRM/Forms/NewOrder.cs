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
    public partial class NewOrder : BaseRWindow
    {
        Orders _CurrentOrder;
        Customers _CurrentCustomer;
        Companys _CurrentCompany;
        RCredentials _Credentials;
        public NewOrder(RCredentials credentials)
        {
            InitializeComponent();
            _Credentials = credentials;
            LoadCustomers();
        }
        private void LoadSelectedCustomer(int ID)
        {

            _CurrentCustomer = Entities.GetCustomersByID(ID);
            if (_CurrentCustomer != null)
            {
                tbFirstName.Text = _CurrentCustomer.FirstName;
                tbLastname.Text = _CurrentCustomer.LastName;
                tbPhoneACode.Text = _CurrentCustomer.PhoneAreaCode;
                tbPhoneNumber.Text = _CurrentCustomer.PhonenNumber.ToString();

                _CurrentCompany = Entities.GetCompanyByID(_CurrentCustomer.CompanyID);
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
        private void LoadCustomers()
        {
            // clear so that we dont get a new list in the end of it other.
            cbCustomerID.Items.Clear();
            Customers[] customers = Entities.GetCustomers().ToArray();
            foreach (Customers customer in customers)
            {
                cbCustomerID.Items.Add(string.Format("{0:0000}", customer.ID));
            }
        }
        private void RebuildOrderItemsList()
        {
            Log.System("Rebuilding list.");
            if (_CurrentOrder != null)
            {
                if (_CurrentOrder.OrdersItems.Count() != 0)
                {
                    // Here we create a DataTable with four columns.
                    DataTable table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Item", typeof(string));
                    table.Columns.Add("Amount", typeof(string));
                    table.Columns.Add("Discount", typeof(string));
                    table.Columns.Add("Price", typeof(string));
                    table.Columns.Add("Total", typeof(string));

                    double VAT = _CurrentOrder.VAT;
                    VAT = VAT / 100;
                    double grandtotal = 0;
                    int iid = 0;
                    foreach (OrdersItems oi in _CurrentOrder.OrdersItems)
                    {
                        Products p = Entities.GetProductByID(oi.ProductID);
                        int ia = oi.Amount;
                        int id = oi.Discount;
                        double dp = p.Price;
                        double dtp = (ia * dp);
                        double dt = dtp - (dtp * (id / 100));
                        grandtotal += dt;

                        // Here we add five DataRows.
                        table.Rows.Add(iid, p.Name, ia, id, dp, dt);
                        iid++;
                    }

                    table.Rows.Add(null, "VAT", "", "", string.Format("VAT: {0}%", VAT), grandtotal * VAT);
                    table.Rows.Add(null, "Grand Total", "", "", "", grandtotal + (grandtotal * VAT));
                    dgvOrderItems.DataSource = table;

                }
                else
                {
                    Log.System("there is no items in this order.");
                    DataTable table = new DataTable();
                    dgvOrderItems.DataSource = table;
                }

            }
            Log.System("Finished Rebuilding list.");
        }
        private void cbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedCustomer(cbCustomerID.SelectedIndex + 1);
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
                // Select the newly created one.
                cbCustomerID.SelectedIndex = cbCustomerID.Items.Count - 1;
            }
            else
            {
                Log.System("Do not reconice the action");
            }
        }
        private void btnAddOrderItem_Click(object sender, EventArgs e)
        {
            if (_CurrentOrder == null)
            {
                _CurrentOrder = new Orders()
                    {
                        Date = DateTime.Now,
                        SalespersonID = _Credentials.UserID,
                        CustomerID = _CurrentCustomer.ID,
                        VAT = 25
                    };
            }
            if (_CurrentCustomer != null && _Credentials != null)
            {

                Log.System("Opening new Company page.");
                NewOrderItem noi = new NewOrderItem();
                DialogResult dr = noi.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.Cancel)
                {
                    Log.System("user Canceled the action");
                    return;
                }
                else if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    _CurrentOrder.OrdersItems.Add(noi.GetOrderItem);
                    RebuildOrderItemsList();
                }
                else
                {
                    Log.System("Do not reconice the action");
                    return;
                }


            }
            else
            {
                Log.Error("Customer or user not set.");
            }
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if(_CurrentOrder != null)
            {
                try { Entities.AddOrder(_CurrentOrder); }
                catch { Log.Error("Failed to Create Order"); return; }
                this.Close();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.SelectedRows != null)
            {
                foreach (DataGridViewRow row in dgvOrderItems.SelectedRows)
                {
                    int id;
                    int.TryParse(row.Cells[0].Value.ToString(), out id);
                    _CurrentOrder.OrdersItems.Remove(_CurrentOrder.OrdersItems.First(x => x.ID == id));
                }
                RebuildOrderItemsList();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

