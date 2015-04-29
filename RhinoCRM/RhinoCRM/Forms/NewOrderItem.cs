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
    public partial class NewOrderItem : BaseRWindow
    {
        OrdersItems _CurrentOrderItems = new OrdersItems();
        Products _CurrentProduct = new Products();
        public NewOrderItem()
        {
            InitializeComponent();
            GetProducts();
        }
        private void GetProducts()
        {
            // clear so that we dont get a new list in the end of it other.
            cbProductName.Items.Clear();

            Products[] products = Entities.GetProducts().ToArray();
            foreach (Products product in products)
            {
                cbProductName.Items.Add(string.Format("{0}", product.Name));
            }
        }
        internal OrdersItems GetOrderItem { get { return _CurrentOrderItems; } }
        private void LoadSelectedProduct(int ID)
        {
            _CurrentProduct = Entities.GetProductByID(ID);
            tbDescription.Text = _CurrentProduct.Description;
            tbDescription.Text = _CurrentProduct.Description;
            tbPrice.Text = _CurrentProduct.Price.ToString();
            tbAmount.Text = "";          
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        private void RecalcPrices()
        {
            Log.System("Recalcolation of Prices");
            if (!string.IsNullOrWhiteSpace(tbDiscount.Text) &&
                !string.IsNullOrWhiteSpace(tbPrice.Text) &&
                !string.IsNullOrWhiteSpace(tbAmount.Text))
            {
                double Result = 0;
                int Amount = 0;
                double Price = 0;
                double TotalPrice = 0;
                double Discount = 0;
                try { Amount = Convert.ToInt32(tbAmount.Text); }
                catch { MessageBox.Show(Log.Error("Amount is not a number numbnuts!")); return; }
                try { Price = Convert.ToDouble(tbPrice.Text); }
                catch { MessageBox.Show(Log.Error("Price is not a number numbnuts!")); return; }
                try { Discount = Convert.ToDouble(tbDiscount.Text)/100; }
                catch { MessageBox.Show(Log.Error("Dicount is not a whole number numbnuts!, we dont do half's")); return; }

                TotalPrice = (Amount*Price);
                Result = TotalPrice -(TotalPrice*(Discount));

                tbTotalPrice.Text = Result.ToString();                
            }

        }
        private void Prices_TextChanged(object sender, EventArgs e)
        {
            RecalcPrices();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_CurrentProduct != null)
            {
                // check for holes in the data. 
                if (!string.IsNullOrWhiteSpace(tbDiscount.Text) &&
                    !string.IsNullOrWhiteSpace(tbPrice.Text) &&
                    !string.IsNullOrWhiteSpace(tbAmount.Text) &&
                    !string.IsNullOrWhiteSpace(tbTotalPrice.Text))
                {
                    _CurrentOrderItems = new OrdersItems();
                    try { _CurrentOrderItems.Amount = Convert.ToInt32(tbAmount.Text); }
                    catch { MessageBox.Show(Log.Error("Amount is not a number numbnuts!")); return; }
                    try { _CurrentOrderItems.Discount = Convert.ToInt32(tbDiscount.Text); }
                    catch { MessageBox.Show(Log.Error("Dicount is not a whole number numbnuts!, we dont do half's")); return; }
                    _CurrentOrderItems.ProductID = _CurrentProduct.ID;
                    _CurrentOrderItems.isShipped = false;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                Log.System("No Product Selceted");
            }
        }            
        private void cbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedProduct(cbProductName.SelectedIndex + 1);
        }

       /* private void UpdateProduct()
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
        }*/
    }
}
