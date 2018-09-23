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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
            this.legalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newContractAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addendumAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminationAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
            this.SplitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem,
            this.legalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1208, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
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
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // SplitContainerMain
            // 
            this.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerMain.Location = new System.Drawing.Point(0, 25);
            this.SplitContainerMain.Name = "SplitContainerMain";
            // 
            // SplitContainerMain.Panel1
            // 
            this.SplitContainerMain.Panel1.AutoScroll = true;
            this.SplitContainerMain.Panel1.Resize += new System.EventHandler(this.SplitContainerMain_Panel1_Resize);
            // 
            // SplitContainerMain.Panel2
            // 
            this.SplitContainerMain.Panel2.AutoScroll = true;
            this.SplitContainerMain.Size = new System.Drawing.Size(1208, 720);
            this.SplitContainerMain.SplitterDistance = 512;
            this.SplitContainerMain.TabIndex = 1;
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 745);
            this.Controls.Add(this.SplitContainerMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Melbourne Design Group";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).EndInit();
            this.SplitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        public System.Windows.Forms.SplitContainer SplitContainerMain;
        private System.Windows.Forms.ToolStripMenuItem legalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newContractAgreementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addendumAgreementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminationAgreementToolStripMenuItem;
    }
}