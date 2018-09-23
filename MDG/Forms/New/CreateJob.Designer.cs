namespace MDG.Forms.New
{
    partial class CreateJob
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCompanyZip = new System.Windows.Forms.TextBox();
            this.txtCompanyState = new System.Windows.Forms.TextBox();
            this.txtCompanyCity = new System.Windows.Forms.TextBox();
            this.txtCompanyAddress2 = new System.Windows.Forms.TextBox();
            this.txtCompanyAddress1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRepresentative = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectAddress1 = new System.Windows.Forms.TextBox();
            this.txtProjectAddress2 = new System.Windows.Forms.TextBox();
            this.txtProjectCity = new System.Windows.Forms.TextBox();
            this.txtProjectState = new System.Windows.Forms.TextBox();
            this.txtProjectZip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProjectNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdAddItem = new System.Windows.Forms.Button();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 0;
            this.label1.Tag = "Button";
            this.label1.Text = "Company Information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 2;
            this.label2.Tag = "Button";
            this.label2.Text = "Name:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyName.Location = new System.Drawing.Point(67, 74);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(380, 26);
            this.txtCompanyName.TabIndex = 1;
            // 
            // txtCompanyZip
            // 
            this.txtCompanyZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyZip.Location = new System.Drawing.Point(347, 189);
            this.txtCompanyZip.Name = "txtCompanyZip";
            this.txtCompanyZip.Size = new System.Drawing.Size(100, 26);
            this.txtCompanyZip.TabIndex = 6;
            this.txtCompanyZip.Tag = "Address Zip Code";
            // 
            // txtCompanyState
            // 
            this.txtCompanyState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyState.Location = new System.Drawing.Point(263, 189);
            this.txtCompanyState.Name = "txtCompanyState";
            this.txtCompanyState.Size = new System.Drawing.Size(78, 26);
            this.txtCompanyState.TabIndex = 5;
            this.txtCompanyState.Tag = "Address State";
            // 
            // txtCompanyCity
            // 
            this.txtCompanyCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyCity.Location = new System.Drawing.Point(12, 189);
            this.txtCompanyCity.Name = "txtCompanyCity";
            this.txtCompanyCity.Size = new System.Drawing.Size(245, 26);
            this.txtCompanyCity.TabIndex = 4;
            this.txtCompanyCity.Tag = "Addres City";
            // 
            // txtCompanyAddress2
            // 
            this.txtCompanyAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyAddress2.Location = new System.Drawing.Point(12, 157);
            this.txtCompanyAddress2.Name = "txtCompanyAddress2";
            this.txtCompanyAddress2.Size = new System.Drawing.Size(435, 26);
            this.txtCompanyAddress2.TabIndex = 3;
            this.txtCompanyAddress2.Tag = "Address Line 2";
            // 
            // txtCompanyAddress1
            // 
            this.txtCompanyAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyAddress1.Location = new System.Drawing.Point(12, 125);
            this.txtCompanyAddress1.Name = "txtCompanyAddress1";
            this.txtCompanyAddress1.Size = new System.Drawing.Size(435, 26);
            this.txtCompanyAddress1.TabIndex = 2;
            this.txtCompanyAddress1.Tag = "Address Line 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 11;
            this.label3.Tag = "Button";
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 15;
            this.label4.Tag = "Button";
            this.label4.Text = "Representative:";
            // 
            // cmbRepresentative
            // 
            this.cmbRepresentative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRepresentative.FormattingEnabled = true;
            this.cmbRepresentative.ItemHeight = 19;
            this.cmbRepresentative.Location = new System.Drawing.Point(119, 221);
            this.cmbRepresentative.Name = "cmbRepresentative";
            this.cmbRepresentative.Size = new System.Drawing.Size(328, 27);
            this.cmbRepresentative.TabIndex = 7;
            this.cmbRepresentative.Tag = "Representative";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(12, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(435, 2);
            this.label5.TabIndex = 17;
            this.label5.Tag = "Button";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectName.Location = new System.Drawing.Point(67, 282);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(380, 26);
            this.txtProjectName.TabIndex = 8;
            this.txtProjectName.Tag = "Project Name";
            // 
            // txtProjectAddress1
            // 
            this.txtProjectAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectAddress1.Location = new System.Drawing.Point(12, 333);
            this.txtProjectAddress1.Name = "txtProjectAddress1";
            this.txtProjectAddress1.Size = new System.Drawing.Size(435, 26);
            this.txtProjectAddress1.TabIndex = 9;
            this.txtProjectAddress1.Tag = "Address Line 1";
            // 
            // txtProjectAddress2
            // 
            this.txtProjectAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectAddress2.Location = new System.Drawing.Point(12, 365);
            this.txtProjectAddress2.Name = "txtProjectAddress2";
            this.txtProjectAddress2.Size = new System.Drawing.Size(435, 26);
            this.txtProjectAddress2.TabIndex = 10;
            this.txtProjectAddress2.Tag = "Address Line 2";
            // 
            // txtProjectCity
            // 
            this.txtProjectCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectCity.Location = new System.Drawing.Point(12, 397);
            this.txtProjectCity.Name = "txtProjectCity";
            this.txtProjectCity.Size = new System.Drawing.Size(245, 26);
            this.txtProjectCity.TabIndex = 12;
            this.txtProjectCity.Tag = "Addres City";
            // 
            // txtProjectState
            // 
            this.txtProjectState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectState.Location = new System.Drawing.Point(263, 397);
            this.txtProjectState.Name = "txtProjectState";
            this.txtProjectState.Size = new System.Drawing.Size(78, 26);
            this.txtProjectState.TabIndex = 13;
            this.txtProjectState.Tag = "Address State";
            // 
            // txtProjectZip
            // 
            this.txtProjectZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectZip.Location = new System.Drawing.Point(347, 397);
            this.txtProjectZip.Name = "txtProjectZip";
            this.txtProjectZip.Size = new System.Drawing.Size(100, 26);
            this.txtProjectZip.TabIndex = 14;
            this.txtProjectZip.Tag = "Address Zip Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 23;
            this.label6.Tag = "Button";
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 19;
            this.label7.Tag = "Button";
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 19);
            this.label8.TabIndex = 18;
            this.label8.Tag = "Button";
            this.label8.Text = "Project Information:";
            // 
            // lblProjectNumber
            // 
            this.lblProjectNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectNumber.Location = new System.Drawing.Point(185, 260);
            this.lblProjectNumber.Name = "lblProjectNumber";
            this.lblProjectNumber.Size = new System.Drawing.Size(262, 19);
            this.lblProjectNumber.TabIndex = 27;
            this.lblProjectNumber.Tag = "Button";
            this.lblProjectNumber.Text = "Project Number: 2018-XX";
            this.lblProjectNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(12, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(435, 2);
            this.label9.TabIndex = 28;
            this.label9.Tag = "Button";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 29;
            this.label10.Tag = "Button";
            this.label10.Text = "Billable Items:";
            // 
            // cmdAddItem
            // 
            this.cmdAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAddItem.Location = new System.Drawing.Point(372, 433);
            this.cmdAddItem.Name = "cmdAddItem";
            this.cmdAddItem.Size = new System.Drawing.Size(75, 26);
            this.cmdAddItem.TabIndex = 31;
            this.cmdAddItem.Tag = "Button";
            this.cmdAddItem.Text = "Add Item";
            this.cmdAddItem.UseVisualStyleBackColor = true;
            this.cmdAddItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCreate
            // 
            this.cmdCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCreate.Location = new System.Drawing.Point(372, 12);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(75, 26);
            this.cmdCreate.TabIndex = 32;
            this.cmdCreate.Tag = "Button";
            this.cmdCreate.Text = "Create";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(12, 12);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 26);
            this.cmdCancel.TabIndex = 33;
            this.cmdCancel.Tag = "Button";
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // CreateJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(459, 674);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdCreate);
            this.Controls.Add(this.cmdAddItem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblProjectNumber);
            this.Controls.Add(this.txtProjectZip);
            this.Controls.Add(this.txtProjectState);
            this.Controls.Add(this.txtProjectCity);
            this.Controls.Add(this.txtProjectAddress2);
            this.Controls.Add(this.txtProjectAddress1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRepresentative);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCompanyZip);
            this.Controls.Add(this.txtCompanyState);
            this.Controls.Add(this.txtCompanyCity);
            this.Controls.Add(this.txtCompanyAddress2);
            this.Controls.Add(this.txtCompanyAddress1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(475, 450);
            this.Name = "CreateJob";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Button";
            this.Text = "Create Job";
            this.Load += new System.EventHandler(this.CreateJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectAddress1;
        private System.Windows.Forms.TextBox txtProjectAddress2;
        private System.Windows.Forms.TextBox txtProjectCity;
        private System.Windows.Forms.TextBox txtProjectState;
        private System.Windows.Forms.TextBox txtProjectZip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProjectNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdAddItem;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.Button cmdCancel;
        public System.Windows.Forms.TextBox txtCompanyName;
        public System.Windows.Forms.TextBox txtCompanyZip;
        public System.Windows.Forms.TextBox txtCompanyState;
        public System.Windows.Forms.TextBox txtCompanyCity;
        public System.Windows.Forms.TextBox txtCompanyAddress2;
        public System.Windows.Forms.TextBox txtCompanyAddress1;
        public System.Windows.Forms.ComboBox cmbRepresentative;
    }
}