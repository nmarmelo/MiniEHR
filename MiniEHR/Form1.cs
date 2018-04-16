using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniEHR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void patientSelectButton_Click(object sender, EventArgs e)
        {
            //find patient and create a Patient object that temporarily stores data about the selected
            //patient
            
            Patient p = this.getSelectedPatient();


            //open a new 'PatientInfo' window to display information
            if (p != null)
            {
                PatientInfo pi = new PatientInfo(p);
                pi.Show();
            }
        }
    }
}
