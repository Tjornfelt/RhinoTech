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
    public partial class EditProduct : BaseRWindow
    {
        Products _CurrentProduct = new Products();
        RCredentials.securitytoken _ST;
        public EditProduct(int id, RCredentials.securitytoken st )
        {
            InitializeComponent();           
            LoadSelectedProduct(id);
            _ST = st;
            LoadCredentials();
        }
        void LoadCredentials()
        {
            if(_ST != RCredentials.securitytoken.isAdmin && _ST != RCredentials.securitytoken.isSales)
            {
                tbDescription.Enabled = false;
                tbName.Enabled = false;
                tbSku.Enabled = false;
                tbType.Enabled = false;
                tbPrice.Enabled = false;
                ckbDiscontinued.Enabled = false;
                tbAmount.TabIndex = 1;
            }
        }
        private void LoadSelectedProduct(int ID)
        {
            _CurrentProduct = Entities.GetProductByID(ID);
            //tbAmount.Text = _CurrentProduct.WarehouseShelfs..Address;
            tbDescription.Text = _CurrentProduct.Description;
            tbName.Text = _CurrentProduct.Name;
            tbSku.Text = _CurrentProduct.SKU;
            tbType.Text = _CurrentProduct.Type;
            tbPrice.Text = _CurrentProduct.Price.ToString();
            ckbDiscontinued.Checked = _CurrentProduct.Discontinued;          
            tbAmount.Text = Entities.GetShelfAmountByProductID(_CurrentProduct.ID).ToString();
            tbShelf.Text = Entities.GetShelfByProductID(_CurrentProduct.ID);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }
        private void UpdateProduct()
        {
            Log.System(string.Format("Updating Product: {0} {1} with ID {2}", tbName.Text, tbSku.Text, _CurrentProduct.ID));

            if (_CurrentProduct != null)
            {
                // check for holes in the data. cant have a user without initials.
                if (!string.IsNullOrWhiteSpace(tbShelf.Text) &&
                    !string.IsNullOrWhiteSpace(tbAmount.Text) &&
                    !string.IsNullOrWhiteSpace(tbType.Text) &&
                    !string.IsNullOrWhiteSpace(tbSku.Text) &&
                    !string.IsNullOrWhiteSpace(tbName.Text) &&
                    !string.IsNullOrWhiteSpace(tbDescription.Text))
                {
                    _CurrentProduct.Type = tbType.Text;
                    _CurrentProduct.SKU = tbSku.Text;
                    _CurrentProduct.Name = tbName.Text;
                    _CurrentProduct.Discontinued = ckbDiscontinued.Checked;
                    _CurrentProduct.Description = tbDescription.Text;
                    try { _CurrentProduct.Price = Convert.ToDouble(tbPrice.Text); }
                    catch { MessageBox.Show(Log.Error("Price is not a number numbnuts!")); return; }

                    // Ware house 

                    List<WarehouseShelfs> shelves = new List<WarehouseShelfs>();
                    WarehouseShelfs whs = new WarehouseShelfs(); 
                    try { whs.Amount = Convert.ToInt32(tbAmount.Text); }
                    catch { MessageBox.Show(Log.Error("Amount is not a number numbnuts!")); return; }
                    whs.Shelf = tbShelf.Text;
                    shelves.Add(whs);
                    _CurrentProduct.WarehouseShelfs = shelves;
                    try
                    {
                        Entities.UpdateProduct(_CurrentProduct);
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show(Log.System("Failed to update Product"));
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
    }
}
