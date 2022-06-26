namespace Contact_Tracing
{
    partial class Form5
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
            this.lblAdvsearchresults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdvsearchresults
            // 
            this.lblAdvsearchresults.AutoSize = true;
            this.lblAdvsearchresults.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvsearchresults.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvsearchresults.Location = new System.Drawing.Point(24, 9);
            this.lblAdvsearchresults.Name = "lblAdvsearchresults";
            this.lblAdvsearchresults.Size = new System.Drawing.Size(0, 23);
            this.lblAdvsearchresults.TabIndex = 0;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(509, 553);
            this.Controls.Add(this.lblAdvsearchresults);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Search";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdvsearchresults;
    }
}