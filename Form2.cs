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
            var txtFiles = Directory.GetFiles(@"C:\Users\Public\Documents\Contact Tracing");
            List<string> dates = new List<string>();
            string Date = dtpFilter.Value.ToShortDateString();
            int dateResults = 0;

            foreach (string file in txtFiles)
            {
                string inputdate = File.ReadAllText(file);
                if (inputdate.Contains(Date))
                {
                    dateResults++;
                    dates.Add(inputdate);
                }
            }
            if (dateResults == 0)
            {
                MessageBox.Show("No records found on the selected date");
                return;
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\Public\Documents\Contact Tracing Date.txt");
                foreach (string inputdate in dates)
                {
                    file.WriteLine(inputdate);
                }
                MessageBox.Show("Found " + dateResults.ToString() + " records on the selected date");
                MessageBox.Show("These can be viewed at Contact Tracing Date.txt");
                file.Close();
                Form4 date = new Form4();
                date.ShowDialog();
            }
        }
    }
}
