﻿using System;
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
                String line = reader.ReadToEnd();
                listBox1.Items.Add(line);
            }
        }
    }
}