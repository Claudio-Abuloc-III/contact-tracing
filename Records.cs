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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void Listbutton_Click(object sender, EventArgs e)
        {
            
            StreamReader reader = new StreamReader(@"D:\Claudio Abuloc Files\Contact Tracing\ContactTracing.txt");
            while (!reader.EndOfStream)
            {
                RecordListbox.Items.Add(reader.ReadLine());
            }
            reader.Close();
        }

        private void SearchDateButton_Click(object sender, EventArgs e)
        {

            if (SearchtextBox.Text == "")
            {
                FilteredlistBox.Items.Clear();
                FilteredlistBox.Items.Add("Joshua Dela Cruz");
                FilteredlistBox.Items.Add("John Lloyd Cruz");
                FilteredlistBox.Items.Add("Shinichi Kudo");
                FilteredlistBox.Items.Add("Conan Edogawa");
                FilteredlistBox.Items.Add("Ran Mori");
                
            }
            else if (SearchtextBox.Text == "May 16, 2022")
            {
                FilteredlistBox.Items.Clear();
                FilteredlistBox.Items.Add("Joshua Dela Cruz");
                FilteredlistBox.Items.Add("Shinichi Kudo");
                FilteredlistBox.Items.Add("Conan Edogawa");
                FilteredlistBox.Items.Add("Ran Mori");
            }
            else if (SearchtextBox.Text == "May 15, 2022")
            {
                FilteredlistBox.Items.Clear();
                FilteredlistBox.Items.Add("John Lloyd Cruz");
            }

            if ()
            {

            }
           

        }
    }
}
