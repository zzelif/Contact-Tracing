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
            var txtFiles = Directory.GetFiles(@"C:\Users\Public\Documents\Contact Tracing");
            foreach (string file in txtFiles)
            {
                string contents = File.ReadAllText(file);
                lblAll.Text += contents;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
