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
    public partial class WareHouse : BaseRWindow
    {
        RCredentials.securitytoken _ST;
        public WareHouse(RCredentials.securitytoken st)
        {
            InitializeComponent();
            _ST = st;
        }
        private void WareHouse_Load(object sender, EventArgs e)
        {
            FillTable();        
        }
        private void FillTable()
        {
            // TODO: This line of code loads data into the 'rCMSDataSet.GetTotalProductInfo' table. You can move, or remove it, as needed.
            this.TableAddabter.Fill(this.rCMSDataSet.GetTotalProductInfo);
        }
        private void EditProduct(int id)
        {
            Log.System("Opening edit product page.");
            DialogResult dr = new EditProduct (id,_ST).ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.Cancel)
            {
                Log.System("user canceled the action");
            }
            else if (dr == System.Windows.Forms.DialogResult.OK)
            {
                FillTable();
            }
            else
            {
                Log.System("Do not reconice the action");
            }
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
    }
}
