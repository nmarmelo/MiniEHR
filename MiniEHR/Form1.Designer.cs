using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace MiniEHR
{
    partial class Form1
    {
        //instantiate XML Document
        XmlDocument patients = new XmlDocument();

        //Windows Forms resources
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button patientSelectButton;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        private void InitializeComponent()
        {
            //Load XML document into patients 
            patients.Load(Environment.CurrentDirectory + "\\patients.xml");


            #region Windows Form Designer generated code
            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.patientSelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 52);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 244);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a patient below...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // patientSelectButton
            // 
            this.patientSelectButton.Location = new System.Drawing.Point(269, 267);
            this.patientSelectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientSelectButton.Name = "patientSelectButton";
            this.patientSelectButton.Size = new System.Drawing.Size(100, 28);
            this.patientSelectButton.TabIndex = 2;
            this.patientSelectButton.Text = "Select";
            this.patientSelectButton.UseVisualStyleBackColor = true;
            this.patientSelectButton.Click += new System.EventHandler(this.patientSelectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 322);
            this.Controls.Add(this.patientSelectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MiniEHR";
            this.ResumeLayout(false);
            this.PerformLayout();
            #endregion

            this.updateList();
        }

        //quick method to sort through the XML file in order to idemtify patient contact names
        private void updateList()
        {           
            XmlNodeList firstList = patients.GetElementsByTagName("first");
            XmlNodeList lastList = patients.GetElementsByTagName("last");
            for (int i = 0; i < firstList.Count; i++)
            {
                this.listBox1.Items.Add(lastList[i].InnerXml + ", " + firstList[i].InnerXml);
            }
        }

        private Patient getSelectedPatient()
        {
            Patient p = null;
            //SelectedIndex will return -1 if no item is selected
            if (this.listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("No patient selected");
                return p;
            }
            else
            {
                
                String first = "john";
                String last = "Jones";
                String phone = "847651986";
                DateTime dob = Convert.ToDateTime("2/9/1995");

                //identify selected item by last name
                String selectedPatient = this.listBox1.SelectedItem.ToString();
                last = selectedPatient.Substring(0, selectedPatient.IndexOf(','));

                //find in XML by matching selected last name
                XmlNodeList lastList = patients.GetElementsByTagName("last");
                XmlNodeList firstList = patients.GetElementsByTagName("first");
                XmlNodeList phoneList = patients.GetElementsByTagName("phone");
                XmlNodeList dobList = patients.GetElementsByTagName("dob");
                for (int i = 0; i < lastList.Count; i++)
                {

                    //if last name match found, retrieve more information from XML
                    if (last == lastList[i].InnerXml)
                    {
                        first = firstList[i].InnerXml;
                        phone = phoneList[i].InnerXml;
                        dob = Convert.ToDateTime(dobList[i].InnerXml);
                    }
                    else if (i == lastList.Count && last != lastList[i].InnerXml)
                    {
                        MessageBox.Show("Patient could not be identified");
                    }

                }
                //create new patient item
                p = new Patient(first, last, phone, dob);
            }

            return p;
        }

    }
}

