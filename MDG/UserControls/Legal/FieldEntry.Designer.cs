namespace MDG.UserControls.Legal
{
    partial class FieldEntry
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.cmdMoveUp = new System.Windows.Forms.Button();
            this.cmdMoveDown = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(3, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(67, 24);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Item #";
            // 
            // txtItem
            // 
            this.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItem.Enabled = false;
            this.txtItem.Location = new System.Drawing.Point(3, 27);
            this.txtItem.Multiline = true;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(450, 88);
            this.txtItem.TabIndex = 1;
            // 
            // cmdMoveUp
            // 
            this.cmdMoveUp.Image = global::MDG.Properties.Resources.arrow_up;
            this.cmdMoveUp.Location = new System.Drawing.Point(84, 121);
            this.cmdMoveUp.Name = "cmdMoveUp";
            this.cmdMoveUp.Size = new System.Drawing.Size(27, 26);
            this.cmdMoveUp.TabIndex = 9;
            this.cmdMoveUp.UseVisualStyleBackColor = true;
            // 
            // cmdMoveDown
            // 
            this.cmdMoveDown.Image = global::MDG.Properties.Resources.arrow;
            this.cmdMoveDown.Location = new System.Drawing.Point(108, 121);
            this.cmdMoveDown.Name = "cmdMoveDown";
            this.cmdMoveDown.Size = new System.Drawing.Size(27, 26);
            this.cmdMoveDown.TabIndex = 8;
            this.cmdMoveDown.UseVisualStyleBackColor = true;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(382, 121);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 26);
            this.cmdDelete.TabIndex = 7;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdModify
            // 
            this.cmdModify.Location = new System.Drawing.Point(3, 121);
            this.cmdModify.Name = "cmdModify";
            this.cmdModify.Size = new System.Drawing.Size(75, 26);
            this.cmdModify.TabIndex = 6;
            this.cmdModify.Text = "Modify";
            this.cmdModify.UseVisualStyleBackColor = true;
            this.cmdModify.Click += new System.EventHandler(this.cmdModify_Click);
            // 
            // FieldEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmdMoveUp);
            this.Controls.Add(this.cmdMoveDown);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdModify);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FieldEntry";
            this.Size = new System.Drawing.Size(461, 151);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdModify;
        public System.Windows.Forms.Label LblTitle;
        public System.Windows.Forms.TextBox txtItem;
        public System.Windows.Forms.Button cmdMoveUp;
        public System.Windows.Forms.Button cmdMoveDown;
    }
}