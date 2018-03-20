using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Sql;

namespace GroupBProject.Reports.InspectorAvailabilityReport
{
    /// <summary>
    /// This form will allow the user to select an inspector and then generate a report of that inspector's weekly availability.
    /// </summary>
    public partial class InspectorAvailabilityReportForm : Form
    {
        private Inspector selectedInspector;

        public InspectorAvailabilityReportForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On form load, get all inspectors and put them in the cboInspectors combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InspectorAvailabilityReportForm_Load(object sender, EventArgs e)
        {
            List<Inspector> allInspectors = InspectorCommands.GetActiveInspectors();

            foreach (Inspector inspector in allInspectors)
            {
                cboInspectors.Items.Add(inspector);
            }
        }

        /// <summary>
        /// If the user can selected an inspector, generate the report; else, display an error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (selectedInspector is Inspector)
            {
                lblError.Text = "";
                GenerateReport();
            }
            else
            {
                lblError.Text = "Please select an inspector";
            }
        }

        /// <summary>
        /// When the user selects an inspector in the cboInspectors combo box, assign it to the selectedInspector object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboInspectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedInspector = (Inspector)cboInspectors.SelectedItem;
        }

        /// <summary>
        /// Execute the query to populate the report's data set, then refresh the report.
        /// </summary>
        private void GenerateReport()
        {
            this.DailyAvailabilityTableAdapter.Connection = ConnectionString.GetConnection();

            this.DailyAvailabilityTableAdapter.Fill(this.InspectorWeeklyAvailabilityReportDataSet.DailyAvailability, selectedInspector.InspectorID);
            this.reportViewer1.RefreshReport();
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}