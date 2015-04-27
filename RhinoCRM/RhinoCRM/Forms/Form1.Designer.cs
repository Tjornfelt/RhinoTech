namespace RhinoCRM.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFiles});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1130, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // tsmiFiles
            // 
            this.tsmiFiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogOut,
            this.toolStripSeparator1,
            this.tsmiQuit});
            this.tsmiFiles.Name = "tsmiFiles";
            this.tsmiFiles.Size = new System.Drawing.Size(42, 20);
            this.tsmiFiles.Text = "Files";
            // 
            // tsmiLogOut
            // 
            this.tsmiLogOut.Name = "tsmiLogOut";
            this.tsmiLogOut.Size = new System.Drawing.Size(112, 22);
            this.tsmiLogOut.Text = "Logout";
            this.tsmiLogOut.Click += new System.EventHandler(this.tsmiLogOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(112, 22);
            this.tsmiQuit.Text = "Quit";
            this.tsmiQuit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 648);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.Text = "RhinoCRM";
            this.Load += new System.EventHandler(this.MainLoad);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFiles;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

