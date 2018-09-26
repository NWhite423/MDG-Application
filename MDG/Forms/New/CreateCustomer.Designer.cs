namespace MDG.Forms.New
{
    partial class CreateCustomer
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbIndividual = new System.Windows.Forms.RadioButton();
            this.rbCompany = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.pnlReps = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(125, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Customer";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbIndividual
            // 
            this.rbIndividual.AutoSize = true;
            this.rbIndividual.Checked = true;
            this.rbIndividual.Location = new System.Drawing.Point(67, 65);
            this.rbIndividual.Name = "rbIndividual";
            this.rbIndividual.Size = new System.Drawing.Size(85, 23);
            this.rbIndividual.TabIndex = 2;
            this.rbIndividual.TabStop = true;
            this.rbIndividual.Text = "Individual";
            this.rbIndividual.UseVisualStyleBackColor = true;
            // 
            // rbCompany
            // 
            this.rbCompany.AutoSize = true;
            this.rbCompany.Location = new System.Drawing.Point(158, 65);
            this.rbCompany.Name = "rbCompany";
            this.rbCompany.Size = new System.Drawing.Size(86, 23);
            this.rbCompany.TabIndex = 3;
            this.rbCompany.TabStop = true;
            this.rbCompany.Text = "Company";
            this.rbCompany.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(305, 26);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(12, 113);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(360, 26);
            this.txtAddress1.TabIndex = 4;
            this.txtAddress1.Tag = "Address Line 1";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(12, 145);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(360, 26);
            this.txtAddress2.TabIndex = 5;
            this.txtAddress2.Tag = "Address Line 2";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(12, 177);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(170, 26);
            this.txtCity.TabIndex = 6;
            this.txtCity.Tag = "Addres City";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(188, 177);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(78, 26);
            this.txtState.TabIndex = 7;
            this.txtState.Tag = "Address State";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(272, 177);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 26);
            this.txtZip.TabIndex = 8;
            this.txtZip.Tag = "Address Zip Code";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(12, 423);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(100, 26);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(272, 423);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(100, 26);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(12, 391);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(100, 26);
            this.cmdAdd.TabIndex = 9;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // pnlReps
            // 
            this.pnlReps.Location = new System.Drawing.Point(12, 209);
            this.pnlReps.Name = "pnlReps";
            this.pnlReps.Size = new System.Drawing.Size(360, 176);
            this.pnlReps.TabIndex = 12;
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.pnlReps);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbCompany);
            this.Controls.Add(this.rbIndividual);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateCustomer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateCustomer";
            this.Load += new System.EventHandler(this.CreateCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbIndividual;
        private System.Windows.Forms.RadioButton rbCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Panel pnlReps;
    }
}