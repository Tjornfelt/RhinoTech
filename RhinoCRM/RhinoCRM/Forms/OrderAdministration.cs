﻿using RhinoCRM.Core.Entityframework;
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
    public partial class OrderAdministration : BaseRWindow
    {
        public OrderAdministration()
        {
            InitializeComponent();
            LoadUser();
        }
        private void LoadUser()
        {
            Customers[] customerslist = Entities.GetCustomers().ToArray();
            foreach (Customers customers in customerslist)
            {
                cbCustomerID.Items.Add(string.Format("{0:0000}", customers.ID));
            }
        }

    }
}
