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
    public partial class Main : Form
    {
        RCredentials _Credentials;
        public Main()
        {
            InitializeComponent();
            InitializeLog();
        }
        private void InitializeLog()
        {
            Log.AddLapsTimesInSysLog = false;
            Log.AddTimeStampsToSyslog = true;
            Log.LogPrefix = "RCMR";
            Log.PathSysLog = Log.PathLapstimeLog = @"C:\Temp\Log";
            Log.ReturnTagsInMethods = false;
            Log.SpacerWidth = 32;
            Log.Spacer();
            Log.System("Log Initialized");
            Log.Spacer();
        }   
        // General Methods
        // -----------------------------------------------------------------------
        private void SetupCRM()
        {
            if(_Credentials != null)
            {
                switch(_Credentials.SecurityToken)
                {
                    case RCredentials.securitytoken.isAdmin:
                        break;
                    case RCredentials.securitytoken.isSales:
                        break;
                    case RCredentials.securitytoken.isWorker:
                        AddWorkerPreviliges();
                        break;
                    default:
                        Log.Error("Unreconized Secure Token.");
                        break;
                }
            }
        }
        private void AddWorkerPreviliges()
        {
            // main menu item, the root.
            ToolStripMenuItem tsmiMain = new ToolStripMenuItem("Warehouse");
            // 
            ToolStripMenuItem tsmiOpenStock = new ToolStripMenuItem("Open Stock");
            tsmiOpenStock.Click += OpenStock_Click;
            ToolStripMenuItem tsmiOpenCustomers = new ToolStripMenuItem("Open Customers");
            tsmiOpenCustomers.Click += OpenCustomers_Click; 
            tsmiMain.DropDownItems.Add(tsmiOpenStock);
            tsmiMain.DropDownItems.Add(tsmiOpenCustomers);
            MainMenu.Items.Add(tsmiMain);
        }
        private void AddAdminPreviliges()
        {
            MainMenu.Items.Add(AddWarehoueseMenu());
        }
        // TSMI Generation Methods
        // -----------------------------------------------------------------------
        private ToolStripMenuItem AddWarehoueseMenu()
        {   // main menu item, the root.
            ToolStripMenuItem tsmiMain = new ToolStripMenuItem("Warehouse");
            // Menu items
            tsmiMain.DropDownItems.Add(AddOpenStockMenuItem());
            tsmiMain.DropDownItems.Add(AddOpenCustomersMenuItem());
            return tsmiMain;
        }
        private ToolStripMenuItem AddSalesMenu()
        {   
            // main menu item, the root.
            ToolStripMenuItem tsmiMain = new ToolStripMenuItem("Sales");
            // Menu items
            tsmiMain.DropDownItems.Add(AddOpenStockMenuItem());
            tsmiMain.DropDownItems.Add(AddOpenCustomersMenuItem());
            return tsmiMain;
        }
        private ToolStripMenuItem AddOpenStockMenuItem()
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem("Open Stock");
            tsmi.Click += OpenStock_Click;
            return tsmi;
        }
        private ToolStripMenuItem AddOpenCustomersMenuItem()
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem("Open Customers");
            tsmi.Click += OpenCustomers_Click;
            return tsmi;
        }
        private ToolStripMenuItem AddOpenCurrentActiveOrdersMenuItem()
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem("Open Current Orders");
            tsmi.Click += OpenCurrentActiveOrders_Click;
            return tsmi;
        }
        private  bool EnableFilesMenuItems
        {
            set
            {
                /*  tsmiNewCompany.Enabled = value;
                tsmOpenOrder.Enabled = value;
                tsmiNewCustomer.Enabled = value;
                 */
            }
        }
        // MDI Methods
        // -----------------------------------------------------------------------
        private void AddChildMdi(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }
        // EventHandlers
        // -----------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            Log.System(string.Format("Showing Logon Screen"));
            Login l = new Login();
            // l.MdiParent = this;
            l.StartPosition = FormStartPosition.Manual;
            l.Location = new Point((this.ClientRectangle.Width - l.Width) / 2, (this.ClientRectangle.Height - l.Height) / 2);
            //l.WindowState = FormWindowState.Maximized;
            System.Windows.Forms.DialogResult dr = l.ShowDialog();
           
            if (dr == System.Windows.Forms.DialogResult.Cancel)
            {
                Log.System(string.Format("User Canceled, Closing RhinoCRM"));
                this.Close();
            }
            else if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Log.System(string.Format("User Accepted and ready"));
                _Credentials = l._Credentials;
                SetupCRM();
            }
            else
            {
                Log.System(string.Format("Un Expected Imput"));
            }
        }
        private void OpenStock_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void NewOrder_Click(object sender, EventArgs e)
        {
            AddChildMdi(new Order());
        }
        private void NewCustomer_Click(object sender, EventArgs e)
        {
            AddChildMdi(new Customers());
        }
        private void NewCompany_Click(object sender, EventArgs e)
        {
            AddChildMdi(new Companys());
        } 
        private void OpenCustomers_Click(object sender, EventArgs e)
        {
            AddChildMdi(new Customers());
        }
        private void OpenCurrentActiveOrders_Click(object sender, EventArgs e)
        {
            AddChildMdi(new Customers());
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
