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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            var searchFiles = Directory.GetFiles(@"C:\Users\Public\Documents\Contact Tracing\Advanced Search.txt");
            foreach (string file in searchFiles)
            {
                string results = File.ReadAllText(file);
                lblAdvsearchresults.Text = lblAdvsearchresults.Text + results + "\n";
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
