namespace MDG.UserControls.MainMenu
{
    partial class JobForm
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblJobNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmdNew = new System.Windows.Forms.Button();
            this.cmsNew = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmdNewContract = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdNewAddendum = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdNewTermination = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdModify = new System.Windows.Forms.Button();
            this.cmsModify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmdModifyJob = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdModifyContract = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdModifyAddendum = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdModifyTermination = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsNew.SuspendLayout();
            this.cmsModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Job Name";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(3, 43);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(68, 19);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer";
            // 
            // lblJobNumber
            // 
            this.lblJobNumber.AutoSize = true;
            this.lblJobNumber.Location = new System.Drawing.Point(3, 24);
            this.lblJobNumber.Name = "lblJobNumber";
            this.lblJobNumber.Size = new System.Drawing.Size(85, 19);
            this.lblJobNumber.TabIndex = 2;
            this.lblJobNumber.Text = "Job Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(26, 81);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(86, 57);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Line 1\r\nLine 2\r\nCity, ST ZIP";
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(3, 141);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(100, 26);
            this.cmdNew.TabIndex = 5;
            this.cmdNew.Text = "New";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // cmsNew
            // 
            this.cmsNew.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdNewContract,
            this.cmdNewAddendum,
            this.cmdNewTermination});
            this.cmsNew.Name = "cmsNew";
            this.cmsNew.Size = new System.Drawing.Size(181, 92);
            // 
            // cmdNewContract
            // 
            this.cmdNewContract.Name = "cmdNewContract";
            this.cmdNewContract.Size = new System.Drawing.Size(180, 22);
            this.cmdNewContract.Text = "New Contract";
            this.cmdNewContract.Click += new System.EventHandler(this.cmdNewContract_Click);
            // 
            // cmdNewAddendum
            // 
            this.cmdNewAddendum.Name = "cmdNewAddendum";
            this.cmdNewAddendum.Size = new System.Drawing.Size(180, 22);
            this.cmdNewAddendum.Text = "New Addendum";
            // 
            // cmdNewTermination
            // 
            this.cmdNewTermination.Name = "cmdNewTermination";
            this.cmdNewTermination.Size = new System.Drawing.Size(180, 22);
            this.cmdNewTermination.Text = "New Termination";
            // 
            // cmdModify
            // 
            this.cmdModify.Location = new System.Drawing.Point(109, 141);
            this.cmdModify.Name = "cmdModify";
            this.cmdModify.Size = new System.Drawing.Size(100, 26);
            this.cmdModify.TabIndex = 7;
            this.cmdModify.Text = "Modify";
            this.cmdModify.UseVisualStyleBackColor = true;
            this.cmdModify.Click += new System.EventHandler(this.cmdModify_Click);
            // 
            // cmsModify
            // 
            this.cmsModify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdModifyJob,
            this.cmdModifyContract,
            this.cmdModifyAddendum,
            this.cmdModifyTermination});
            this.cmsModify.Name = "cmsNew";
            this.cmsModify.Size = new System.Drawing.Size(180, 92);
            // 
            // cmdModifyJob
            // 
            this.cmdModifyJob.Name = "cmdModifyJob";
            this.cmdModifyJob.Size = new System.Drawing.Size(179, 22);
            this.cmdModifyJob.Text = "Modify Job";
            // 
            // cmdModifyContract
            // 
            this.cmdModifyContract.Name = "cmdModifyContract";
            this.cmdModifyContract.Size = new System.Drawing.Size(179, 22);
            this.cmdModifyContract.Text = "Modify Contract";
            // 
            // cmdModifyAddendum
            // 
            this.cmdModifyAddendum.Name = "cmdModifyAddendum";
            this.cmdModifyAddendum.Size = new System.Drawing.Size(179, 22);
            this.cmdModifyAddendum.Text = "Modify Addendum";
            // 
            // cmdModifyTermination
            // 
            this.cmdModifyTermination.Name = "cmdModifyTermination";
            this.cmdModifyTermination.Size = new System.Drawing.Size(179, 22);
            this.cmdModifyTermination.Text = "Modify Termination";
            // 
            // JobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdModify);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJobNumber);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.Size = new System.Drawing.Size(484, 170);
            this.cmsNew.ResumeLayout(false);
            this.cmsModify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.ContextMenuStrip cmsNew;
        private System.Windows.Forms.ToolStripMenuItem cmdNewContract;
        private System.Windows.Forms.ToolStripMenuItem cmdNewAddendum;
        private System.Windows.Forms.ToolStripMenuItem cmdNewTermination;
        private System.Windows.Forms.Button cmdModify;
        private System.Windows.Forms.ContextMenuStrip cmsModify;
        private System.Windows.Forms.ToolStripMenuItem cmdModifyJob;
        private System.Windows.Forms.ToolStripMenuItem cmdModifyContract;
        private System.Windows.Forms.ToolStripMenuItem cmdModifyAddendum;
        private System.Windows.Forms.ToolStripMenuItem cmdModifyTermination;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblCustomer;
        public System.Windows.Forms.Label lblJobNumber;
        public System.Windows.Forms.Label lblAddress;
    }
}
