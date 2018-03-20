using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroupBProject.Forms
{
    /// <summary>
    /// Class Form1.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1 : Form
    {
        #region Fields

        private List<Project> allProjects = new List<Project>();
        private Project selectedProject = null;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowProjects();
        }

        #endregion Constructors

        #region ButtonClickMethods

        /// <summary>
        /// Handles the Click event of the btnCreateProject control.
        /// </summary>
        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            Project newProject = null;

            // new instance of add project form, and run add project method to create a new project
            CreateProjectForm addProjectForm = new CreateProjectForm();
            newProject = addProjectForm.AddProject();

            // add new project to the all projects list and refresh the list
            if (newProject != null)
            {
                allProjects.Add(newProject);
                ShowProjects();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnEditProject control.
        /// </summary>
        private void btnEditProject_Click(object sender, EventArgs e)
        {
            selectedProject = (Project)lstProjectList.SelectedItem;

            if (selectedProject != null)
            {
                CreateProjectForm modifiedProject = new CreateProjectForm();
                modifiedProject.Tag = "Job";
                modifiedProject.EditProject(selectedProject);
                ProjectCommands.EditProject(selectedProject);
                ShowProjects();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You must select a project to edit.", "Select A Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnRemoveProject control.
        /// </summary>
        private void btnRemoveProject_Click(object sender, EventArgs e)
        {
            if ((Project)lstProjectList.SelectedItem == null)
            {
                MessageBox.Show("Please select a project to remove", "Deletion Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            DialogResult dialogResult = MessageBox.Show("Removing a project will also remove all assigned jobs. Are you sure?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                selectedProject = (Project)lstProjectList.SelectedItem;
                allProjects.Remove(selectedProject);
                ProjectCommands.DeleteProject(selectedProject);
                ShowProjects();
            }
            else if (dialogResult == DialogResult.No)
            {
                // Do nothing.
            }
        }

        /// <summary>
        /// Handles the Click event of the btnReports control.
        /// </summary>
        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportSelectorForm reportSelectorForm = new ReportSelectorForm();
            reportSelectorForm.ShowDialog();
        }

        #endregion ButtonClickMethods

        #region Methods

        /// <summary>
        /// Shows a list of all of the projects.
        /// </summary>
        private void ShowProjects()
        {
            lstProjectList.Items.Clear();

            allProjects = ProjectCommands.GetProjects();

            foreach (Project p in allProjects)
            {
                lstProjectList.Items.Add(p);
            }
        }

        /// <summary>
        /// Exits the scheduler.
        /// </summary>
        private void ExitScheduler(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens the add edit inspector form.
        /// </summary>
        private void OpenAddEditInspectorForm(object sender, EventArgs e)
        {
            var currentInspectors = new CurrentInspectorForm();

            currentInspectors.ShowDialog();
        }

        #endregion Methods
    }
}