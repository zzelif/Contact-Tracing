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
            this.lblFilterdate = new System.Windows.Forms.Label();
            this.dtpFilter = new System.Windows.Forms.DateTimePicker();
            this.btnFilterdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowall
            // 
            this.btnShowall.BackColor = System.Drawing.Color.Transparent;
            this.btnShowall.BackgroundImage = global::Contact_Tracing.Properties.Resources._9523126451_674b6874d7_b;
            this.btnShowall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowall.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowall.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnShowall.Location = new System.Drawing.Point(104, 184);
            this.btnShowall.Name = "btnShowall";
            this.btnShowall.Size = new System.Drawing.Size(130, 63);
            this.btnShowall.TabIndex = 1;
            this.btnShowall.Text = "Continue";
            this.btnShowall.UseVisualStyleBackColor = false;
            this.btnShowall.Click += new System.EventHandler(this.btnShowall_Click);
            // 
            // lblShowalldata
            // 
            this.lblShowalldata.BackColor = System.Drawing.Color.Transparent;
            this.lblShowalldata.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowalldata.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblShowalldata.Image = global::Contact_Tracing.Properties.Resources._9523126451_674b6874d7_b;
            this.lblShowalldata.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblShowalldata.Location = new System.Drawing.Point(67, 34);
            this.lblShowalldata.Name = "lblShowalldata";
            this.lblShowalldata.Size = new System.Drawing.Size(204, 147);
            this.lblShowalldata.TabIndex = 8;
            this.lblShowalldata.Text = "Show All Data Gathered From Contact Tracing";
            this.lblShowalldata.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFilterdate
            // 
            this.lblFilterdate.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterdate.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterdate.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblFilterdate.Image = global::Contact_Tracing.Properties.Resources._9523126451_674b6874d7_b;
            this.lblFilterdate.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFilterdate.Location = new System.Drawing.Point(708, 34);
            this.lblFilterdate.Name = "lblFilterdate";
            this.lblFilterdate.Size = new System.Drawing.Size(204, 78);
            this.lblFilterdate.TabIndex = 9;
            this.lblFilterdate.Text = "Filter Record by Date:";
            this.lblFilterdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpFilter
            // 
            this.dtpFilter.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtpFilter.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpFilter.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtpFilter.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtpFilter.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtpFilter.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFilter.Location = new System.Drawing.Point(639, 152);
            this.dtpFilter.Name = "dtpFilter";
            this.dtpFilter.Size = new System.Drawing.Size(343, 29);
            this.dtpFilter.TabIndex = 10;
            // 
            // btnFilterdate
            // 
            this.btnFilterdate.BackColor = System.Drawing.Color.Transparent;
            this.btnFilterdate.BackgroundImage = global::Contact_Tracing.Properties.Resources._9523126451_674b6874d7_b;
            this.btnFilterdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFilterdate.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterdate.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnFilterdate.Location = new System.Drawing.Point(748, 187);
            this.btnFilterdate.Name = "btnFilterdate";
            this.btnFilterdate.Size = new System.Drawing.Size(130, 63);
            this.btnFilterdate.TabIndex = 11;
            this.btnFilterdate.Text = "Continue";
            this.btnFilterdate.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::Contact_Tracing.Properties.Resources._9523126451_674b6874d7_b;
            this.ClientSize = new System.Drawing.Size(1058, 606);
            this.Controls.Add(this.btnFilterdate);
            this.Controls.Add(this.dtpFilter);
            this.Controls.Add(this.lblFilterdate);
            this.Controls.Add(this.lblShowalldata);
            this.Controls.Add(this.btnShowall);
            this.Name = "Form2";
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowall;
        private System.Windows.Forms.Label lblShowalldata;
        private System.Windows.Forms.Label lblFilterdate;
        private System.Windows.Forms.DateTimePicker dtpFilter;
        private System.Windows.Forms.Button btnFilterdate;
    }
}