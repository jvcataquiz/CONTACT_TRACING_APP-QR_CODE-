using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // for opening textfile
using AForge.Video.DirectShow; // image processing
using System.IO; // read and write of text file
using AForge; // image processing
using ZXing; // qrcode reader
using ZXing.Aztec; //qrcodde reader

namespace ContactTracingApp_QR_
{
    public partial class Form1 : Form
    {
        FilterInfoCollection videocamCollection;
        VideoCaptureDevice  cameraDisplay;
        int filter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            videocamCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in videocamCollection)
            {
                labelcamera.Text = filterInfo.Name;
                filter = 0 ;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            if (buttonStart.Text == "START")
            {
                cameraDisplay = new VideoCaptureDevice(videocamCollection[filter].MonikerString);
                cameraDisplay.NewFrame += CaptureDevice_NewFrame;
                cameraDisplay.Start();
                timerQRCODE.Start();
                buttonStart.Text = "STOP";

            }
            else if (buttonStart.Text == "STOP")
            {
                buttonStart.Text = "START";
                cameraDisplay.Stop();
                timerQRCODE.Stop();
                pictureBoxCamera.Image = Image.FromFile("video-not-working.png");
            }
        }

        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timerQRCODE_Tick(object sender, EventArgs e)
        {
            ZXing.BarcodeReader qrReader = new ZXing.BarcodeReader();
            ZXing.Result output = qrReader.Decode((Bitmap)pictureBoxCamera.Image);
           
            if (output != null)
            {
               
                string path = "Cataquiz, Jerick.txt";
                StreamWriter outputFile = File.AppendText(path);
                outputFile.WriteLine("===================================== \n\tINFORMATION \n");
                outputFile.WriteLine("Date: " + DateTime.Now.ToString());
                outputFile.WriteLine(output.ToString());
                outputFile.Close();
                timerQRCODE.Stop();
                MessageBox.Show(" Textfile Created Successfully!");
                buttonStart.PerformClick();
                Process.Start("notepad.exe", "Cataquiz, Jerick.txt");
                
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cameraDisplay.Stop();
        }
    }
}
