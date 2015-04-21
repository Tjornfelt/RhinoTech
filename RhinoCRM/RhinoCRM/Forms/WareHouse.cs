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
    }
}
