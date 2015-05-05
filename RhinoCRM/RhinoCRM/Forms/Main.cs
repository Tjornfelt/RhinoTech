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
            Log.AddLapsTimesInSysLog = false; // skal der logges i system loggen når der  
                                              // laves en tids tagening.
            Log.AddTimeStampsToSyslog = true; // skal der skrives klokkeslæt i systemloggen
            Log.ReturnTagsInMethods = false;  // skal de forskellige tags sendes retur så de 
                                              // kan bruges directe i en brugerflade
            Log.LogPrefix = "RCMR";           // predix til lognavn
            Log.PathSysLog = @"C:\Temp\Log";  // Stigen til systemloggen 
            Log.PathLapstimeLog = @"C:\Temp\Log"; // Stigen til tidstagningloggen
            Log.SpacerWidth = 32;             // spacer width er for grafisk hvis der                               
                                              // skrives bred tekst i loggen er det rart med 
                                              // bred streg til separering
            Log.Spacer();                     // skriv seperering til loggen 
            Log.System("Log Initialized");    // skriv Log Initialized med SystemTag 
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
                        EnableAdminPreviliges();
                        break;
                    case RCredentials.securitytoken.isSales:
                        EnableSalesPreviliges();
                        break;
                    case RCredentials.securitytoken.isWorker:
                        EnableWorkerPreviliges();
                        break;
                    default:
                        Log.Error("Unreconized Secure Token.");
                        break;
                }
            }
        } 
        private void EnableAdminPreviliges()
        {
            EnableSalesPreviliges();
            EnableWorkerPreviliges();
            MainMenu.Items.Add(MenuAdmin());
        }  
        private void EnableSalesPreviliges()
        {
            MainMenu.Items.Add(MenuSales());
        }
        private void EnableWorkerPreviliges()
        {
            MainMenu.Items.Add(MenuWarehouese());
        }   
        private void Lockdown()
        {
            // skip the first that one we like :3 remove the rest
            while (MainMenu.Items.Count != 1)
            {
                MainMenu.Items.RemoveAt(1);
            }
            while (this.MdiChildren.Count() != 0)
            {
                this.MdiChildren[0].Close();
            }
        }
        private void Login()
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
        // TSMI Generation Methods
        // -----------------------------------------------------------------------
        private ToolStripMenuItem MenuWarehouese()
        {   
            // main menu item, the root.
            ToolStripMenuItem tsmiMain = new ToolStripMenuItem("Warehouse");
            // Menu items
            tsmiMain.DropDownItems.Add(MenuItemAddOpenStock());
            tsmiMain.DropDownItems.Add(new ToolStripSeparator());
            tsmiMain.DropDownItems.Add(MenuItemAddOpenCurrentActiveOrders());
            // tsmiMain.DropDownItems.Add();
            return tsmiMain;
        }
        private ToolStripMenuItem MenuSales()
        {   
            // main menu item, the root.
            ToolStripMenuItem tsmiMain = new ToolStripMenuItem("Sales");
            // Menu items  
            tsmiMain.DropDownItems.Add(MenuItemNewOrders());   
            tsmiMain.DropDownItems.Add(MenuItemAddOpenCurrentActiveOrders());
            tsmiMain.DropDownItems.Add(new ToolStripSeparator());
            tsmiMain.DropDownItems.Add(MenuItemAddOpenStock());
            tsmiMain.DropDownItems.Add(new ToolStripSeparator());
            tsmiMain.DropDownItems.Add(MenuItemAddOpenCustomers());
            tsmiMain.DropDownItems.Add(MenuItemOpenCompanyes());
            return tsmiMain;
        }
        private ToolStripMenuItem MenuAdmin()
        {   // main menu item, the root.
            ToolStripMenuItem tsmiMain = new ToolStripMenuItem("Admin");
            // Menu items
            tsmiMain.DropDownItems.Add(MenuItemAddOpenUsers());       
            return tsmiMain;
        }
        private ToolStripMenuItem MenuItemAddOpenStock()
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem("Open Stock");
            tsmi.Click += OpenStock_Click;
            return tsmi;
        }
        private ToolStripMenuItem MenuItemAddOpenCustomers()
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem("Open Customers");
            tsmi.Click += OpenCustomers_Click;
            return tsmi;
        }
        private ToolStripMenuItem MenuItemAddOpenCurrentActiveOrders()
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem("Open Current Orders");
            tsmi.Click += OpenCurrentActiveOrders_Click;
            return tsmi;
        }
        private ToolStripMenuItem MenuItemAddOpenUsers()
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem("Administre Users");
            tsmi.Click += OpenUsers_Click;
            return tsmi;
        }
        private ToolStripMenuItem MenuItemOpenCompanyes()
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem("Open Companys");
            tsmi.Click += OpenCompanies_Click;
            return tsmi;
        }
        private ToolStripMenuItem MenuItemNewOrders()
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem("New Order");
            tsmi.Click += NewOrder_Click;
            return tsmi;
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
        private void MainLoad(object sender, EventArgs e)
        {
            Log.System("Opening Login Form");
            Login();
        }
        private void OpenStock_Click(object sender, EventArgs e)
        {
            Log.System("Opening Orders Administration Form");
            AddChildMdi(new WareHouse(_Credentials.SecurityToken));
        }
        private void NewOrder_Click(object sender, EventArgs e)
        {
            Log.System("Opening Orders Administration Form");
            AddChildMdi(new NewOrder(_Credentials));
        }
        private void OpenCustomers_Click(object sender, EventArgs e)
        {
            Log.System("Opening Customers Administration Form");
            AddChildMdi(new CustomersAdministration());
        }
        private void OpenCompanies_Click(object sender, EventArgs e)
        {
            Log.System("Opening Companies Administration Form");
            AddChildMdi(new CompanysAdministration());
        }
        private void OpenCurrentActiveOrders_Click(object sender, EventArgs e)
        {
            Log.System("Opening Orders Administration Form");
            AddChildMdi(new OrderAdministration());
        }
        private void OpenUsers_Click(object sender, EventArgs e)
        {
            Log.System("Opening Users Administration Form");
            AddChildMdi(new UsersAdministration());
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsmiLogOut_Click(object sender, EventArgs e)
        {
            _Credentials = null;
            Lockdown();
            Log.System("Logging out");
            Login();
        }
    }
}
