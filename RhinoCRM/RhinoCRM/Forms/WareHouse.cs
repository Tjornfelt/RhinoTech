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
    public partial class WareHouse : Form
    {
        
        public WareHouse()
        {
            InitializeComponent();
        }
        private void WareHouse_Leave(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Closedbook;
        }

        private void WareHouse_Activated(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Openbook;
        }
        private void WareHouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rCMSDataSet.GetTotalProductInfo' table. You can move, or remove it, as needed.
            this.TableAddabter.Fill(this.rCMSDataSet.GetTotalProductInfo);
        
        }
        private void EditProduct(int id)
        {
            EditProduct ep = new EditProduct();
            ep.MdiParent = this.MdiParent;
            ep.Show();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvData.SelectedRows)
            {
                int id;
                int.TryParse(row.Cells[0].Value.ToString(), out id);
                EditProduct(id);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
