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
            StreamReader reader = new StreamReader(@"C:\Users\Public\Documents\Contact Tracing");

            while (reader.EndOfStream)
            {
                string data = reader.ReadLine();
                MessageBox.Show(data);
            }
        }
    }
}
