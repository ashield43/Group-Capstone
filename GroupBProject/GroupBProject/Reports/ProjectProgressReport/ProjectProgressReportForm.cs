using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroupBProject.Reports.ProjectProgressReport
{
    /// <summary>
    /// This form allows the user to select a project and then generate a report of complete and incomplete jobs for that project.
    /// </summary>
    public partial class ProjectProgressReportForm : Form
    {
        private Project selectedProject;
        private List<Project> allProjects;

        public ProjectProgressReportForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On form load, get all projects and put them in the cboProjects combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectProgressReportForm_Load(object sender, EventArgs e)
        {
            allProjects = ProjectCommands.GetProjects();

            foreach (Project project in allProjects)
            {
                cboProjects.Items.Add(project);
            }
        }

        /// <summary>
        /// When the user selects a project with the cboProjects combo box, assign that project to the selectedProject object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProject = (Project)cboProjects.SelectedItem;
        }

        /// <summary>
        /// If the user has selected a project, generate the report; else, display an error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (selectedProject is Project)
            {
                lblError.Text = "";
                GenerateReport();
            }
            else
            {
                lblError.Text = "Please select a project.";
            }
        }

        /// <summary>
        /// Execute the query to populate the report's data set, then refresh the report.
        /// </summary>
        private void GenerateReport()
        {
            this.JobTableAdapter.Connection = ConnectionString.GetConnection();

            this.JobTableAdapter.Fill(this.ProjectProgressReportDataSet.Job, selectedProject.ProjectID);

            this.reportViewer1.RefreshReport();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}