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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmdJobs = new System.Windows.Forms.Button();
            this.cmdRep = new System.Windows.Forms.Button();
            this.cmdCreateJob = new System.Windows.Forms.Button();
            this.cmdModify = new System.Windows.Forms.Button();
            this.cmdOpenFileLocation = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(34, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 19);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(103, 38);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Test 1, Test 2\r\nTest, FL 32817";
            // 
            // cmdJobs
            // 
            this.cmdJobs.Location = new System.Drawing.Point(3, 60);
            this.cmdJobs.Name = "cmdJobs";
            this.cmdJobs.Size = new System.Drawing.Size(110, 26);
            this.cmdJobs.TabIndex = 4;
            this.cmdJobs.Text = "View Jobs";
            this.cmdJobs.UseVisualStyleBackColor = true;
            // 
            // cmdRep
            // 
            this.cmdRep.Location = new System.Drawing.Point(119, 60);
            this.cmdRep.Name = "cmdRep";
            this.cmdRep.Size = new System.Drawing.Size(110, 26);
            this.cmdRep.TabIndex = 5;
            this.cmdRep.Text = "View Reps";
            this.cmdRep.UseVisualStyleBackColor = true;
            // 
            // cmdCreateJob
            // 
            this.cmdCreateJob.Location = new System.Drawing.Point(3, 92);
            this.cmdCreateJob.Name = "cmdCreateJob";
            this.cmdCreateJob.Size = new System.Drawing.Size(110, 26);
            this.cmdCreateJob.TabIndex = 6;
            this.cmdCreateJob.Text = "Create Job";
            this.cmdCreateJob.UseVisualStyleBackColor = true;
            this.cmdCreateJob.Click += new System.EventHandler(this.cmdCreateJob_Click);
            // 
            // cmdModify
            // 
            this.cmdModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdModify.Location = new System.Drawing.Point(422, 60);
            this.cmdModify.Name = "cmdModify";
            this.cmdModify.Size = new System.Drawing.Size(110, 26);
            this.cmdModify.TabIndex = 7;
            this.cmdModify.Text = "Modify";
            this.cmdModify.UseVisualStyleBackColor = true;
            // 
            // cmdOpenFileLocation
            // 
            this.cmdOpenFileLocation.Location = new System.Drawing.Point(119, 92);
            this.cmdOpenFileLocation.Name = "cmdOpenFileLocation";
            this.cmdOpenFileLocation.Size = new System.Drawing.Size(110, 26);
            this.cmdOpenFileLocation.TabIndex = 8;
            this.cmdOpenFileLocation.Text = "Open Location";
            this.cmdOpenFileLocation.UseVisualStyleBackColor = true;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDelete.Location = new System.Drawing.Point(422, 92);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(110, 26);
            this.cmdDelete.TabIndex = 9;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // CustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdOpenFileLocation);
            this.Controls.Add(this.cmdModify);
            this.Controls.Add(this.cmdCreateJob);
            this.Controls.Add(this.cmdRep);
            this.Controls.Add(this.cmdJobs);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(348, 5);
            this.Name = "CustomerInformation";
            this.Size = new System.Drawing.Size(535, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button cmdJobs;
        private System.Windows.Forms.Button cmdRep;
        private System.Windows.Forms.Button cmdCreateJob;
        private System.Windows.Forms.Button cmdModify;
        private System.Windows.Forms.Button cmdOpenFileLocation;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button cmdDelete;
    }
}
