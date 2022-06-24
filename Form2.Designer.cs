namespace Contact_Tracing
{
    partial class Form2
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
            this.btnShowall = new System.Windows.Forms.Button();
            this.lblShowalldata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowall
            // 
            this.btnShowall.Location = new System.Drawing.Point(48, 184);
            this.btnShowall.Name = "btnShowall";
            this.btnShowall.Size = new System.Drawing.Size(130, 63);
            this.btnShowall.TabIndex = 1;
            this.btnShowall.Text = "Show";
            this.btnShowall.UseVisualStyleBackColor = true;
            this.btnShowall.Click += new System.EventHandler(this.btnShowall_Click);
            // 
            // lblShowalldata
            // 
            this.lblShowalldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowalldata.Location = new System.Drawing.Point(30, 9);
            this.lblShowalldata.Name = "lblShowalldata";
            this.lblShowalldata.Size = new System.Drawing.Size(168, 172);
            this.lblShowalldata.TabIndex = 8;
            this.lblShowalldata.Text = "Show All Data Gathered From Contact Tracing";
            this.lblShowalldata.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 566);
            this.Controls.Add(this.lblShowalldata);
            this.Controls.Add(this.btnShowall);
            this.Name = "Form2";
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowall;
        private System.Windows.Forms.Label lblShowalldata;
    }
}