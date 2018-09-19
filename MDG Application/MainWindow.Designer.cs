namespace MDG_Application
{
    partial class MainWindow
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppExit = new System.Windows.Forms.ToolStripMenuItem();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractorAgreement = new System.Windows.Forms.ToolStripMenuItem();
            this.Addendum = new System.Windows.Forms.ToolStripMenuItem();
            this.TerminationAgreement = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.NewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.NewJob = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlData = new System.Windows.Forms.Panel();
            this.DataGridOverview = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jobs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCustomer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MenuStrip.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.documentToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1080, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.AppExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // AppExit
            // 
            this.AppExit.Name = "AppExit";
            this.AppExit.Size = new System.Drawing.Size(180, 22);
            this.AppExit.Text = "Exit";
            this.AppExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // documentToolStripMenuItem
            // 
            this.documentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.Edit});
            this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            this.documentToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.documentToolStripMenuItem.Text = "Document";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContractorAgreement,
            this.Addendum,
            this.TerminationAgreement});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // ContractorAgreement
            // 
            this.ContractorAgreement.Name = "ContractorAgreement";
            this.ContractorAgreement.Size = new System.Drawing.Size(200, 22);
            this.ContractorAgreement.Text = "Contractor Agreement";
            this.ContractorAgreement.Click += new System.EventHandler(this.ContractorAgreement_Click);
            // 
            // Addendum
            // 
            this.Addendum.Name = "Addendum";
            this.Addendum.Size = new System.Drawing.Size(200, 22);
            this.Addendum.Text = "Addendum";
            // 
            // TerminationAgreement
            // 
            this.TerminationAgreement.Name = "TerminationAgreement";
            this.TerminationAgreement.Size = new System.Drawing.Size(200, 22);
            this.TerminationAgreement.Text = "Termination Agreement";
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(108, 22);
            this.Edit.Text = "Edit";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // New
            // 
            this.New.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewCustomer,
            this.NewJob});
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(180, 22);
            this.New.Text = "New";
            // 
            // NewCustomer
            // 
            this.NewCustomer.Name = "NewCustomer";
            this.NewCustomer.Size = new System.Drawing.Size(180, 22);
            this.NewCustomer.Text = "Customer";
            // 
            // NewJob
            // 
            this.NewJob.Name = "NewJob";
            this.NewJob.Size = new System.Drawing.Size(180, 22);
            this.NewJob.Text = "Job";
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlData.Controls.Add(this.DataGridOverview);
            this.pnlData.Location = new System.Drawing.Point(12, 27);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(454, 524);
            this.pnlData.TabIndex = 1;
            // 
            // DataGridOverview
            // 
            this.DataGridOverview.AllowUserToAddRows = false;
            this.DataGridOverview.AllowUserToDeleteRows = false;
            this.DataGridOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.Jobs,
            this.Profit,
            this.EditCustomer});
            this.DataGridOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridOverview.Location = new System.Drawing.Point(0, 0);
            this.DataGridOverview.Name = "DataGridOverview";
            this.DataGridOverview.ReadOnly = true;
            this.DataGridOverview.Size = new System.Drawing.Size(454, 524);
            this.DataGridOverview.TabIndex = 0;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // Jobs
            // 
            this.Jobs.HeaderText = "Jobs";
            this.Jobs.Name = "Jobs";
            this.Jobs.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // EditCustomer
            // 
            this.EditCustomer.HeaderText = "Edit";
            this.EditCustomer.Name = "EditCustomer";
            this.EditCustomer.ReadOnly = true;
            this.EditCustomer.Text = "Edit";
            this.EditCustomer.UseColumnTextForButtonValue = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 563);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainWindow";
            this.Text = "MDG Job Management";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppExit;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractorAgreement;
        private System.Windows.Forms.ToolStripMenuItem Addendum;
        private System.Windows.Forms.ToolStripMenuItem TerminationAgreement;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem NewCustomer;
        private System.Windows.Forms.ToolStripMenuItem NewJob;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView DataGridOverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewButtonColumn EditCustomer;
    }
}

