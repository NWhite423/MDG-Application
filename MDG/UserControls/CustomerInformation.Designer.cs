namespace MDG.UserControls
{
    partial class CustomerInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdView = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdModify = new System.Windows.Forms.Button();
            this.cmsView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewCustomerInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRepresentatives = new System.Windows.Forms.ToolStripMenuItem();
            this.viewJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.cmsView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(3, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // cmdView
            // 
            this.cmdView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdView.Font = new System.Drawing.Font("SansSerif", 11F);
            this.cmdView.Location = new System.Drawing.Point(251, 3);
            this.cmdView.Name = "cmdView";
            this.cmdView.Size = new System.Drawing.Size(75, 26);
            this.cmdView.TabIndex = 5;
            this.cmdView.Text = "View";
            this.cmdView.UseVisualStyleBackColor = true;
            this.cmdView.Click += new System.EventHandler(this.cmdRep_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDelete.Font = new System.Drawing.Font("SansSerif", 11F);
            this.cmdDelete.Location = new System.Drawing.Point(413, 3);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 26);
            this.cmdDelete.TabIndex = 9;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdModify
            // 
            this.cmdModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdModify.Font = new System.Drawing.Font("SansSerif", 11F);
            this.cmdModify.Location = new System.Drawing.Point(332, 3);
            this.cmdModify.Name = "cmdModify";
            this.cmdModify.Size = new System.Drawing.Size(75, 26);
            this.cmdModify.TabIndex = 7;
            this.cmdModify.Text = "Modify";
            this.cmdModify.UseVisualStyleBackColor = true;
            // 
            // cmsView
            // 
            this.cmsView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCustomerInformation,
            this.viewRepresentatives,
            this.viewJobs,
            this.toolStripSeparator1,
            this.openFileLocation});
            this.cmsView.Name = "cmsView";
            this.cmsView.Size = new System.Drawing.Size(221, 120);
            // 
            // viewCustomerInformation
            // 
            this.viewCustomerInformation.Name = "viewCustomerInformation";
            this.viewCustomerInformation.Size = new System.Drawing.Size(220, 22);
            this.viewCustomerInformation.Text = "View Customer Information";
            // 
            // viewRepresentatives
            // 
            this.viewRepresentatives.Name = "viewRepresentatives";
            this.viewRepresentatives.Size = new System.Drawing.Size(220, 22);
            this.viewRepresentatives.Text = "View Representatives";
            this.viewRepresentatives.Click += new System.EventHandler(this.viewRepresentatives_Click);
            // 
            // viewJobs
            // 
            this.viewJobs.Name = "viewJobs";
            this.viewJobs.Size = new System.Drawing.Size(220, 22);
            this.viewJobs.Text = "View Jobs";
            this.viewJobs.Click += new System.EventHandler(this.viewJobs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // openFileLocation
            // 
            this.openFileLocation.Name = "openFileLocation";
            this.openFileLocation.Size = new System.Drawing.Size(220, 22);
            this.openFileLocation.Text = "Open File Location";
            this.openFileLocation.Click += new System.EventHandler(this.openFileLocation_Click);
            // 
            // lblSeperator
            // 
            this.lblSeperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeperator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeperator.Location = new System.Drawing.Point(0, 32);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(500, 2);
            this.lblSeperator.TabIndex = 10;
            // 
            // CustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSeperator);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdModify);
            this.Controls.Add(this.cmdView);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(500, 34);
            this.Name = "CustomerInformation";
            this.Size = new System.Drawing.Size(500, 34);
            this.cmsView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button cmdDelete;
        public System.Windows.Forms.Button cmdView;
        private System.Windows.Forms.Button cmdModify;
        private System.Windows.Forms.Label lblSeperator;
        public System.Windows.Forms.ContextMenuStrip cmsView;
        public System.Windows.Forms.ToolStripMenuItem viewCustomerInformation;
        public System.Windows.Forms.ToolStripMenuItem viewRepresentatives;
        public System.Windows.Forms.ToolStripMenuItem viewJobs;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem openFileLocation;
    }
}
