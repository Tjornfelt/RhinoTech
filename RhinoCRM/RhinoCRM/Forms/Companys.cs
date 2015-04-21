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
    public partial class Companys : Form
    {
        public Companys()
        {
            InitializeComponent();
        }

        private void Companys_Activated(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Openbook;
        }

        private void Companys_Leave(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Closedbook;
        }
    }
}
