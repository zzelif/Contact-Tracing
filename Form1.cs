﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing
{
    public partial class formcttracing : Form
    {
        public formcttracing()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Public\Documents\Contact Tracing.txt", true);
            file.WriteLine("Date: " + dtpDate.Text);
            file.WriteLine("First Name: " + txtFirstname.Text);
            file.WriteLine("Middle Name: " + txtMidname.Text);
            file.WriteLine("Last Name: " + txtLastname.Text);
            file.WriteLine("Suffix: " + txtSuffix.Text);
            file.WriteLine("Age: " + nudAge.Text);
            file.WriteLine("Sex: " + txtSex.Text);
            file.Close();
            MessageBox.Show("Thank you for filling up this form!");
        }
    }
}
