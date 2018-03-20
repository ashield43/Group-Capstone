namespace GroupBProject.Reports.InspectorAvailabilityReport
{
    partial class InspectorAvailabilityReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectorAvailabilityReportForm));
            this.DailyAvailabilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InspectorWeeklyAvailabilityReportDataSet = new GroupBProject.Reports.InspectorAvailabilityReport.InspectorWeeklyAvailabilityReportDataSet();
            this.InspectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboInspectors = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.DailyAvailabilityTableAdapter = new GroupBProject.Reports.InspectorAvailabilityReport.InspectorWeeklyAvailabilityReportDataSetTableAdapters.DailyAvailabilityTableAdapter();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DailyAvailabilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectorWeeklyAvailabilityReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DailyAvailabilityBindingSource
            // 
            this.DailyAvailabilityBindingSource.DataMember = "DailyAvailability";
            this.DailyAvailabilityBindingSource.DataSource = this.InspectorWeeklyAvailabilityReportDataSet;
            // 
            // InspectorWeeklyAvailabilityReportDataSet
            // 
            this.InspectorWeeklyAvailabilityReportDataSet.DataSetName = "InspectorWeeklyAvailabilityReportDataSet";
            this.InspectorWeeklyAvailabilityReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DailyAvailabilityBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GroupBProject.Reports.InspectorAvailabilityReport.InspectorWeeklyAvailabilityRepo" +
    "rt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(649, 494);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(429, 12);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(113, 41);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Inspector";
            // 
            // cboInspectors
            // 
            this.cboInspectors.FormattingEnabled = true;
            this.cboInspectors.Location = new System.Drawing.Point(18, 42);
            this.cboInspectors.Name = "cboInspectors";
            this.cboInspectors.Size = new System.Drawing.Size(163, 21);
            this.cboInspectors.TabIndex = 0;
            this.cboInspectors.SelectedIndexChanged += new System.EventHandler(this.cboInspectors_SelectedIndexChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(194, 30);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 5;
            // 
            // DailyAvailabilityTableAdapter
            // 
            this.DailyAvailabilityTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(548, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // InspectorAvailabilityReportForm
            // 
            this.AcceptButton = this.btnGenerateReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupBProject.Properties.Resources.concrete_texture;
            this.ClientSize = new System.Drawing.Size(673, 579);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cboInspectors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InspectorAvailabilityReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inspector Availability Report";
            this.Load += new System.EventHandler(this.InspectorAvailabilityReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DailyAvailabilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectorWeeklyAvailabilityReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InspectorBindingSource;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboInspectors;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.BindingSource DailyAvailabilityBindingSource;
        private InspectorWeeklyAvailabilityReportDataSet InspectorWeeklyAvailabilityReportDataSet;
        private InspectorWeeklyAvailabilityReportDataSetTableAdapters.DailyAvailabilityTableAdapter DailyAvailabilityTableAdapter;
        private System.Windows.Forms.Button btnCancel;
    }
}