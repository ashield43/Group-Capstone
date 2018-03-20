using GroupBProject.Business;
using GroupBProject.Database;
using GroupBProject.Reports.InspectorAvailabilityReport;
using GroupBProject.Reports.InspectorContactReport;
using GroupBProject.Reports.InspectorJobsReport;
using GroupBProject.Reports.ProjectProgressReport;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GroupBProject.Forms
{
    /// <summary>
    /// This form lets the user select which type of report they want. User must click a button to select that type of report.
    /// </summary>
    public partial class ReportSelectorForm : Form
    {
        #region Fields

        private List<ReportType> allReports;
        private ReportType selectedReport = new ReportType();

        #endregion Fields

        #region Constructors

        public ReportSelectorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load all report types on form load so we don't have to keep calling the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportSelectorForm_Load(object sender, EventArgs e)
        {
            allReports = ReportCommands.GetReports();
        }

        #endregion Constructors

        #region ButtonClickMethods

        /// <summary>
        /// Open the selected report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (selectedReport.ID)
            {
                case 1:
                    InspectorAvailabilityReportForm inspectorAvailabilityReportForm = new InspectorAvailabilityReportForm();
                    inspectorAvailabilityReportForm.ShowDialog();
                    break;

                case 2:
                    InspectorContactReportForm inspectorContactReportForm = new InspectorContactReportForm();
                    inspectorContactReportForm.ShowDialog();
                    break;

                case 3:
                    InspectorJobsReportForm inspectorJobsReportForm = new InspectorJobsReportForm();
                    inspectorJobsReportForm.ShowDialog();
                    break;

                case 4:
                    ProjectProgressReportForm projectProgressReportForm = new ProjectProgressReportForm();
                    projectProgressReportForm.ShowDialog();
                    break;
            }
        }

        /// <summary>
        /// Select the Inspector Contact Report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInspectorContactReport_Click(object sender, EventArgs e)
        {
            SetupReport(sender);
            btnInspectorContactInfoReport.Select();
        }

        /// <summary>
        /// Select the Inspector Availability Report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInspectorAvailabilityReport_Click(object sender, EventArgs e)
        {
            SetupReport(sender);
            btnInspectorAvailabilityReport.Select();
        }

        /// <summary>
        /// Select the Inspector Jobs Report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInspectorJobsReport_Click(object sender, EventArgs e)
        {
            SetupReport(sender);
            btnInspectorJobsReport.Select();
        }

        /// <summary>
        /// Select the Project Progress Report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProjectProgressReport_Click(object sender, EventArgs e)
        {
            SetupReport(sender);
            btnProjectProgressReport.Select();
        }

        #endregion ButtonClickMethods

        /// <summary>
        /// Sends the ReportID to SetSelectedReport method and enables the generate report button
        /// </summary>
        /// <param name="sender"></param>
        private void SetupReport(object sender)
        {
            SetSelectedReport(Convert.ToInt32(((Button)sender).Tag));
            btnGenerateReport.Enabled = true;
        }

        /// <summary>
        /// Set the selectedReport using the ReportID number in tag of the button. Update the description label.
        /// </summary>
        /// <param name="selectedReportID"></param>
        private void SetSelectedReport(int selectedReportID)
        {
            foreach (ReportType reportType in allReports)
            {
                if (reportType.ID == selectedReportID)
                {
                    selectedReport = reportType;
                }
            }

            lblDescription.Text = selectedReport.Description;
            lblDescription.Location = new Point(230, 254);
            lblDescription.Width = 250;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}