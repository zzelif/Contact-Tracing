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
            var txtFiles = Directory.EnumerateFiles(@"C:\Users\Public\Documents\Contact Tracing\Records");
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
                StreamWriter file = new StreamWriter(@"C:\Users\Public\Documents\Contact Tracing\Date\Specified Date.txt");
                foreach (string contents in dates)
                {
                    var lastItem = dates.LastOrDefault();
                    file.WriteLine(contents);
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
            txtbxAdvancedsearch.Text = "Yes, Yes " + " or Yes, No";
        }

        private void txtbxadvSearch_Enter(object sender, EventArgs e)
        {
            if (txtbxAdvancedsearch.Text == "Yes, Yes " + " or Yes, No")
            {
                txtbxAdvancedsearch.Text = "";
            }
        }

        private void txtbxadvSearch_Leave(object sender, EventArgs e)
        {
            if (txtbxAdvancedsearch.Text == "")
            {
                txtbxAdvancedsearch.Text = "Yes, Yes " + " or Yes, No";
            }
        }

        private void btnAdvsearch_Click(object sender, EventArgs e)
        {
            List<string> advsearch = new List<string>();
            string advSearch = txtbxAdvancedsearch.Text;
            string advDate = dtpAdvsearch.Text;
            int results = 0;
            var allRecords = Directory.EnumerateFiles(@"C:\Users\Public\Documents\Contact Tracing\Records", ".txt");
            foreach (string file in allRecords)
            {
                string records = File.ReadAllText(file);
                if (records.Contains(advDate))
                {
                    if (records.Contains(advSearch))
                    {
                        var all = records.Substring(records.IndexOf(advSearch) + 1);
                        results++;
                        advsearch.Add(records);
                        continue;
                    }
                }
            }
            if (results == 0)
            {
                MessageBox.Show("No records were found");
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\Public\Documents\Contact Tracing\Advanced Search.txt");
                foreach (string record in advsearch)
                {
                    file.WriteLine(record);
                }
                file.Close();
                MessageBox.Show("Found " + results.ToString() + " records based on search");
                MessageBox.Show("This file will be saved in the Contact Tracing folder");
                Form5 search = new Form5();
                search.ShowDialog();
            }
        }
    }
}
