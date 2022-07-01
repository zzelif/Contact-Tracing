using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using QRCoder;

namespace Contact_Tracing
{
    public partial class formcttracing : Form
    {
        public formcttracing()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Public\Documents\Contact Tracing\Records\" + txtFirstname.Text + txtLastname.Text + ".txt", true);
            file.WriteLine("Date: " + dtpDate.Text);
            file.WriteLine("");
            file.WriteLine("PERSONAL INFORMATION");
            file.WriteLine("First Name: " + txtFirstname.Text);
            file.WriteLine("Middle Name: " + txtMidname.Text);
            file.WriteLine("Last Name: " + txtLastname.Text);
            file.WriteLine("Suffix: " + txtSuffix.Text);
            file.WriteLine("Age: " + nudAge.Text);
            file.WriteLine("Gender: " + txtGender.Text);
            file.WriteLine("Phone number: " + txtNumber.Text);
            file.WriteLine("Email Address: " + txtEmail.Text);
            file.WriteLine("Address: " + txtAddress.Text);
            file.WriteLine(txtAddress1.Text);
            file.WriteLine(txtAddress2.Text);
            file.WriteLine(txtAddress3.Text);
            file.WriteLine(txtAddress4.Text);
            file.WriteLine(txtAddress5.Text);
            file.WriteLine("");
            file.WriteLine("In case of emergency");
            file.WriteLine("Emergency Contact: " + txtEmergencyname.Text);
            file.WriteLine("Relationship : " + txtRelationship.Text);
            file.WriteLine("Contact Number: " + txtContactno.Text);
            file.WriteLine("");
            file.WriteLine("Have you been experiencing ailments and/or symptoms?");
            file.WriteLine(txtQuestion.Text);
            file.WriteLine("Have you been in contact with anyone?");
            file.WriteLine(txtQuestion1.Text);
            file.Close();
            MessageBox.Show("Thank you for filling up this form!", "Contact Tracing", MessageBoxButtons.OK);
            Application.Restart();
            Environment.Exit(0);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            String pws = txtbxPassword.Text;
            if (pws == "admin")
            {
                Form2 info = new Form2();
                info.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will be generated into a QR Code");
            QRCodeGenerator qr = new QRCodeGenerator();
            string record = "Date: " + dtpDate.Text + Environment.NewLine + Environment.NewLine + "PERSONAL INFORMATION" + Environment.NewLine + "First Name: " + txtFirstname.Text + Environment.NewLine + "Middle Name: " + txtMidname.Text + Environment.NewLine + "Last Name: " + txtLastname.Text + Environment.NewLine + "Suffix: " + txtSuffix.Text + Environment.NewLine + "Age: " + nudAge.TextAlign + Environment.NewLine + "Gender: " + txtGender.Text + Environment.NewLine + "Phone Number: " + txtNumber.Text + Environment.NewLine + "Email Address: " + txtEmail.Text + Environment.NewLine + "Address: " + txtAddress.Text + Environment.NewLine + txtAddress1.Text + Environment.NewLine + txtAddress2.Text + Environment.NewLine + txtAddress3.Text + Environment.NewLine + txtAddress4.Text + Environment.NewLine + txtAddress5.Text + Environment.NewLine + Environment.NewLine + "In case of emergency" + Environment.NewLine + "Emergency Contact: " + txtEmergencyname.Text + Environment.NewLine + "Relationship: " + txtRelationship.Text + Environment.NewLine + "Contact Number: " + txtContactno.Text + Environment.NewLine + Environment.NewLine + "Have you been experiency ailments and/or symptoms?" + Environment.NewLine + txtQuestion.Text + Environment.NewLine + "Have you been in contact with anyone?" + Environment.NewLine + txtQuestion1.Text + Environment.NewLine;
            QRCodeData data = qr.CreateQrCode(record, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pbxGenerate.Image = code.GetGraphic(2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterinfo in filterInfoCollection)
                cbxDevice.Items.Add(filterinfo.Name);
            cbxDevice.SelectedIndex = 0;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbxDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            tmrScan.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbxScan.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void tmrScan_Tick(object sender, EventArgs e)
        {
            if (pbxScan.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pbxScan.Image);
                if (result != null)
                {
                    tmrScan.Stop();
                    MessageBox.Show("Thank you for filling up this form");
                    string infoGathered = result.ToString();
                    StringBuilder sb = new StringBuilder(infoGathered);
                    infoGathered = sb.ToString();
                    string infoShown = infoGathered;
                    MessageBox.Show(infoShown);
                    StreamWriter write = new StreamWriter(@"C:\Users\Public\Documents\Contact Tracing\Records\QR Records.txt", true);
                    write.WriteLine(infoGathered);
                    write.Close();
                    MessageBox.Show("This will be saved in the QR Code folder");
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                    MessageBox.Show("Application will now restart");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

    }
}
