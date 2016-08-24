namespace AccessibilityScanner.Controls
{
    partial class ctlAttribute
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
            this.lblAttName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAttName
            // 
            this.lblAttName.AutoSize = true;
            this.lblAttName.Location = new System.Drawing.Point(9, 10);
            this.lblAttName.Name = "lblAttName";
            this.lblAttName.Size = new System.Drawing.Size(76, 17);
            this.lblAttName.TabIndex = 0;
            this.lblAttName.Text = "lblAttName";
            // 
            // ctlAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAttName);
            this.Name = "ctlAttribute";
            this.Size = new System.Drawing.Size(396, 38);
            this.Load += new System.EventHandler(this.ctlAttribute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAttName;
    }
}
