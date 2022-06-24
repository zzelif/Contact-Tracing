﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
            Form3 all = new Form3();
            all.ShowDialog();

        }

        private void btnFilterdate_Click(object sender, EventArgs e)
        {
            List<string> dates = new List<string>();
            string Date = dtpFilter.Text;
            int dateResults = 0;
            var txtFiles = Directory.EnumerateFiles(@"C:\Users\Public\Documents\Contact Tracing");
            foreach (string file in txtFiles)
            {
                string contents = File.ReadAllText(file);
                if (contents.Contains(Date))
                    dateResults++; dates.Add(contents); continue;
            }
            if (dateResults == 0)
            {
                MessageBox.Show("No records found on the selected date");
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\Public\Documents\Contact Tracing\" + dtpFilter.Text + ".txt");
                foreach (string contents in dates)
                {
                    file.WriteLine(contents);
                    file.Close();
                }
                MessageBox.Show("Found " + dateResults + " records on the selected date");
                MessageBox.Show("These will be saved and can be viewed at Contact Tracing folder");
                Form4 date = new Form4();
                date.ShowDialog();
            }

            //while (!reader.EndOfStream)
            //{
            //    string inputdate = reader.ReadLine();
            //    if (inputdate.Contains(Date))
            //    {
            //        dateResults++;
            //        dates.Add(inputdate);
            //    }
            //}
            //if (dateResults == 0)
            //{
            //    MessageBox.Show("No records found on the selected date");
            //    reader.Close();
            //}
            //else
            //{
            //    reader.Close();
            //    StreamWriter file = new StreamWriter(@"C:\Users\Public\Documents\Contact Tracing\" + dtpFilter.Text + ".txt");
            //    foreach (string inputdate in dates)
            //    {
            //        file.WriteLine(inputdate);
            //    }
            //    MessageBox.Show("Found " + dateResults.ToString() + " records on the selected date");
            //    MessageBox.Show("These will be saved at cam be viewed at Contact Tracing/" + dtpFilter.Text + ".txt");
            //    file.Close();
            //    Form4 date = new Form4();
            //    date.ShowDialog();
            //}
        }
    }
}
