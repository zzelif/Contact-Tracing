namespace Contact_Tracing
{
    partial class Form4
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
            this.lblDateresults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDateresults
            // 
            this.lblDateresults.AutoSize = true;
            this.lblDateresults.BackColor = System.Drawing.SystemColors.Control;
            this.lblDateresults.Location = new System.Drawing.Point(12, 23);
            this.lblDateresults.Name = "lblDateresults";
            this.lblDateresults.Size = new System.Drawing.Size(0, 16);
            this.lblDateresults.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(510, 560);
            this.Controls.Add(this.lblDateresults);
            this.Name = "Form4";
            this.Text = "Filter Results";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateresults;
    }
}