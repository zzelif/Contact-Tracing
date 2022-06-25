using System;
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
                {
                    var date = contents.Substring(contents.IndexOf("=") + 1);
                    dateResults++;
                    dates.Add(contents);
                    continue;
                }
            }
            if (dateResults == 0)
            {
                MessageBox.Show("No records found on the selected date");
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\Public\Documents\Contact Tracing\Date\SpecificDate.txt");
                string lastItem;
                foreach (string contents in dates)
                {
                    lastItem = dates.LastOrDefault();
                    file.WriteLine(lastItem);
                }
                file.Close();
                MessageBox.Show("Found " + dateResults + " record(s) on the selected date");
                MessageBox.Show("This file will be saved in the Date folder");
                Form4 date = new Form4();
                date.ShowDialog();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtbxAdvancedsearch.Text = "Yes...";
        }
    }
}
