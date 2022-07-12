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
            file.WriteLine("Year+Section: " + YeartextBox.Text);
            file.WriteLine("Email: " + EmailtextBox.Text);
            file.WriteLine("Date: " + DatetextBox.Text);
            file.WriteLine("Temperature: " + TemperaturetextBox.Text);
            file.WriteLine("Time In: " + TimeIntextBox.Text);
            file.WriteLine("Time Out: " + TimeOuttextBox.Text);
            file.WriteLine("Do you have any of the following symptoms?: ");

            string decision1 = "";
            if (CoughYradioButton.Checked)
            {
                decision1 = CoughYradioButton.Text;
            }
            if (CoughNradioButton.Checked)
            {
                decision1 = CoughNradioButton.Text;
            }
            file.WriteLine("Cough: " + decision1);

            string decision2 = "";
            if (ThroatYradioButton.Checked)
            {
                decision2 = ThroatYradioButton.Text;
            }
            if (ThroatNradioButton.Checked)
            {
                decision2 = ThroatNradioButton.Text;
            }
            file.WriteLine("Sore Throat: " + decision2);

            string decision3 = "";
            if (ChillsYradioButton.Checked)
            {
                decision3 = ChillsYradioButton.Text;
            }
            if (ChillsNradioButton.Checked)
            {
                decision3 = ChillsNradioButton.Text;
            }
            file.WriteLine("Chills: " + decision3);

            string decision4 = "";
            if (SwallowYradioButton.Checked)
            {
                decision4 = SwallowYradioButton.Text;
            }
            if (SwallowNradioButton.Checked)
            {
                decision4 = SwallowNradioButton.Text;
            }
            file.WriteLine("Difficulty Swallowing: " + decision4);

            string decision5 = "";
            if (SmellYradioButton.Checked)
            {
                decision5 = SmellYradioButton.Text;
            }
            if (SmellNradioButton.Checked)
            {
                decision5 = SmellNradioButton.Text;
            }
            file.WriteLine("Loss of Smell: " + decision5);

            string decision6 = "";
            if (BreathYradioButton.Checked)
            {
                decision6 = BreathYradioButton.Text;
            }
            if (BreathNradioButton.Checked)
            {
                decision6 = BreathNradioButton.Text;
            }
            file.WriteLine("Shortness of Breath: " + decision6);

            string decision7 = "";
            if (FeverYradioButton.Checked)
            {
                decision7 = FeverYradioButton.Text;
            }
            if (FeverNradioButton.Checked)
            {
                decision7 = FeverNradioButton.Text;
            }
            file.WriteLine("Fever: " + decision7);

            string decision8 = "";
            if (HeadYradioButton.Checked)
            {
                decision8 = HeadYradioButton.Text;
            }
            if (HeadNradioButton.Checked)
            {
                decision8 = HeadNradioButton.Text;
            }
            file.WriteLine("Headache: " + decision8);

            string decision9 = "";
            if (TasteYradioButton.Checked)
            {
                decision9 = TasteYradioButton.Text;
            }
            if (TasteNradioButton.Checked)
            {
                decision9 = TasteNradioButton.Text;
            }
            file.WriteLine("Loss of Taste: " + decision9);

            string decision10 = "";
            if (FatigueYradioButton.Checked)
            {
                decision10 = FatigueYradioButton.Text;
            }
            if (FatigueNradioButton.Checked)
            {
                decision10 = FatigueNradioButton.Text;
            }
            file.WriteLine("Fatigue: " + decision10);

            string decision11 = "";
            if (Q5YradioButton.Checked)
            {
                decision11 = Q5YradioButton.Text;
            }
            if (Q5NradioButton.Checked)
            {
                decision11 = Q5NradioButton.Text;
            }
            file.WriteLine("Do you have any travel history for the past 14 days?: " + decision11);

            string decision12 = "";
            if (Q2YradioButton.Checked)
            {
                decision12 = Q2YradioButton.Text;
            }
            if (Q2NradioButton.Checked)
            {
                decision12 = Q2NradioButton.Text;
            }
            file.WriteLine("Have you had close contact with anyone with a confirmed or probable case of COVID-19 within 14 days? " + decision12);

            string decision13 = "";
            if (Q3YradioButton.Checked)
            {
                decision13 = Q3YradioButton.Text;
            }
            if (Q3NradioButton.Checked)
            {
                decision13 = Q3NradioButton.Text;
            }
            file.WriteLine("Are you positive for COVID -19?: " + decision13);

            string decision14 = "";
            if (Q4YradioButton.Checked)
            {
                decision14 = Q4YradioButton.Text;
            }
            if (Q4NradioButton.Checked)
            {
                decision14 = Q4NradioButton.Text;
            }
            file.WriteLine("If yes, did you quarantine for 14 days?: " + decision14);
            file.Close();
        }

        private void Recordsbutton_Click(object sender, EventArgs e)
        {
            Records records = new Records();
            records.Show();
        }
    }
}

