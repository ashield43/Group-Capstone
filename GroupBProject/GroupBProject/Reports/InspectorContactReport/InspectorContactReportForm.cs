using System;
using System.Windows.Forms;

namespace GroupBProject.Reports.InspectorContactReport
{
    /// <summary>
    /// This form generates a report of all active inspectors and their contact info. This report does not have a parameter.
    /// </summary>
    public partial class InspectorContactReportForm : Form
    {
        public InspectorContactReportForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Execute the query to populate the report's data set, then refresh the report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InspectorContactReportForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            this.InspectorTableAdapter.Connection = ConnectionString.GetConnection();

            this.InspectorTableAdapter.Fill(this.InspectorContactReportDataSet.Inspector);

            this.reportViewer1.RefreshReport();
        }
    }
}