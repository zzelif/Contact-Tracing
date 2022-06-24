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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            var txtFiles = Directory.GetFiles(@"C:\Users\Public\Documents\Contact Tracing\Date");
            foreach (string file in txtFiles)
            {
                string contents = File.ReadAllText(file);
                lblDateresults.Text += contents + "\n";
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
