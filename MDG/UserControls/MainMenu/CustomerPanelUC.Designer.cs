namespace MDG.UserControls
{
    partial class CustomerPanelUC
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
            this.CustomerName = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.PnlJobs = new System.Windows.Forms.Panel();
            this.CustomerDate = new System.Windows.Forms.Label();
            this.Representatives = new System.Windows.Forms.Label();
            this.lblJobs = new System.Windows.Forms.Label();
            this.ActiveJobs = new System.Windows.Forms.Label();
            this.FinishedJobs = new System.Windows.Forms.Label();
            this.TerminatedJobs = new System.Windows.Forms.Label();
            this.TotalJobs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdJobAdd = new System.Windows.Forms.Button();
            this.cmdRepAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlReps = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerName.Font = new System.Drawing.Font("SansSerif", 16F, System.Drawing.FontStyle.Bold);
            this.CustomerName.Location = new System.Drawing.Point(3, 0);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(494, 27);
            this.CustomerName.TabIndex = 0;
            this.CustomerName.Text = "Company Name";
            this.CustomerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Address
            // 
            this.Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address.Location = new System.Drawing.Point(3, 27);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(494, 19);
            this.Address.TabIndex = 1;
            this.Address.Text = "Company Address";
            this.Address.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Category
            // 
            this.Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Category.Location = new System.Drawing.Point(3, 46);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(494, 19);
            this.Category.TabIndex = 2;
            this.Category.Text = "Company Category";
            this.Category.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PnlJobs
            // 
            this.PnlJobs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlJobs.AutoScroll = true;
            this.PnlJobs.AutoSize = true;
            this.PnlJobs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlJobs.Location = new System.Drawing.Point(3, 238);
            this.PnlJobs.Name = "PnlJobs";
            this.PnlJobs.Size = new System.Drawing.Size(494, 200);
            this.PnlJobs.TabIndex = 4;
            // 
            // CustomerDate
            // 
            this.CustomerDate.AutoSize = true;
            this.CustomerDate.Location = new System.Drawing.Point(3, 65);
            this.CustomerDate.Name = "CustomerDate";
            this.CustomerDate.Size = new System.Drawing.Size(131, 19);
            this.CustomerDate.TabIndex = 6;
            this.CustomerDate.Text = "Customer Since: ";
            // 
            // Representatives
            // 
            this.Representatives.AutoSize = true;
            this.Representatives.Location = new System.Drawing.Point(3, 84);
            this.Representatives.Name = "Representatives";
            this.Representatives.Size = new System.Drawing.Size(133, 19);
            this.Representatives.TabIndex = 7;
            this.Representatives.Text = "Representatives: ";
            // 
            // lblJobs
            // 
            this.lblJobs.AutoSize = true;
            this.lblJobs.Location = new System.Drawing.Point(4, 103);
            this.lblJobs.Name = "lblJobs";
            this.lblJobs.Size = new System.Drawing.Size(47, 19);
            this.lblJobs.TabIndex = 8;
            this.lblJobs.Text = "Jobs:";
            // 
            // ActiveJobs
            // 
            this.ActiveJobs.AutoSize = true;
            this.ActiveJobs.Location = new System.Drawing.Point(30, 122);
            this.ActiveJobs.Name = "ActiveJobs";
            this.ActiveJobs.Size = new System.Drawing.Size(57, 19);
            this.ActiveJobs.TabIndex = 9;
            this.ActiveJobs.Text = "Active:";
            // 
            // FinishedJobs
            // 
            this.FinishedJobs.AutoSize = true;
            this.FinishedJobs.Location = new System.Drawing.Point(30, 141);
            this.FinishedJobs.Name = "FinishedJobs";
            this.FinishedJobs.Size = new System.Drawing.Size(79, 19);
            this.FinishedJobs.TabIndex = 10;
            this.FinishedJobs.Text = "Finished: ";
            // 
            // TerminatedJobs
            // 
            this.TerminatedJobs.AutoSize = true;
            this.TerminatedJobs.Location = new System.Drawing.Point(30, 160);
            this.TerminatedJobs.Name = "TerminatedJobs";
            this.TerminatedJobs.Size = new System.Drawing.Size(94, 19);
            this.TerminatedJobs.TabIndex = 11;
            this.TerminatedJobs.Text = "Terminated:";
            // 
            // TotalJobs
            // 
            this.TotalJobs.AutoSize = true;
            this.TotalJobs.Location = new System.Drawing.Point(30, 179);
            this.TotalJobs.Name = "TotalJobs";
            this.TotalJobs.Size = new System.Drawing.Size(49, 19);
            this.TotalJobs.TabIndex = 12;
            this.TotalJobs.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Jobs:";
            // 
            // cmdJobAdd
            // 
            this.cmdJobAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdJobAdd.Location = new System.Drawing.Point(422, 212);
            this.cmdJobAdd.Name = "cmdJobAdd";
            this.cmdJobAdd.Size = new System.Drawing.Size(75, 26);
            this.cmdJobAdd.TabIndex = 14;
            this.cmdJobAdd.Text = "Add";
            this.cmdJobAdd.UseVisualStyleBackColor = true;
            // 
            // cmdRepAdd
            // 
            this.cmdRepAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRepAdd.Location = new System.Drawing.Point(422, 444);
            this.cmdRepAdd.Name = "cmdRepAdd";
            this.cmdRepAdd.Size = new System.Drawing.Size(75, 26);
            this.cmdRepAdd.TabIndex = 17;
            this.cmdRepAdd.Text = "Add";
            this.cmdRepAdd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Representatives:";
            // 
            // PnlReps
            // 
            this.PnlReps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlReps.AutoScroll = true;
            this.PnlReps.AutoSize = true;
            this.PnlReps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlReps.Location = new System.Drawing.Point(3, 470);
            this.PnlReps.Name = "PnlReps";
            this.PnlReps.Size = new System.Drawing.Size(494, 200);
            this.PnlReps.TabIndex = 15;
            // 
            // CustomerPanelUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.cmdRepAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PnlReps);
            this.Controls.Add(this.cmdJobAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalJobs);
            this.Controls.Add(this.TerminatedJobs);
            this.Controls.Add(this.FinishedJobs);
            this.Controls.Add(this.ActiveJobs);
            this.Controls.Add(this.lblJobs);
            this.Controls.Add(this.Representatives);
            this.Controls.Add(this.CustomerDate);
            this.Controls.Add(this.PnlJobs);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.CustomerName);
            this.Font = new System.Drawing.Font("SansSerif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerPanelUC";
            this.Size = new System.Drawing.Size(500, 673);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdJobAdd;
        private System.Windows.Forms.Button cmdRepAdd;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label CustomerName;
        public System.Windows.Forms.Label Address;
        public System.Windows.Forms.Label Category;
        public System.Windows.Forms.Panel PnlJobs;
        public System.Windows.Forms.Label CustomerDate;
        public System.Windows.Forms.Label Representatives;
        public System.Windows.Forms.Label ActiveJobs;
        public System.Windows.Forms.Label FinishedJobs;
        public System.Windows.Forms.Label TerminatedJobs;
        public System.Windows.Forms.Label TotalJobs;
        public System.Windows.Forms.Panel PnlReps;
    }
}
