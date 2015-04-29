namespace RhinoCRM.Forms
{
    partial class WareHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouse));
            this.RigthClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.rCMSDataSet = new RhinoCRM.RCMSDataSet();
            this.DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableAddabter = new RhinoCRM.RCMSDataSetTableAdapters.GetTotalProductInfoTableAdapter();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.iDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKUColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discontinuedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RigthClickMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rCMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // RigthClickMenu
            // 
            this.RigthClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit});
            this.RigthClickMenu.Name = "contextMenuStrip1";
            this.RigthClickMenu.Size = new System.Drawing.Size(95, 26);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(94, 22);
            this.tsmiEdit.Text = "Edit";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // rCMSDataSet
            // 
            this.rCMSDataSet.DataSetName = "RCMSDataSet";
            this.rCMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataBindingSource
            // 
            this.DataBindingSource.DataMember = "GetTotalProductInfo";
            this.DataBindingSource.DataSource = this.rCMSDataSet;
            // 
            // TableAddabter
            // 
            this.TableAddabter.ClearBeforeFill = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDColumn,
            this.sKUColumn,
            this.NameColumn,
            this.TypeColumn,
            this.descriptionColumn,
            this.PriceColumn,
            this.amountColumn,
            this.shelfColumn,
            this.discontinuedColumn});
            this.dgvData.ContextMenuStrip = this.RigthClickMenu;
            this.dgvData.DataSource = this.DataBindingSource;
            this.dgvData.Location = new System.Drawing.Point(12, 12);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 20;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(717, 371);
            this.dgvData.TabIndex = 0;
            // 
            // iDColumn
            // 
            this.iDColumn.DataPropertyName = "ID";
            this.iDColumn.FillWeight = 20F;
            this.iDColumn.HeaderText = "ID";
            this.iDColumn.Name = "iDColumn";
            this.iDColumn.Width = 20;
            // 
            // sKUColumn
            // 
            this.sKUColumn.DataPropertyName = "SKU";
            this.sKUColumn.HeaderText = "SKU";
            this.sKUColumn.Name = "sKUColumn";
            this.sKUColumn.Width = 50;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // TypeColumn
            // 
            this.TypeColumn.DataPropertyName = "Type";
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.DataPropertyName = "Description";
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.Name = "descriptionColumn";
            // 
            // PriceColumn
            // 
            this.PriceColumn.DataPropertyName = "Price";
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            // 
            // amountColumn
            // 
            this.amountColumn.DataPropertyName = "Amount";
            this.amountColumn.FillWeight = 50F;
            this.amountColumn.HeaderText = "Amount";
            this.amountColumn.Name = "amountColumn";
            this.amountColumn.Width = 50;
            // 
            // shelfColumn
            // 
            this.shelfColumn.DataPropertyName = "Shelf";
            this.shelfColumn.HeaderText = "Shelf";
            this.shelfColumn.Name = "shelfColumn";
            // 
            // discontinuedColumn
            // 
            this.discontinuedColumn.DataPropertyName = "Discontinued";
            this.discontinuedColumn.HeaderText = "Discontinued";
            this.discontinuedColumn.Name = "discontinuedColumn";
            this.discontinuedColumn.Width = 75;
            // 
            // WareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 395);
            this.Controls.Add(this.dgvData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WareHouse";
            this.Text = "WareHouse";
            this.Load += new System.EventHandler(this.WareHouse_Load);
            this.RigthClickMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rCMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.ContextMenuStrip RigthClickMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private RCMSDataSet rCMSDataSet;
        private System.Windows.Forms.BindingSource DataBindingSource;
        private RCMSDataSetTableAdapters.GetTotalProductInfoTableAdapter TableAddabter;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn discontinuedColumn;
      


    }
}