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
            StreamReader reader = new StreamReader(@"C:\Users\Public\Documents\Contact Tracing\Lettac.txt");
            while (!reader.EndOfStream )
            {
                string data = reader.ReadLine();
                lblAll.Text = lblAll.Text + data + "\n";
            }
            reader.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
