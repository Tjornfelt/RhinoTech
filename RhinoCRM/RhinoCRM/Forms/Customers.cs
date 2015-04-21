using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhinoCRM.Forms
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            testsql();
        }
        private void testsql()
        {
            string connetionString = null;

            SqlConnection cnn;
            connetionString = "server =SQL\\RSQL ;Initial Catalog=RCMS;User ID=sa;Password=Rhino2015;timeout = 10";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                testsql();
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }

        private void Customers_Leave(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Closedbook;
        }

        private void Customers_Activated(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Openbook;
        }
    }
}
