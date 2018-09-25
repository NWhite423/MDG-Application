namespace MDG.Forms
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newContractAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addendumAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminationAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNew = new System.Windows.Forms.MenuStrip();
            this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
            this.CustomerInfo = new MDG.UserControls.CustomerPanelUC();
            this.menuStripNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
            this.SplitContainerMain.Panel2.SuspendLayout();
            this.SplitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 19);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // legalToolStripMenuItem
            // 
            this.legalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newContractAgreementToolStripMenuItem,
            this.addendumAgreementToolStripMenuItem,
            this.terminationAgreementToolStripMenuItem});
            this.legalToolStripMenuItem.Name = "legalToolStripMenuItem";
            this.legalToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.legalToolStripMenuItem.Text = "Legal";
            // 
            // newContractAgreementToolStripMenuItem
            // 
            this.newContractAgreementToolStripMenuItem.Name = "newContractAgreementToolStripMenuItem";
            this.newContractAgreementToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.newContractAgreementToolStripMenuItem.Text = "New Contract Agreement";
            this.newContractAgreementToolStripMenuItem.Click += new System.EventHandler(this.newContractAgreementToolStripMenuItem_Click);
            // 
            // addendumAgreementToolStripMenuItem
            // 
            this.addendumAgreementToolStripMenuItem.Name = "addendumAgreementToolStripMenuItem";
            this.addendumAgreementToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.addendumAgreementToolStripMenuItem.Text = "Addendum Agreement";
            // 
            // terminationAgreementToolStripMenuItem
            // 
            this.terminationAgreementToolStripMenuItem.Name = "terminationAgreementToolStripMenuItem";
            this.terminationAgreementToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.terminationAgreementToolStripMenuItem.Text = "Termination Agreement";
            // 
            // menuStripNew
            // 
            this.menuStripNew.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem,
            this.legalToolStripMenuItem});
            this.menuStripNew.Location = new System.Drawing.Point(0, 0);
            this.menuStripNew.Name = "menuStripNew";
            this.menuStripNew.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripNew.Size = new System.Drawing.Size(1208, 25);
            this.menuStripNew.TabIndex = 0;
            this.menuStripNew.Text = "menuStrip1";
            // 
            // SplitContainerMain
            // 
            this.SplitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerMain.Location = new System.Drawing.Point(0, 25);
            this.SplitContainerMain.Name = "SplitContainerMain";
            // 
            // SplitContainerMain.Panel1
            // 
            this.SplitContainerMain.Panel1.AutoScroll = true;
            this.SplitContainerMain.Panel1.Resize += new System.EventHandler(this.SplitContainerMain_Panel1_Resize);
            this.SplitContainerMain.Panel1MinSize = 200;
            // 
            // SplitContainerMain.Panel2
            // 
            this.SplitContainerMain.Panel2.AutoScroll = true;
            this.SplitContainerMain.Panel2.Controls.Add(this.CustomerInfo);
            this.SplitContainerMain.Size = new System.Drawing.Size(1208, 694);
            this.SplitContainerMain.SplitterDistance = 350;
            this.SplitContainerMain.SplitterWidth = 2;
            this.SplitContainerMain.TabIndex = 1;
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.AutoScroll = true;
            this.CustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerInfo.Font = new System.Drawing.Font("SansSerif", 12F);
            this.CustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.CustomerInfo.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Size = new System.Drawing.Size(854, 692);
            this.CustomerInfo.TabIndex = 0;
            this.CustomerInfo.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 719);
            this.Controls.Add(this.SplitContainerMain);
            this.Controls.Add(this.menuStripNew);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripNew;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Melbourne Design Group";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.menuStripNew.ResumeLayout(false);
            this.menuStripNew.PerformLayout();
            this.SplitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).EndInit();
            this.SplitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newContractAgreementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addendumAgreementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminationAgreementToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripNew;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.SplitContainer SplitContainerMain;
        private UserControls.CustomerPanelUC CustomerInfo;
    }
}