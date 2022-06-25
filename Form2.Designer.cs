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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnShowall = new System.Windows.Forms.Button();
            this.lblShowalldata = new System.Windows.Forms.Label();
            this.lblFilterdate = new System.Windows.Forms.Label();
            this.dtpFilter = new System.Windows.Forms.DateTimePicker();
            this.btnFilterdate = new System.Windows.Forms.Button();
            this.lblAdvancedsearch = new System.Windows.Forms.Label();
            this.lblsearchinfo = new System.Windows.Forms.Label();
            this.txtbxAdvancedsearch = new System.Windows.Forms.TextBox();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblDatedirections = new System.Windows.Forms.Label();
            this.dtpAdvsearch = new System.Windows.Forms.DateTimePicker();
            this.btnAdvcontinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowall
            // 
            this.btnShowall.BackColor = System.Drawing.Color.Transparent;
            this.btnShowall.BackgroundImage = global::Contact_Tracing.Properties.Resources._9523126451_674b6874d7_b;
            this.btnShowall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowall.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowall.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnShowall.Location = new System.Drawing.Point(73, 184);
            this.btnShowall.Name = "btnShowall";
            this.btnShowall.Size = new System.Drawing.Size(145, 63);
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
            this.lblShowalldata.Location = new System.Drawing.Point(41, 34);
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
            this.lblFilterdate.Location = new System.Drawing.Point(468, 34);
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
            this.dtpFilter.Location = new System.Drawing.Point(412, 149);
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
            this.btnFilterdate.Location = new System.Drawing.Point(504, 184);
            this.btnFilterdate.Name = "btnFilterdate";
            this.btnFilterdate.Size = new System.Drawing.Size(141, 63);
            this.btnFilterdate.TabIndex = 11;
            this.btnFilterdate.Text = "Continue";
            this.btnFilterdate.UseVisualStyleBackColor = false;
            this.btnFilterdate.Click += new System.EventHandler(this.btnFilterdate_Click);
            // 
            // lblAdvancedsearch
            // 
            this.lblAdvancedsearch.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvancedsearch.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvancedsearch.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblAdvancedsearch.Image = ((System.Drawing.Image)(resources.GetObject("lblAdvancedsearch.Image")));
            this.lblAdvancedsearch.Location = new System.Drawing.Point(301, 287);
            this.lblAdvancedsearch.Name = "lblAdvancedsearch";
            this.lblAdvancedsearch.Size = new System.Drawing.Size(166, 78);
            this.lblAdvancedsearch.TabIndex = 12;
            this.lblAdvancedsearch.Text = "Advanced Search";
            this.lblAdvancedsearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsearchinfo
            // 
            this.lblsearchinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblsearchinfo.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchinfo.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblsearchinfo.Image = ((System.Drawing.Image)(resources.GetObject("lblsearchinfo.Image")));
            this.lblsearchinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblsearchinfo.Location = new System.Drawing.Point(42, 371);
            this.lblsearchinfo.Name = "lblsearchinfo";
            this.lblsearchinfo.Size = new System.Drawing.Size(220, 32);
            this.lblsearchinfo.TabIndex = 13;
            this.lblsearchinfo.Text = "Find record(s) with...";
            this.lblsearchinfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxAdvancedsearch
            // 
            this.txtbxAdvancedsearch.BackColor = System.Drawing.Color.White;
            this.txtbxAdvancedsearch.Location = new System.Drawing.Point(270, 417);
            this.txtbxAdvancedsearch.Multiline = true;
            this.txtbxAdvancedsearch.Name = "txtbxAdvancedsearch";
            this.txtbxAdvancedsearch.Size = new System.Drawing.Size(343, 32);
            this.txtbxAdvancedsearch.TabIndex = 14;
            // 
            // lblDirection
            // 
            this.lblDirection.BackColor = System.Drawing.Color.Transparent;
            this.lblDirection.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblDirection.Image = ((System.Drawing.Image)(resources.GetObject("lblDirection.Image")));
            this.lblDirection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDirection.Location = new System.Drawing.Point(47, 417);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(215, 32);
            this.lblDirection.TabIndex = 15;
            this.lblDirection.Text = "Contact | Symptoms:";
            this.lblDirection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDatedirections
            // 
            this.lblDatedirections.BackColor = System.Drawing.Color.Transparent;
            this.lblDatedirections.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatedirections.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblDatedirections.Image = ((System.Drawing.Image)(resources.GetObject("lblDatedirections.Image")));
            this.lblDatedirections.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblDatedirections.Location = new System.Drawing.Point(43, 471);
            this.lblDatedirections.Name = "lblDatedirections";
            this.lblDatedirections.Size = new System.Drawing.Size(219, 29);
            this.lblDatedirections.TabIndex = 16;
            this.lblDatedirections.Text = "Date of Record(s)...";
            this.lblDatedirections.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpAdvsearch
            // 
            this.dtpAdvsearch.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtpAdvsearch.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpAdvsearch.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtpAdvsearch.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtpAdvsearch.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtpAdvsearch.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAdvsearch.Location = new System.Drawing.Point(270, 472);
            this.dtpAdvsearch.Name = "dtpAdvsearch";
            this.dtpAdvsearch.Size = new System.Drawing.Size(343, 29);
            this.dtpAdvsearch.TabIndex = 17;
            // 
            // btnAdvcontinue
            // 
            this.btnAdvcontinue.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvcontinue.BackgroundImage = global::Contact_Tracing.Properties.Resources._9523126451_674b6874d7_b;
            this.btnAdvcontinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdvcontinue.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvcontinue.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAdvcontinue.Location = new System.Drawing.Point(317, 507);
            this.btnAdvcontinue.Name = "btnAdvcontinue";
            this.btnAdvcontinue.Size = new System.Drawing.Size(141, 63);
            this.btnAdvcontinue.TabIndex = 18;
            this.btnAdvcontinue.Text = "Continue";
            this.btnAdvcontinue.UseVisualStyleBackColor = false;
            this.btnAdvcontinue.Click += new System.EventHandler(this.btnAdvsearch_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::Contact_Tracing.Properties.Resources._9523126451_674b6874d7_b;
            this.ClientSize = new System.Drawing.Size(828, 606);
            this.Controls.Add(this.btnAdvcontinue);
            this.Controls.Add(this.dtpAdvsearch);
            this.Controls.Add(this.lblDatedirections);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.txtbxAdvancedsearch);
            this.Controls.Add(this.lblsearchinfo);
            this.Controls.Add(this.lblAdvancedsearch);
            this.Controls.Add(this.btnFilterdate);
            this.Controls.Add(this.dtpFilter);
            this.Controls.Add(this.lblFilterdate);
            this.Controls.Add(this.lblShowalldata);
            this.Controls.Add(this.btnShowall);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowall;
        private System.Windows.Forms.Label lblShowalldata;
        private System.Windows.Forms.Label lblFilterdate;
        private System.Windows.Forms.DateTimePicker dtpFilter;
        private System.Windows.Forms.Button btnFilterdate;
        private System.Windows.Forms.Label lblAdvancedsearch;
        private System.Windows.Forms.Label lblsearchinfo;
        private System.Windows.Forms.TextBox txtbxAdvancedsearch;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblDatedirections;
        private System.Windows.Forms.DateTimePicker dtpAdvsearch;
        private System.Windows.Forms.Button btnAdvcontinue;
    }
}