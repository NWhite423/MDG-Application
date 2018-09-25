namespace MDG.Forms.Legal
{
    partial class NewContract
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.Seperator = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerAddressLine1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerAddressLine2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomerZip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CustomerState = new System.Windows.Forms.ComboBox();
            this.PnlSOW = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdSoWAdd = new System.Windows.Forms.Button();
            this.cmdExpenseAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.PnlExspenses = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.cmbJobs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Job Information:";
            // 
            // Seperator
            // 
            this.Seperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Seperator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Seperator.Location = new System.Drawing.Point(6, 67);
            this.Seperator.Name = "Seperator";
            this.Seperator.Size = new System.Drawing.Size(486, 2);
            this.Seperator.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name:";
            // 
            // CustomerName
            // 
            this.CustomerName.Enabled = false;
            this.CustomerName.Location = new System.Drawing.Point(117, 105);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(375, 26);
            this.CustomerName.TabIndex = 3;
            // 
            // CustomerAddressLine1
            // 
            this.CustomerAddressLine1.Enabled = false;
            this.CustomerAddressLine1.Location = new System.Drawing.Point(117, 137);
            this.CustomerAddressLine1.Name = "CustomerAddressLine1";
            this.CustomerAddressLine1.Size = new System.Drawing.Size(375, 26);
            this.CustomerAddressLine1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address Line 1:";
            // 
            // CustomerAddressLine2
            // 
            this.CustomerAddressLine2.Enabled = false;
            this.CustomerAddressLine2.Location = new System.Drawing.Point(117, 169);
            this.CustomerAddressLine2.Name = "CustomerAddressLine2";
            this.CustomerAddressLine2.Size = new System.Drawing.Size(375, 26);
            this.CustomerAddressLine2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Address Line 2:";
            // 
            // CustomerCity
            // 
            this.CustomerCity.Enabled = false;
            this.CustomerCity.Location = new System.Drawing.Point(117, 201);
            this.CustomerCity.Name = "CustomerCity";
            this.CustomerCity.Size = new System.Drawing.Size(125, 26);
            this.CustomerCity.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "ST:";
            // 
            // CustomerZip
            // 
            this.CustomerZip.Enabled = false;
            this.CustomerZip.Location = new System.Drawing.Point(399, 201);
            this.CustomerZip.Name = "CustomerZip";
            this.CustomerZip.Size = new System.Drawing.Size(93, 26);
            this.CustomerZip.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "ZIP:";
            // 
            // CustomerState
            // 
            this.CustomerState.Enabled = false;
            this.CustomerState.FormattingEnabled = true;
            this.CustomerState.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MN",
            "MO",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
            this.CustomerState.Location = new System.Drawing.Point(283, 201);
            this.CustomerState.Name = "CustomerState";
            this.CustomerState.Size = new System.Drawing.Size(69, 27);
            this.CustomerState.TabIndex = 7;
            // 
            // PnlSOW
            // 
            this.PnlSOW.AutoScroll = true;
            this.PnlSOW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlSOW.Location = new System.Drawing.Point(12, 261);
            this.PnlSOW.Name = "PnlSOW";
            this.PnlSOW.Size = new System.Drawing.Size(480, 204);
            this.PnlSOW.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Scope of Work:";
            // 
            // cmdSoWAdd
            // 
            this.cmdSoWAdd.Location = new System.Drawing.Point(417, 235);
            this.cmdSoWAdd.Name = "cmdSoWAdd";
            this.cmdSoWAdd.Size = new System.Drawing.Size(75, 26);
            this.cmdSoWAdd.TabIndex = 9;
            this.cmdSoWAdd.Text = "Add";
            this.cmdSoWAdd.UseVisualStyleBackColor = true;
            //this.cmdSoWAdd.Click += new System.EventHandler(this.cmdSoWAdd_Click);
            // 
            // cmdExpenseAdd
            // 
            this.cmdExpenseAdd.Location = new System.Drawing.Point(417, 468);
            this.cmdExpenseAdd.Name = "cmdExpenseAdd";
            this.cmdExpenseAdd.Size = new System.Drawing.Size(75, 26);
            this.cmdExpenseAdd.TabIndex = 10;
            this.cmdExpenseAdd.Text = "Add";
            this.cmdExpenseAdd.UseVisualStyleBackColor = true;
            //this.cmdExpenseAdd.Click += new System.EventHandler(this.cmdExpenseAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 27;
            this.label11.Text = "Expenses:";
            // 
            // PnlExspenses
            // 
            this.PnlExspenses.AutoScroll = true;
            this.PnlExspenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlExspenses.Location = new System.Drawing.Point(12, 494);
            this.PnlExspenses.Name = "PnlExspenses";
            this.PnlExspenses.Size = new System.Drawing.Size(480, 204);
            this.PnlExspenses.TabIndex = 26;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(12, 700);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 26);
            this.cmdCancel.TabIndex = 12;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            //this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdCreate
            // 
            this.cmdCreate.Location = new System.Drawing.Point(417, 700);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(75, 26);
            this.cmdCreate.TabIndex = 11;
            this.cmdCreate.Text = "Create";
            this.cmdCreate.UseVisualStyleBackColor = true;
            //this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Job:";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(89, 6);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(403, 27);
            this.cmbCustomers.TabIndex = 30;
            //this.cmbCustomers.SelectedIndexChanged += new System.EventHandler(this.cmbCustomers_SelectedIndexChanged);
            // 
            // cmbJobs
            // 
            this.cmbJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobs.FormattingEnabled = true;
            this.cmbJobs.Location = new System.Drawing.Point(89, 37);
            this.cmbJobs.Name = "cmbJobs";
            this.cmbJobs.Size = new System.Drawing.Size(403, 27);
            this.cmbJobs.TabIndex = 31;
            //this.cmbJobs.SelectedIndexChanged += new System.EventHandler(this.cmbJobs_SelectedIndexChanged);
            // 
            // NewContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 735);
            this.Controls.Add(this.cmbJobs);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCreate);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdExpenseAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PnlExspenses);
            this.Controls.Add(this.cmdSoWAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PnlSOW);
            this.Controls.Add(this.CustomerState);
            this.Controls.Add(this.CustomerZip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CustomerCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CustomerAddressLine2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomerAddressLine1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Seperator);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewContract";
            this.Text = "Contractor Agreement";
            //this.Load += new System.EventHandler(this.CreateContractAgreement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Seperator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox CustomerAddressLine1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerAddressLine2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustomerCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CustomerZip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CustomerState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdSoWAdd;
        private System.Windows.Forms.Button cmdExpenseAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdCreate;
        public System.Windows.Forms.Panel PnlSOW;
        public System.Windows.Forms.Panel PnlExspenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbCustomers;
        public System.Windows.Forms.ComboBox cmbJobs;
    }
}