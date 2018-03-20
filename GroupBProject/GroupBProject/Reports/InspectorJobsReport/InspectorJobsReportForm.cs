using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroupBProject.Reports.InspectorJobsReport
{
    /// <summary>
    /// This form allows the user to select an inspector and a date range, and generates a report of all jobs assigned to that inspector in the given range.
    /// </summary>
    public partial class InspectorJobsReportForm : Form
    {
        private Inspector selectedInspector;
        private DateTime startDate = DateTime.Today;
        private DateTime endDate = DateTime.Today;

        public InspectorJobsReportForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On form load, get all inspectors and put them into the cboInspectors combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InspectorJobsReportForm_Load(object sender, EventArgs e)
        {
            List<Inspector> allInspectors = InspectorCommands.GetActiveInspectors();

            foreach (Inspector inspector in allInspectors)
            {
                cboInspectors.Items.Add(inspector);
            }
        }

        /// <summary>
        /// If the user has selected an inspector, and if the start date is before the end date, generate the report; else, display an appropriate error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (selectedInspector is Inspector && startDate <= endDate)
            {
                GenerateReport();
            }

            if (!(selectedInspector is Inspector))
            {
                lblError.Text += "Please select an inspector. ";
            }

            if (startDate > endDate)
            {
                lblError.Text += "Start date must be before end date.";
            }
        }

        /// <summary>
        /// When the user selects an inspector with the cboInspector combo box, assign that inspector to the selectedInspector object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboInspectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedInspector = (Inspector)cboInspectors.SelectedItem;
        }

        /// <summary>
        /// When the user selects a date with the dtpStartDate date picker, assign that date to the startDate object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpStartDate.Value;
        }

        /// <summary>
        /// When the user selects a date with the dtpEndDate date picker, assign that date to the endDate object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            endDate = dtpEndDate.Value;
        }

        /// <summary>
        /// Execute the query to populate the report's data set, then refresh the report.
        /// </summary>
        private void GenerateReport()
        {
            this.JobTableAdapter.Connection = ConnectionString.GetConnection();

            this.JobTableAdapter.Fill(this.InspectorJobsReportDataSet.Job, selectedInspector.InspectorID, startDate, endDate);

            this.reportViewer1.RefreshReport();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}