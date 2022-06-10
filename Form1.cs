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

namespace Contact_Tracing_Form
{
    public partial class ContactTracingForm : Form
    {
        public ContactTracingForm()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"D:\Claudio Abuloc Files\Contact Tracing\ContactTracing.txt",true);
            file.WriteLine("Name: " + NametextBox.Text);
            file.WriteLine("Sex: " + SextextBox.Text);
            file.WriteLine("Age: " + AgetextBox.Text);
            file.WriteLine("Birthday: " + BirthdaytextBox.Text);
            file.WriteLine("Address: " + AddresstextBox.Text);
            file.WriteLine("Contact No: " + ContactNotextBox.Text);
            file.WriteLine("Occupation: " + OccupationtextBox.Text);
            file.WriteLine("Email: " + EmailtextBox.Text);
            file.WriteLine("Date: " + DatetextBox.Text);
            file.WriteLine("Temperature: " + TemperaturetextBox.Text);
            file.WriteLine("Time In: " + TimeIntextBox.Text);
            file.WriteLine("Time Out: " + TimeOuttextBox.Text);
            file.Close();
        }


    }
}
