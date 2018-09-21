namespace MDG.UserControls
{
    partial class LineItem
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(3, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(45, 19);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "label1";
            // 
            // lblRemove
            // 
            this.lblRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemove.AutoSize = true;
            this.lblRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRemove.Location = new System.Drawing.Point(373, 19);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(59, 19);
            this.lblRemove.TabIndex = 2;
            this.lblRemove.Text = "Remove";
            this.lblRemove.Click += new System.EventHandler(this.lblRemove_Click);
            // 
            // LineItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LineItem";
            this.Size = new System.Drawing.Size(435, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRemove;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblInfo;
    }
}
