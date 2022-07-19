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

namespace Contact_Tracing_Form
{
    public partial class QRForm : Form
    {
        public QRForm()
        {
            InitializeComponent();
        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(QRtextBox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            QRpictureBox.Image = code.GetGraphic(5);
        }
    }
}
