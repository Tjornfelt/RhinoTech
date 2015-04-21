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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Order_Leave(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Closedbook;
        }

        private void Order_Activated(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Openbook;
        }
    }
}
