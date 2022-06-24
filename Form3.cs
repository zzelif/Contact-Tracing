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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            var txtFiles = Directory.EnumerateFiles(@"C:\Users\Public\Documents\Contact Tracing", ".txt");
            foreach (var currentFile in txtFiles)
            {
                var data = File.ReadAllText(currentFile);
                lblAll.Text = lblAll.Text + data + "\n";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
