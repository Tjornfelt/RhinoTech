namespace RhinoCRM.Forms
{
    partial class OrderAdministration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderAdministration));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spcCompanyInfo = new System.Windows.Forms.SplitContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.spcCostumerInfo = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCustomerNumber = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPhoneACode = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FullSplit = new System.Windows.Forms.SplitContainer();
            this.dgvOrdersOverview = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getOrdersInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rCMSDataSet = new RhinoCRM.RCMSDataSet();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isShippedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.getOrderItemsByIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getOrdersInfoTableAdapter = new RhinoCRM.RCMSDataSetTableAdapters.GetOrdersInfoTableAdapter();
            this.getOrderItemsByIDTableAdapter = new RhinoCRM.RCMSDataSetTableAdapters.GetOrderItemsByIDTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcCompanyInfo)).BeginInit();
            this.spcCompanyInfo.Panel1.SuspendLayout();
            this.spcCompanyInfo.Panel2.SuspendLayout();
            this.spcCompanyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcCostumerInfo)).BeginInit();
            this.spcCostumerInfo.Panel1.SuspendLayout();
            this.spcCostumerInfo.Panel2.SuspendLayout();
            this.spcCostumerInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FullSplit)).BeginInit();
            this.FullSplit.Panel1.SuspendLayout();
            this.FullSplit.Panel2.SuspendLayout();
            this.FullSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersOverview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrdersInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCMSDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderItemsByIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.spcCompanyInfo);
            this.groupBox1.Controls.Add(this.spcCostumerInfo);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(6, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 242);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // spcCompanyInfo
            // 
            this.spcCompanyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spcCompanyInfo.IsSplitterFixed = true;
            this.spcCompanyInfo.Location = new System.Drawing.Point(10, 150);
            this.spcCompanyInfo.Name = "spcCompanyInfo";
            // 
            // spcCompanyInfo.Panel1
            // 
            this.spcCompanyInfo.Panel1.Controls.Add(this.label11);
            this.spcCompanyInfo.Panel1.Controls.Add(this.label10);
            this.spcCompanyInfo.Panel1.Controls.Add(this.tbAddress);
            this.spcCompanyInfo.Panel1.Controls.Add(this.tbPostalCode);
            // 
            // spcCompanyInfo.Panel2
            // 
            this.spcCompanyInfo.Panel2.Controls.Add(this.label8);
            this.spcCompanyInfo.Panel2.Controls.Add(this.label4);
            this.spcCompanyInfo.Panel2.Controls.Add(this.label5);
            this.spcCompanyInfo.Panel2.Controls.Add(this.tbCountry);
            this.spcCompanyInfo.Panel2.Controls.Add(this.tbState);
            this.spcCompanyInfo.Panel2.Controls.Add(this.tbCity);
            this.spcCompanyInfo.Size = new System.Drawing.Size(638, 80);
            this.spcCompanyInfo.SplitterDistance = 314;
            this.spcCompanyInfo.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Postal Code";
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Location = new System.Drawing.Point(76, 7);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(234, 20);
            this.tbAddress.TabIndex = 13;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPostalCode.Location = new System.Drawing.Point(76, 33);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.ReadOnly = true;
            this.tbPostalCode.Size = new System.Drawing.Size(234, 20);
            this.tbPostalCode.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "City";
            // 
            // tbCountry
            // 
            this.tbCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCountry.Location = new System.Drawing.Point(67, 59);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.ReadOnly = true;
            this.tbCountry.Size = new System.Drawing.Size(248, 20);
            this.tbCountry.TabIndex = 17;
            // 
            // tbState
            // 
            this.tbState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbState.Location = new System.Drawing.Point(67, 33);
            this.tbState.Name = "tbState";
            this.tbState.ReadOnly = true;
            this.tbState.Size = new System.Drawing.Size(248, 20);
            this.tbState.TabIndex = 16;
            // 
            // tbCity
            // 
            this.tbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCity.Location = new System.Drawing.Point(67, 7);
            this.tbCity.Name = "tbCity";
            this.tbCity.ReadOnly = true;
            this.tbCity.Size = new System.Drawing.Size(248, 20);
            this.tbCity.TabIndex = 15;
            // 
            // spcCostumerInfo
            // 
            this.spcCostumerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spcCostumerInfo.IsSplitterFixed = true;
            this.spcCostumerInfo.Location = new System.Drawing.Point(6, 19);
            this.spcCostumerInfo.Name = "spcCostumerInfo";
            // 
            // spcCostumerInfo.Panel1
            // 
            this.spcCostumerInfo.Panel1.Controls.Add(this.label6);
            this.spcCostumerInfo.Panel1.Controls.Add(this.label1);
            this.spcCostumerInfo.Panel1.Controls.Add(this.tbLastname);
            this.spcCostumerInfo.Panel1.Controls.Add(this.label2);
            this.spcCostumerInfo.Panel1.Controls.Add(this.tbCustomerNumber);
            this.spcCostumerInfo.Panel1.Controls.Add(this.tbFirstName);
            // 
            // spcCostumerInfo.Panel2
            // 
            this.spcCostumerInfo.Panel2.Controls.Add(this.label9);
            this.spcCostumerInfo.Panel2.Controls.Add(this.label7);
            this.spcCostumerInfo.Panel2.Controls.Add(this.tbPhoneACode);
            this.spcCostumerInfo.Panel2.Controls.Add(this.tbPhoneNumber);
            this.spcCostumerInfo.Size = new System.Drawing.Size(642, 85);
            this.spcCostumerInfo.SplitterDistance = 318;
            this.spcCostumerInfo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Number";
            // 
            // tbLastname
            // 
            this.tbLastname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastname.Location = new System.Drawing.Point(77, 56);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.ReadOnly = true;
            this.tbLastname.Size = new System.Drawing.Size(238, 20);
            this.tbLastname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // tbCustomerNumber
            // 
            this.tbCustomerNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomerNumber.Location = new System.Drawing.Point(109, 4);
            this.tbCustomerNumber.Name = "tbCustomerNumber";
            this.tbCustomerNumber.ReadOnly = true;
            this.tbCustomerNumber.Size = new System.Drawing.Size(206, 20);
            this.tbCustomerNumber.TabIndex = 5;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Location = new System.Drawing.Point(77, 30);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(238, 20);
            this.tbFirstName.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Phone AreaCode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Phone Number";
            // 
            // tbPhoneACode
            // 
            this.tbPhoneACode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhoneACode.Location = new System.Drawing.Point(104, 30);
            this.tbPhoneACode.Name = "tbPhoneACode";
            this.tbPhoneACode.ReadOnly = true;
            this.tbPhoneACode.Size = new System.Drawing.Size(211, 20);
            this.tbPhoneACode.TabIndex = 7;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(104, 56);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.ReadOnly = true;
            this.tbPhoneNumber.Size = new System.Drawing.Size(211, 20);
            this.tbPhoneNumber.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbCompanyName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(7, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(642, 126);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Company";
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCompanyName.Location = new System.Drawing.Point(76, 13);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.ReadOnly = true;
            this.tbCompanyName.Size = new System.Drawing.Size(560, 20);
            this.tbCompanyName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.FullSplit);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 598);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ActiveOrders";
            // 
            // FullSplit
            // 
            this.FullSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullSplit.Location = new System.Drawing.Point(6, 19);
            this.FullSplit.Name = "FullSplit";
            this.FullSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // FullSplit.Panel1
            // 
            this.FullSplit.Panel1.Controls.Add(this.dgvOrdersOverview);
            // 
            // FullSplit.Panel2
            // 
            this.FullSplit.Panel2.Controls.Add(this.groupBox4);
            this.FullSplit.Size = new System.Drawing.Size(673, 576);
            this.FullSplit.SplitterDistance = 169;
            this.FullSplit.TabIndex = 13;
            // 
            // dgvOrdersOverview
            // 
            this.dgvOrdersOverview.AllowUserToAddRows = false;
            this.dgvOrdersOverview.AllowUserToDeleteRows = false;
            this.dgvOrdersOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrdersOverview.AutoGenerateColumns = false;
            this.dgvOrdersOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdersOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.initialsDataGridViewTextBoxColumn});
            this.dgvOrdersOverview.DataSource = this.getOrdersInfoBindingSource;
            this.dgvOrdersOverview.Location = new System.Drawing.Point(3, 3);
            this.dgvOrdersOverview.Name = "dgvOrdersOverview";
            this.dgvOrdersOverview.ReadOnly = true;
            this.dgvOrdersOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdersOverview.Size = new System.Drawing.Size(661, 160);
            this.dgvOrdersOverview.TabIndex = 11;
            this.dgvOrdersOverview.SelectionChanged += new System.EventHandler(this.dgvOrdersOverview_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // initialsDataGridViewTextBoxColumn
            // 
            this.initialsDataGridViewTextBoxColumn.DataPropertyName = "Initials";
            this.initialsDataGridViewTextBoxColumn.HeaderText = "Initials";
            this.initialsDataGridViewTextBoxColumn.Name = "initialsDataGridViewTextBoxColumn";
            this.initialsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getOrdersInfoBindingSource
            // 
            this.getOrdersInfoBindingSource.DataMember = "GetOrdersInfo";
            this.getOrdersInfoBindingSource.DataSource = this.rCMSDataSet;
            // 
            // rCMSDataSet
            // 
            this.rCMSDataSet.DataSetName = "RCMSDataSet";
            this.rCMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.dgvOrderItems);
            this.groupBox4.Location = new System.Drawing.Point(3, -2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(667, 402);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order Details";
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.AllowUserToAddRows = false;
            this.dgvOrderItems.AllowUserToDeleteRows = false;
            this.dgvOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderItems.AutoGenerateColumns = false;
            this.dgvOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.isShippedDataGridViewCheckBoxColumn});
            this.dgvOrderItems.DataSource = this.getOrderItemsByIDBindingSource;
            this.dgvOrderItems.Location = new System.Drawing.Point(6, 19);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.Size = new System.Drawing.Size(655, 129);
            this.dgvOrderItems.TabIndex = 11;
            this.dgvOrderItems.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvOrderItems_CellBeginEdit);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // isShippedDataGridViewCheckBoxColumn
            // 
            this.isShippedDataGridViewCheckBoxColumn.DataPropertyName = "isShipped";
            this.isShippedDataGridViewCheckBoxColumn.HeaderText = "isShipped";
            this.isShippedDataGridViewCheckBoxColumn.Name = "isShippedDataGridViewCheckBoxColumn";
            // 
            // getOrderItemsByIDBindingSource
            // 
            this.getOrderItemsByIDBindingSource.DataMember = "GetOrderItemsByID";
            this.getOrderItemsByIDBindingSource.DataSource = this.rCMSDataSet;
            // 
            // getOrdersInfoTableAdapter
            // 
            this.getOrdersInfoTableAdapter.ClearBeforeFill = true;
            // 
            // getOrderItemsByIDTableAdapter
            // 
            this.getOrderItemsByIDTableAdapter.ClearBeforeFill = true;
            // 
            // OrderAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 622);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderAdministration";
            this.Text = "ActiveOrders";
            this.Load += new System.EventHandler(this.OrderAdministration_Load);
            this.groupBox1.ResumeLayout(false);
            this.spcCompanyInfo.Panel1.ResumeLayout(false);
            this.spcCompanyInfo.Panel1.PerformLayout();
            this.spcCompanyInfo.Panel2.ResumeLayout(false);
            this.spcCompanyInfo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcCompanyInfo)).EndInit();
            this.spcCompanyInfo.ResumeLayout(false);
            this.spcCostumerInfo.Panel1.ResumeLayout(false);
            this.spcCostumerInfo.Panel1.PerformLayout();
            this.spcCostumerInfo.Panel2.ResumeLayout(false);
            this.spcCostumerInfo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcCostumerInfo)).EndInit();
            this.spcCostumerInfo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.FullSplit.Panel1.ResumeLayout(false);
            this.FullSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FullSplit)).EndInit();
            this.FullSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersOverview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrdersInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCMSDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderItemsByIDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer spcCompanyInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.SplitContainer spcCostumerInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCustomerNumber;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPhoneACode;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.DataGridView dgvOrdersOverview;
        private RCMSDataSet rCMSDataSet;
        private System.Windows.Forms.BindingSource getOrdersInfoBindingSource;
        private RCMSDataSetTableAdapters.GetOrdersInfoTableAdapter getOrdersInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isShippedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource getOrderItemsByIDBindingSource;
        private RCMSDataSetTableAdapters.GetOrderItemsByIDTableAdapter getOrderItemsByIDTableAdapter;
        private System.Windows.Forms.SplitContainer FullSplit;

    }
}