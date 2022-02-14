using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge;
using ZXing;
using ZXing.Aztec;

namespace ContactTracingApp_QR_
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;
        int filter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                labelcamera.Text = filterInfo.Name;
                filter = 0 ;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            if (buttonStart.Text == "START")
            {
                captureDevice = new VideoCaptureDevice(filterInfoCollection[filter].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                buttonStart.Text = "STOP";

            }
            else if (buttonStart.Text == "STOP")
            {
                buttonStart.Text = "START";
                captureDevice.Stop();
            }
        }

        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }
    }
}
