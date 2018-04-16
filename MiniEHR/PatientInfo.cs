using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

namespace MiniEHR
{
    public partial class PatientInfo : Form
    {
        Patient p = new Patient();

        public PatientInfo()
        {
            InitializeComponent();
        }

        //This constructor takes a Patient as its parameter and uses that object to retrieve
        //data about the selected patient and present their information within the window
        public PatientInfo(Patient p)
        {
            this.p = p;
            InitializeComponent();
            this.label1.Text = p.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showAge_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p.calculateDetailedAge());         

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void write2file_Click(object sender, EventArgs e)
        {
            //create a string that will be a clearly identifiable file name
            String specify = (p.first + p.last + DateTime.Now.ToString(("yyyy-MM-dd")) + " " +
                DateTime.Now.ToString(("HH-mm-ss")));

            //Identify the directory that patient files will be stored in
            String path = Environment.CurrentDirectory + "\\PatientFiles";

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(Path.Combine(path, specify)))
                {
                    //Write patient info to file
                    sw.WriteLine(p.ToString());
                }

            //Display message box of success
            MessageBox.Show("Patient File created");
        }

        private void write2log_Click(object sender, EventArgs e)
        {
            //!WARNING! 
            //The program must be run with administrative priveleges in order to access the logs
            if (IsElevated() == false)
                MessageBox.Show("Program requires admin rights to write to log");
            else
            {
                //To write to windows event log, the method requires 3 String parameters to specify the event
                String sLog = "miniEHR";

                String sSource = p.first + p.last;

                String sEvent = p.ToString();

                if (!EventLog.SourceExists(sSource))
                    EventLog.CreateEventSource(sSource, sLog);

                EventLog.WriteEntry(sSource, sEvent);
                MessageBox.Show("Event Written!");
            }
        }

        //quick call to check if the program is running with admin rights
        //Method provided by https://stackoverflow.com/users/12597/ian-boyd
        private bool IsElevated()
        {
            bool isElevated;
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            return isElevated;
        }
    }
}
