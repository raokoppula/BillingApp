namespace BillingApp
{
    partial class BillingAppMDI
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cOMPANYMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCompanyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCompanyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterCompanyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCompanyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reOpenDayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityControlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRightsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synchronisationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synchonisationReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTallyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromExcelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mASTERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSACTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sYSTEMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPANYMenu,
            this.mASTERSToolStripMenuItem,
            this.tRANSACTIONToolStripMenuItem,
            this.rEPORTSToolStripMenuItem,
            this.sYSTEMSToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cOMPANYMenu
            // 
            this.cOMPANYMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectCompanyMenuItem,
            this.createCompanyMenuItem,
            this.alterCompanyMenuItem,
            this.deleteCompanyMenuItem,
            this.openDayMenuItem,
            this.closeDayMenuItem,
            this.reOpenDayMenuItem,
            this.securityControlMenuItem,
            this.dataMenuItem,
            this.exitMenuItem});
            this.cOMPANYMenu.Name = "cOMPANYMenu";
            this.cOMPANYMenu.Size = new System.Drawing.Size(78, 20);
            this.cOMPANYMenu.Text = "COMPANY";
            // 
            // selectCompanyMenuItem
            // 
            this.selectCompanyMenuItem.Name = "selectCompanyMenuItem";
            this.selectCompanyMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectCompanyMenuItem.Text = "Select Company";
            // 
            // createCompanyMenuItem
            // 
            this.createCompanyMenuItem.Name = "createCompanyMenuItem";
            this.createCompanyMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createCompanyMenuItem.Text = "Create Company";
            this.createCompanyMenuItem.Click += new System.EventHandler(this.createCompanyMenuItem_Click);
            // 
            // alterCompanyMenuItem
            // 
            this.alterCompanyMenuItem.Name = "alterCompanyMenuItem";
            this.alterCompanyMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterCompanyMenuItem.Text = "Alter Company";
            // 
            // deleteCompanyMenuItem
            // 
            this.deleteCompanyMenuItem.Name = "deleteCompanyMenuItem";
            this.deleteCompanyMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteCompanyMenuItem.Text = "Delete Company";
            // 
            // openDayMenuItem
            // 
            this.openDayMenuItem.Name = "openDayMenuItem";
            this.openDayMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openDayMenuItem.Text = "Open Day";
            // 
            // closeDayMenuItem
            // 
            this.closeDayMenuItem.Name = "closeDayMenuItem";
            this.closeDayMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeDayMenuItem.Text = "Close Day";
            // 
            // reOpenDayMenuItem
            // 
            this.reOpenDayMenuItem.Name = "reOpenDayMenuItem";
            this.reOpenDayMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reOpenDayMenuItem.Text = "ReOpen Day";
            // 
            // securityControlMenuItem
            // 
            this.securityControlMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserMenuItem,
            this.userRightsMenuItem,
            this.usersListMenuItem});
            this.securityControlMenuItem.Name = "securityControlMenuItem";
            this.securityControlMenuItem.Size = new System.Drawing.Size(180, 22);
            this.securityControlMenuItem.Text = "Security Control";
            // 
            // createUserMenuItem
            // 
            this.createUserMenuItem.Name = "createUserMenuItem";
            this.createUserMenuItem.Size = new System.Drawing.Size(134, 22);
            this.createUserMenuItem.Text = "Create User";
            // 
            // userRightsMenuItem
            // 
            this.userRightsMenuItem.Name = "userRightsMenuItem";
            this.userRightsMenuItem.Size = new System.Drawing.Size(134, 22);
            this.userRightsMenuItem.Text = "User Rights";
            // 
            // usersListMenuItem
            // 
            this.usersListMenuItem.Name = "usersListMenuItem";
            this.usersListMenuItem.Size = new System.Drawing.Size(134, 22);
            this.usersListMenuItem.Text = "Users List";
            // 
            // dataMenuItem
            // 
            this.dataMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupMenuItem,
            this.restoreMenuItem,
            this.synchronisationMenuItem,
            this.synchonisationReportMenuItem,
            this.exportToTallyMenuItem,
            this.schedulerMenuItem,
            this.importFromExcelMenuItem});
            this.dataMenuItem.Name = "dataMenuItem";
            this.dataMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataMenuItem.Text = "Data";
            // 
            // backupMenuItem
            // 
            this.backupMenuItem.Name = "backupMenuItem";
            this.backupMenuItem.Size = new System.Drawing.Size(228, 22);
            this.backupMenuItem.Text = "Backup";
            // 
            // restoreMenuItem
            // 
            this.restoreMenuItem.Name = "restoreMenuItem";
            this.restoreMenuItem.Size = new System.Drawing.Size(228, 22);
            this.restoreMenuItem.Text = "Restore";
            // 
            // synchronisationMenuItem
            // 
            this.synchronisationMenuItem.Name = "synchronisationMenuItem";
            this.synchronisationMenuItem.Size = new System.Drawing.Size(228, 22);
            this.synchronisationMenuItem.Text = "Synchronisation";
            // 
            // synchonisationReportMenuItem
            // 
            this.synchonisationReportMenuItem.Name = "synchonisationReportMenuItem";
            this.synchonisationReportMenuItem.Size = new System.Drawing.Size(228, 22);
            this.synchonisationReportMenuItem.Text = "Synchonisation Status Report";
            // 
            // exportToTallyMenuItem
            // 
            this.exportToTallyMenuItem.Name = "exportToTallyMenuItem";
            this.exportToTallyMenuItem.Size = new System.Drawing.Size(228, 22);
            this.exportToTallyMenuItem.Text = "Export to Tally";
            // 
            // schedulerMenuItem
            // 
            this.schedulerMenuItem.Name = "schedulerMenuItem";
            this.schedulerMenuItem.Size = new System.Drawing.Size(228, 22);
            this.schedulerMenuItem.Text = "Scheduler";
            // 
            // importFromExcelMenuItem
            // 
            this.importFromExcelMenuItem.Name = "importFromExcelMenuItem";
            this.importFromExcelMenuItem.Size = new System.Drawing.Size(228, 22);
            this.importFromExcelMenuItem.Text = "Import from Excel";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // mASTERSToolStripMenuItem
            // 
            this.mASTERSToolStripMenuItem.Name = "mASTERSToolStripMenuItem";
            this.mASTERSToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.mASTERSToolStripMenuItem.Text = "MASTERS";
            // 
            // tRANSACTIONToolStripMenuItem
            // 
            this.tRANSACTIONToolStripMenuItem.Name = "tRANSACTIONToolStripMenuItem";
            this.tRANSACTIONToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.tRANSACTIONToolStripMenuItem.Text = "TRANSACTION";
            // 
            // rEPORTSToolStripMenuItem
            // 
            this.rEPORTSToolStripMenuItem.Name = "rEPORTSToolStripMenuItem";
            this.rEPORTSToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.rEPORTSToolStripMenuItem.Text = "REPORTS";
            // 
            // sYSTEMSToolStripMenuItem
            // 
            this.sYSTEMSToolStripMenuItem.Name = "sYSTEMSToolStripMenuItem";
            this.sYSTEMSToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.sYSTEMSToolStripMenuItem.Text = "SYSTEMS";
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // BillingAppMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BillingApp.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BillingAppMDI";
            this.Text = "BillingAppMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BillingAppMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cOMPANYMenu;
        private System.Windows.Forms.ToolStripMenuItem selectCompanyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mASTERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANSACTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sYSTEMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCompanyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterCompanyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCompanyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeDayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reOpenDayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityControlMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRightsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreMenuItem;
        private System.Windows.Forms.ToolStripMenuItem synchronisationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem synchonisationReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToTallyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromExcelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    }
}