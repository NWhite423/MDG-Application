namespace MDG.Forms.Common
{
    partial class NewRepresentative
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.cmdSaveExit = new System.Windows.Forms.Button();
            this.cmdSaveClear = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Mail:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(121, 76);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(276, 26);
            this.txtPhone.TabIndex = 3;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(121, 108);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(276, 26);
            this.TxtEmail.TabIndex = 4;
            // 
            // cmdSaveExit
            // 
            this.cmdSaveExit.Location = new System.Drawing.Point(12, 140);
            this.cmdSaveExit.Name = "cmdSaveExit";
            this.cmdSaveExit.Size = new System.Drawing.Size(75, 26);
            this.cmdSaveExit.TabIndex = 5;
            this.cmdSaveExit.Text = "Save";
            this.cmdSaveExit.UseVisualStyleBackColor = true;
            this.cmdSaveExit.Click += new System.EventHandler(this.cmdSaveExit_Click);
            // 
            // cmdSaveClear
            // 
            this.cmdSaveClear.Location = new System.Drawing.Point(93, 140);
            this.cmdSaveClear.Name = "cmdSaveClear";
            this.cmdSaveClear.Size = new System.Drawing.Size(75, 26);
            this.cmdSaveClear.TabIndex = 6;
            this.cmdSaveClear.Text = "New";
            this.cmdSaveClear.UseVisualStyleBackColor = true;
            this.cmdSaveClear.Click += new System.EventHandler(this.cmdSaveClear_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(322, 140);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 26);
            this.cmdCancel.TabIndex = 7;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(121, 44);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(276, 26);
            this.txtTitle.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Title:";
            // 
            // NewRepresentative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 174);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSaveClear);
            this.Controls.Add(this.cmdSaveExit);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewRepresentative";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewRepresentative";
            this.Load += new System.EventHandler(this.NewRepresentative_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSaveExit;
        private System.Windows.Forms.Button cmdSaveClear;
        private System.Windows.Forms.Button cmdCancel;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox TxtEmail;
        public System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
    }
}