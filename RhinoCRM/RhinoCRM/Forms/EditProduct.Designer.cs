namespace RhinoCRM.Forms
{
    partial class EditProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spcCostumerInfo = new System.Windows.Forms.SplitContainer();
            this.ckbDiscontinued = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSku = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.spcCompanyInfo = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbShelf = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcCostumerInfo)).BeginInit();
            this.spcCostumerInfo.Panel1.SuspendLayout();
            this.spcCostumerInfo.Panel2.SuspendLayout();
            this.spcCostumerInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcCompanyInfo)).BeginInit();
            this.spcCompanyInfo.Panel1.SuspendLayout();
            this.spcCompanyInfo.Panel2.SuspendLayout();
            this.spcCompanyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.spcCostumerInfo);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description";
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
            this.spcCostumerInfo.Panel1.Controls.Add(this.ckbDiscontinued);
            this.spcCostumerInfo.Panel1.Controls.Add(this.label2);
            this.spcCostumerInfo.Panel1.Controls.Add(this.tbName);
            // 
            // spcCostumerInfo.Panel2
            // 
            this.spcCostumerInfo.Panel2.Controls.Add(this.label6);
            this.spcCostumerInfo.Panel2.Controls.Add(this.tbSku);
            this.spcCostumerInfo.Panel2.Controls.Add(this.tbPrice);
            this.spcCostumerInfo.Panel2.Controls.Add(this.label8);
            this.spcCostumerInfo.Panel2.Controls.Add(this.label3);
            this.spcCostumerInfo.Panel2.Controls.Add(this.tbType);
            this.spcCostumerInfo.Panel2.Controls.Add(this.label7);
            this.spcCostumerInfo.Size = new System.Drawing.Size(439, 81);
            this.spcCostumerInfo.SplitterDistance = 252;
            this.spcCostumerInfo.TabIndex = 2;
            // 
            // ckbDiscontinued
            // 
            this.ckbDiscontinued.AutoSize = true;
            this.ckbDiscontinued.Location = new System.Drawing.Point(66, 32);
            this.ckbDiscontinued.Name = "ckbDiscontinued";
            this.ckbDiscontinued.Size = new System.Drawing.Size(88, 17);
            this.ckbDiscontinued.TabIndex = 8;
            this.ckbDiscontinued.Text = "Discontinued";
            this.ckbDiscontinued.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(66, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(178, 20);
            this.tbName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "[SKU]";
            // 
            // tbSku
            // 
            this.tbSku.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSku.Location = new System.Drawing.Point(44, 6);
            this.tbSku.Name = "tbSku";
            this.tbSku.Size = new System.Drawing.Size(130, 20);
            this.tbSku.TabIndex = 4;
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrice.Location = new System.Drawing.Point(44, 56);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(91, 20);
            this.tbPrice.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "DKK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price";
            // 
            // tbType
            // 
            this.tbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbType.Location = new System.Drawing.Point(44, 30);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(130, 20);
            this.tbType.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Type";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(72, 106);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(370, 66);
            this.tbDescription.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.spcCompanyInfo);
            this.groupBox3.Location = new System.Drawing.Point(7, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 50);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Warehouse Shelf";
            // 
            // spcCompanyInfo
            // 
            this.spcCompanyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spcCompanyInfo.IsSplitterFixed = true;
            this.spcCompanyInfo.Location = new System.Drawing.Point(0, 19);
            this.spcCompanyInfo.Name = "spcCompanyInfo";
            // 
            // spcCompanyInfo.Panel1
            // 
            this.spcCompanyInfo.Panel1.Controls.Add(this.label4);
            this.spcCompanyInfo.Panel1.Controls.Add(this.tbAmount);
            // 
            // spcCompanyInfo.Panel2
            // 
            this.spcCompanyInfo.Panel2.Controls.Add(this.label5);
            this.spcCompanyInfo.Panel2.Controls.Add(this.tbShelf);
            this.spcCompanyInfo.Size = new System.Drawing.Size(433, 25);
            this.spcCompanyInfo.SplitterDistance = 246;
            this.spcCompanyInfo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // tbAmount
            // 
            this.tbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmount.Location = new System.Drawing.Point(65, 3);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(178, 20);
            this.tbAmount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shelf";
            // 
            // tbShelf
            // 
            this.tbShelf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShelf.Location = new System.Drawing.Point(47, 3);
            this.tbShelf.Name = "tbShelf";
            this.tbShelf.Size = new System.Drawing.Size(132, 20);
            this.tbShelf.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(320, 252);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 21);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(395, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 21);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 285);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditProduct";
            this.Text = "Edit Product";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.spcCostumerInfo.Panel1.ResumeLayout(false);
            this.spcCostumerInfo.Panel1.PerformLayout();
            this.spcCostumerInfo.Panel2.ResumeLayout(false);
            this.spcCostumerInfo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcCostumerInfo)).EndInit();
            this.spcCostumerInfo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.spcCompanyInfo.Panel1.ResumeLayout(false);
            this.spcCompanyInfo.Panel1.PerformLayout();
            this.spcCompanyInfo.Panel2.ResumeLayout(false);
            this.spcCompanyInfo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcCompanyInfo)).EndInit();
            this.spcCompanyInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer spcCostumerInfo;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSku;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer spcCompanyInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbShelf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckbDiscontinued;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}