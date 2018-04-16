using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text;

namespace MiniEHR
{
    static class Program
    {
        /// <summary>
        /// The main method below will create a new 'Form1' which opens to a list of patient contact 
        /// names and allows the user to select a patient from the list. Then a new window opens to
        /// offer the user 3 distinct actions with the selected patient.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
    }
}
