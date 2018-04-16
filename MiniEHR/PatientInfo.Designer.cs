namespace MiniEHR
{
    partial class PatientInfo
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.showAge = new System.Windows.Forms.Button();
            this.write2file = new System.Windows.Forms.Button();
            this.write2log = new System.Windows.Forms.Button();
            this.logToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // showAge
            // 
            this.showAge.Location = new System.Drawing.Point(273, 25);
            this.showAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showAge.Name = "showAge";
            this.showAge.Size = new System.Drawing.Size(100, 28);
            this.showAge.TabIndex = 1;
            this.showAge.Text = "Show Age";
            this.showAge.UseVisualStyleBackColor = true;
            this.showAge.Click += new System.EventHandler(this.showAge_Click);
            // 
            // write2file
            // 
            this.write2file.Location = new System.Drawing.Point(273, 62);
            this.write2file.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.write2file.Name = "write2file";
            this.write2file.Size = new System.Drawing.Size(100, 28);
            this.write2file.TabIndex = 2;
            this.write2file.Text = "Write to File";
            this.write2file.UseVisualStyleBackColor = true;
            this.write2file.Click += new System.EventHandler(this.write2file_Click);
            // 
            // write2log
            // 
            this.write2log.Location = new System.Drawing.Point(273, 97);
            this.write2log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.write2log.Name = "write2log";
            this.write2log.Size = new System.Drawing.Size(100, 28);
            this.write2log.TabIndex = 3;
            this.write2log.Text = "Write to Log";
            this.logToolTip.SetToolTip(this.write2log, "Write the selected patient\'s contact information to the Windows Event Log");
            this.write2log.UseVisualStyleBackColor = true;
            this.write2log.Click += new System.EventHandler(this.write2log_Click);
            // 
            // logToolTip
            // 
            this.logToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // PatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 239);
            this.Controls.Add(this.write2log);
            this.Controls.Add(this.write2file);
            this.Controls.Add(this.showAge);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PatientInfo";
            this.Text = "PatientInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showAge;
        private System.Windows.Forms.Button write2file;
        private System.Windows.Forms.Button write2log;
        private System.Windows.Forms.ToolTip logToolTip;
    }
}