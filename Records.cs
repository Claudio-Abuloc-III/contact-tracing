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
                FilteredlistBox.Items.Add("Claudio Kitagawa");

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
            else if (SearchtextBox.Text == "July 20, 2022")
            {
                FilteredlistBox.Items.Clear();
                FilteredlistBox.Items.Add("Claudio Kitagawa");
            }
            


           

        }

        private void Infobutton_Click(object sender, EventArgs e)
        {
            if (FilteredlistBox.SelectedItems.Contains("Joshua Dela Cruz"))
            {
                InfolistBox.Items.Clear();
                InfolistBox.Items.Add("Name: Joshua Dela Cruz");
                InfolistBox.Items.Add("Sex: Male");
                InfolistBox.Items.Add("Age: 16");
                InfolistBox.Items.Add("Birthday: December 25, 2006");
                InfolistBox.Items.Add("Address: Manila City");
                InfolistBox.Items.Add("Contact No: 098385530723");
                InfolistBox.Items.Add("Year+Section: 10 - Diamond");
                InfolistBox.Items.Add("Email: JoshuaDelaCruz@gmail.com");
                InfolistBox.Items.Add("Date: May 16, 2022");
                InfolistBox.Items.Add("Temperature: 36");
                InfolistBox.Items.Add("Time In: 7:30 AM");
                InfolistBox.Items.Add("Time Out: 9:30 AM");
                InfolistBox.Items.Add("Do you have any of the following symptoms?: ");
                InfolistBox.Items.Add("Cough: No");
                InfolistBox.Items.Add("Sore Throat: No");
                InfolistBox.Items.Add("Chills: No");
                InfolistBox.Items.Add("Difficulty Swallowing: No");
                InfolistBox.Items.Add("Loss of Smell: No");
                InfolistBox.Items.Add("Shortness of Breath: No");
                InfolistBox.Items.Add("Fever: No");
                InfolistBox.Items.Add("Headache: No");
                InfolistBox.Items.Add("Loss of Taste: No");
                InfolistBox.Items.Add("Fatigue: No");
                InfolistBox.Items.Add("Do you have any travel history for the past 14 days?: No");
                InfolistBox.Items.Add("Have you had close contact with anyone with a confirmed or probable case of COVID-19 within 14 days? No");
                InfolistBox.Items.Add("Are you positive for COVID -19?: No");
                InfolistBox.Items.Add("If yes, did you quarantine for 14 days?: ");
            }
            if (FilteredlistBox.SelectedItems.Contains("John Lloyd Cruz"))
            {
                InfolistBox.Items.Clear();
                InfolistBox.Items.Add("Name: John Lloyd Cruz");
                InfolistBox.Items.Add("Sex: Male");
                InfolistBox.Items.Add("Age: 16");
                InfolistBox.Items.Add("Birthday: September 10, 2006");
                InfolistBox.Items.Add("Address: Quezon City");
                InfolistBox.Items.Add("Contact No: 09983738735");
                InfolistBox.Items.Add("Year+Section: 10 - Sapphire");
                InfolistBox.Items.Add("Email: JohnLloydCruz@gmail.com");
                InfolistBox.Items.Add("Date: May 15, 2022");
                InfolistBox.Items.Add("Temperature: 35");
                InfolistBox.Items.Add("Time In: 10:00 AM");
                InfolistBox.Items.Add("Time Out: 10:30 AM");
                InfolistBox.Items.Add("Do you have any of the following symptoms?: ");
                InfolistBox.Items.Add("Cough: No");
                InfolistBox.Items.Add("Sore Throat: No");
                InfolistBox.Items.Add("Chills: No");
                InfolistBox.Items.Add("Difficulty Swallowing: No");
                InfolistBox.Items.Add("Loss of Smell: No");
                InfolistBox.Items.Add("Shortness of Breath: No");
                InfolistBox.Items.Add("Fever: No");
                InfolistBox.Items.Add("Headache: No");
                InfolistBox.Items.Add("Loss of Taste: No");
                InfolistBox.Items.Add("Fatigue: No");
                InfolistBox.Items.Add("Do you have any travel history for the past 14 days?: No");
                InfolistBox.Items.Add("Have you had close contact with anyone with a confirmed or probable case of COVID-19 within 14 days? No");
                InfolistBox.Items.Add("Are you positive for COVID -19?: No");
                InfolistBox.Items.Add("If yes, did you quarantine for 14 days?: ");
            }
            if (FilteredlistBox.SelectedItems.Contains("Shinichi Kudo"))
            {
                InfolistBox.Items.Clear();
                InfolistBox.Items.Add("Name: Shinichi Kudo");
                InfolistBox.Items.Add("Sex: Male");
                InfolistBox.Items.Add("Age: 16");
                InfolistBox.Items.Add("Birthday: March 15, 2006");
                InfolistBox.Items.Add("Address: Novaliches");
                InfolistBox.Items.Add("Contact No: 099999999");
                InfolistBox.Items.Add("Year+Section: 10-Garnet");
                InfolistBox.Items.Add("Email: ShinichiKudo@gmail.com");
                InfolistBox.Items.Add("Date: May 16, 2022");
                InfolistBox.Items.Add("Temperature: 35");
                InfolistBox.Items.Add("Time In: 10:00 AM");
                InfolistBox.Items.Add("Time Out: 11:00 AM");
                InfolistBox.Items.Add("Do you have any of the following symptoms?: ");
                InfolistBox.Items.Add("Cough: No");
                InfolistBox.Items.Add("Sore Throat: No");
                InfolistBox.Items.Add("Chills: No");
                InfolistBox.Items.Add("Difficulty Swallowing: No");
                InfolistBox.Items.Add("Loss of Smell: No");
                InfolistBox.Items.Add("Shortness of Breath: No");
                InfolistBox.Items.Add("Fever: No");
                InfolistBox.Items.Add("Headache: No");
                InfolistBox.Items.Add("Loss of Taste: No");
                InfolistBox.Items.Add("Fatigue: No");
                InfolistBox.Items.Add("Do you have any travel history for the past 14 days?: No");
                InfolistBox.Items.Add("Have you had close contact with anyone with a confirmed or probable case of COVID-19 within 14 days? No");
                InfolistBox.Items.Add("Are you positive for COVID -19?: No");
                InfolistBox.Items.Add("If yes, did you quarantine for 14 days?: ");
            }
            if (FilteredlistBox.SelectedItems.Contains("Conan Edogawa"))
            {
                InfolistBox.Items.Clear();
                InfolistBox.Items.Add("Name: Conan Edogawa");
                InfolistBox.Items.Add("Sex: Male");
                InfolistBox.Items.Add("Age: 15");
                InfolistBox.Items.Add("Birthday: April 4, 2006");
                InfolistBox.Items.Add("Address: Anonas");
                InfolistBox.Items.Add("Contact No: 099999999");
                InfolistBox.Items.Add("Year+Section: 10-Amethyst");
                InfolistBox.Items.Add("Email: ConanEdogawa@gmail.com");
                InfolistBox.Items.Add("Date: May 16, 2022");
                InfolistBox.Items.Add("Temperature: 35.5");
                InfolistBox.Items.Add("Time In: 10:30 AM");
                InfolistBox.Items.Add("Time Out: 11:30 AM");
                InfolistBox.Items.Add("Do you have any of the following symptoms?: ");
                InfolistBox.Items.Add("Cough: No");
                InfolistBox.Items.Add("Sore Throat: No");
                InfolistBox.Items.Add("Chills: No");
                InfolistBox.Items.Add("Difficulty Swallowing: No");
                InfolistBox.Items.Add("Loss of Smell: No");
                InfolistBox.Items.Add("Shortness of Breath: No");
                InfolistBox.Items.Add("Fever: No");
                InfolistBox.Items.Add("Headache: No");
                InfolistBox.Items.Add("Loss of Taste: No");
                InfolistBox.Items.Add("Fatigue: No");
                InfolistBox.Items.Add("Do you have any travel history for the past 14 days?: No");
                InfolistBox.Items.Add("Have you had close contact with anyone with a confirmed or probable case of COVID-19 within 14 days? No");
                InfolistBox.Items.Add("Are you positive for COVID -19?: No");
                InfolistBox.Items.Add("If yes, did you quarantine for 14 days?: ");
            }
            if (FilteredlistBox.SelectedItems.Contains("Ran Mori"))
            {
                InfolistBox.Items.Clear();
                InfolistBox.Items.Add("Name: Ran Mori");
                InfolistBox.Items.Add("Sex: Female");
                InfolistBox.Items.Add("Age: 16");
                InfolistBox.Items.Add("Birthday: July 24, 2006");
                InfolistBox.Items.Add("Address: Katipunan");
                InfolistBox.Items.Add("Contact No: 099999999");
                InfolistBox.Items.Add("Year+Section: 10-Ruby");
                InfolistBox.Items.Add("Email: RanMori@gmail.com");
                InfolistBox.Items.Add("Date: May 16, 2022");
                InfolistBox.Items.Add("Temperature: 39");
                InfolistBox.Items.Add("Time In: 12:00 PM");
                InfolistBox.Items.Add("Time Out: 1:00 PM");
                InfolistBox.Items.Add("Do you have any of the following symptoms?: ");
                InfolistBox.Items.Add("Cough: No");
                InfolistBox.Items.Add("Sore Throat: No");
                InfolistBox.Items.Add("Chills: No");
                InfolistBox.Items.Add("Difficulty Swallowing: No");
                InfolistBox.Items.Add("Loss of Smell: No");
                InfolistBox.Items.Add("Shortness of Breath: No");
                InfolistBox.Items.Add("Fever: Yes");
                InfolistBox.Items.Add("Headache: No");
                InfolistBox.Items.Add("Loss of Taste: No");
                InfolistBox.Items.Add("Fatigue: No");
                InfolistBox.Items.Add("Do you have any travel history for the past 14 days?: No");
                InfolistBox.Items.Add("Have you had close contact with anyone with a confirmed or probable case of COVID-19 within 14 days? No");
                InfolistBox.Items.Add("Are you positive for COVID -19?: No");
                InfolistBox.Items.Add("If yes, did you quarantine for 14 days?: ");
            }
            if (FilteredlistBox.SelectedItems.Contains("Claudio Kitagawa"))
            {
                InfolistBox.Items.Clear();
                InfolistBox.Items.Add("Name: Claudio Kitagawa");
                InfolistBox.Items.Add("Sex: Male");
                InfolistBox.Items.Add("Age: 20");
                InfolistBox.Items.Add("Birthday: Sep x, 20xx");
                InfolistBox.Items.Add("Address: Quezon City");
                InfolistBox.Items.Add("Contact No: 099999999");
                InfolistBox.Items.Add("Year+Section: 10 - Diamond");
                InfolistBox.Items.Add("Email: claudioxxxxx@gmail.com");
                InfolistBox.Items.Add("Date: July 20, 2022");
                InfolistBox.Items.Add("Temperature: 39");
                InfolistBox.Items.Add("Time In: 12:00 PM");
                InfolistBox.Items.Add("Time Out: 1:00 PM");
                InfolistBox.Items.Add("Do you have any of the following symptoms?: ");
                InfolistBox.Items.Add("Cough: No");
                InfolistBox.Items.Add("Sore Throat: No");
                InfolistBox.Items.Add("Chills: No");
                InfolistBox.Items.Add("Difficulty Swallowing: No");
                InfolistBox.Items.Add("Loss of Smell: No");
                InfolistBox.Items.Add("Shortness of Breath: No");
                InfolistBox.Items.Add("Fever: Yes");
                InfolistBox.Items.Add("Headache: No");
                InfolistBox.Items.Add("Loss of Taste: No");
                InfolistBox.Items.Add("Fatigue: No");
                InfolistBox.Items.Add("Do you have any travel history for the past 14 days?: No");
                InfolistBox.Items.Add("Have you had close contact with anyone with a confirmed or probable case of COVID-19 within 14 days? No");
                InfolistBox.Items.Add("Are you positive for COVID -19?: No");
                InfolistBox.Items.Add("If yes, did you quarantine for 14 days?: ");
            }
        }
    }
}
