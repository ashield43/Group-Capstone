namespace GroupBProject.Forms
{
    partial class ReportSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportSelectorForm));
            this.btnInspectorContactInfoReport = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnInspectorAvailabilityReport = new System.Windows.Forms.Button();
            this.btnInspectorJobsReport = new System.Windows.Forms.Button();
            this.btnProjectProgressReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInspectorContactInfoReport
            // 
            this.btnInspectorContactInfoReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnInspectorContactInfoReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspectorContactInfoReport.ForeColor = System.Drawing.Color.White;
            this.btnInspectorContactInfoReport.Location = new System.Drawing.Point(24, 249);
            this.btnInspectorContactInfoReport.Name = "btnInspectorContactInfoReport";
            this.btnInspectorContactInfoReport.Size = new System.Drawing.Size(255, 63);
            this.btnInspectorContactInfoReport.TabIndex = 2;
            this.btnInspectorContactInfoReport.Tag = "2";
            this.btnInspectorContactInfoReport.Text = "Inspector Contact Info Report";
            this.btnInspectorContactInfoReport.UseVisualStyleBackColor = false;
            this.btnInspectorContactInfoReport.Click += new System.EventHandler(this.btnInspectorContactReport_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnGenerateReport.Enabled = false;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(492, 463);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(168, 51);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(447, 391);
            this.lblDescription.MaximumSize = new System.Drawing.Size(450, 625);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(222, 19);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Please select a report type.";
            // 
            // btnInspectorAvailabilityReport
            // 
            this.btnInspectorAvailabilityReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnInspectorAvailabilityReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspectorAvailabilityReport.ForeColor = System.Drawing.Color.White;
            this.btnInspectorAvailabilityReport.Location = new System.Drawing.Point(24, 49);
            this.btnInspectorAvailabilityReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInspectorAvailabilityReport.Name = "btnInspectorAvailabilityReport";
            this.btnInspectorAvailabilityReport.Size = new System.Drawing.Size(255, 63);
            this.btnInspectorAvailabilityReport.TabIndex = 0;
            this.btnInspectorAvailabilityReport.Tag = "1";
            this.btnInspectorAvailabilityReport.Text = "Inspector Availability Report";
            this.btnInspectorAvailabilityReport.UseVisualStyleBackColor = false;
            this.btnInspectorAvailabilityReport.Click += new System.EventHandler(this.btnInspectorAvailabilityReport_Click);
            // 
            // btnInspectorJobsReport
            // 
            this.btnInspectorJobsReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnInspectorJobsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspectorJobsReport.ForeColor = System.Drawing.Color.White;
            this.btnInspectorJobsReport.Location = new System.Drawing.Point(24, 349);
            this.btnInspectorJobsReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInspectorJobsReport.Name = "btnInspectorJobsReport";
            this.btnInspectorJobsReport.Size = new System.Drawing.Size(255, 63);
            this.btnInspectorJobsReport.TabIndex = 3;
            this.btnInspectorJobsReport.Tag = "3";
            this.btnInspectorJobsReport.Text = "Inspector Jobs Report";
            this.btnInspectorJobsReport.UseVisualStyleBackColor = false;
            this.btnInspectorJobsReport.Click += new System.EventHandler(this.btnInspectorJobsReport_Click);
            // 
            // btnProjectProgressReport
            // 
            this.btnProjectProgressReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnProjectProgressReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectProgressReport.ForeColor = System.Drawing.Color.White;
            this.btnProjectProgressReport.Location = new System.Drawing.Point(24, 149);
            this.btnProjectProgressReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProjectProgressReport.Name = "btnProjectProgressReport";
            this.btnProjectProgressReport.Size = new System.Drawing.Size(255, 63);
            this.btnProjectProgressReport.TabIndex = 1;
            this.btnProjectProgressReport.Tag = "4";
            this.btnProjectProgressReport.Text = "Project Progress Report";
            this.btnProjectProgressReport.UseVisualStyleBackColor = false;
            this.btnProjectProgressReport.Click += new System.EventHandler(this.btnProjectProgressReport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.btnCloseForm);
            this.panel1.Controls.Add(this.btnInspectorAvailabilityReport);
            this.panel1.Controls.Add(this.btnInspectorJobsReport);
            this.panel1.Controls.Add(this.btnProjectProgressReport);
            this.panel1.Controls.Add(this.btnInspectorContactInfoReport);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 554);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(24, 449);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(255, 63);
            this.btnCloseForm.TabIndex = 4;
            this.btnCloseForm.Text = "Close Form";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GroupBProject.Properties.Resources.report_card;
            this.pictureBox1.Location = new System.Drawing.Point(435, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ReportSelectorForm
            // 
            this.AcceptButton = this.btnGenerateReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupBProject.Properties.Resources.concrete_texture;
            this.ClientSize = new System.Drawing.Size(822, 552);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnGenerateReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a Report";
            this.Load += new System.EventHandler(this.ReportSelectorForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInspectorContactInfoReport;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnInspectorAvailabilityReport;
        private System.Windows.Forms.Button btnInspectorJobsReport;
        private System.Windows.Forms.Button btnProjectProgressReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCloseForm;
    }
}