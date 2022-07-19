using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Contact_Tracing_Form
{
    public partial class QRForm : Form
    {
        public QRForm()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private void QRForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                QRcomboBox.Items.Add(filterInfo.Name);
            QRcomboBox.SelectedIndex = 0;
        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(QRtextBox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            QRpictureBox.Image = code.GetGraphic(5);
        }

        private void ReadQRbutton_Click(object sender, EventArgs e)
        {
            captureDevice=new VideoCaptureDevice(filterInfoCollection[QRcomboBox.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_Newframe;
            captureDevice.Start();
            QRtimer.Start();
        }

        private void CaptureDevice_Newframe(object sender, NewFrameEventArgs eventArgs)
        {
            ReadQRpictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QRForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void QRtimer_Tick(object sender, EventArgs e)
        {
            if (ReadQRpictureBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)ReadQRpictureBox.Image);
                if (result !=null)
                {
                    ReadQRtextBox.Text = result.ToString();
                    QRtimer.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }

            }
        }
    }
}
