using GroupBProject.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GroupBProject.Forms
{
    /// <summary>
    /// Class CreateProjectForm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CreateProjectForm : Form
    {
        #region Fields

        private Project projectAdded = null;
        private Project projectModified = null;
        private Inspector headInspector = null;
        private Project p = new Project();
        private List<Job> jobs = new List<Job>();
        private List<Job> newjobs = new List<Job>();
        private int projectid;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectForm"/> class.
        /// </summary>
        public CreateProjectForm()
        {
            InitializeComponent();
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                0);
        }

        /// <summary>
        /// Handles the Load event of the CreateProjectForm control.
        /// </summary>
        private void CreateProjectForm_Load(object sender, EventArgs e)
        {
            // Enable and disable job functionality - if we're creating a new project, the job section doesn't show. If we are modifying, it does.
            if (this.Tag.ToString() == "Job")
            {
                grpJobs.Visible = true;

                this.Size = new Size(871, 882);
                btnSaveProject.Location = new Point(238, 778);
                btnCancel.Location = new Point(465, 778);
            }
            else
            {
                grpJobs.Visible = false;
                this.Size = new Size(871, 525);

                btnSaveProject.Location = new Point(238, 410);
                btnCancel.Location = new Point(465, 410);
            }
        }

        #endregion Constructors

        #region ButtonClickMethods

        /// <summary>
        /// Handles the Click event of the btnAssignHeadInspector control. Opens the available inspector form
        /// to choose from a list of head inspectors to assign to the project.
        /// </summary>
        private void btnAssignHeadInspector_Click(object sender, EventArgs e)
        {
            //
            headInspector = null;
            var availableInspectors = new AvailableInspectorForm();
            headInspector = availableInspectors.AssignHeadInspector();
            if (headInspector != null)
            {
                headInspector = new Inspector(headInspector.InspectorID, headInspector.FirstName, headInspector.LastName, headInspector.Email,
                    headInspector.Phone, headInspector.IsActive, headInspector.WeeklyAvailability, headInspector.Qualifications);

                lblErrorRemove.Text = "";
                lblErrorRemove.Visible = true;

                txtHeadInspector.Text = headInspector.FirstName + " " + headInspector.LastName;
            }
        }

        //
        /// <summary>
        /// Handles the Click event of the btnCancel control. Closes out the form along with clearing the job list
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            jobs.Clear();
            this.Close();
        }

        //
        /// <summary>
        /// Handles the handles the add job click event.
        /// </summary>
        private void btnAddJob_Click(object sender, EventArgs e)
        {
            AddJobForm Jobs = new AddJobForm();
            Jobs.ShowDialog();

            lstCurrenftJobs.Items.Clear();
            jobs = JobCommands.GetJobsByProjectID(projectid);
            if (jobs.Count != 0)
            {
                foreach (Job job in jobs)
                {
                    lstCurrenftJobs.Items.Add(job);
                }
            }

            if (Jobs.NewlyAdded.Count != 0)
            {
                foreach (Job j in Jobs.NewlyAdded)
                {
                    newjobs.Add(j);
                }
            }

            foreach (Job o in newjobs)
            {
                lstCurrenftJobs.Items.Add(o);
            }
        }

        //
        /// <summary>
        /// Handles the handles the edit job click event.
        /// </summary>
        private void btnEditJob_Click(object sender, EventArgs e)
        {
            Job aJob = new Job();

            if (Validator.IsSelected(lstCurrenftJobs, lblJobError))
            {
                aJob = (Job)lstCurrenftJobs.SelectedItem;
                if (aJob.JobID == 0)
                {
                    foreach (Job job in newjobs)
                    {
                        if (aJob.Name == job.Name)
                        {
                            aJob = job;
                            AddJobForm editNewJobs = new AddJobForm();
                            editNewJobs.EditJob(aJob);
                            if (editNewJobs.editnewjob != null)
                            {
                                aJob = editNewJobs.editnewjob;
                                newjobs.Add(aJob);
                                newjobs.Remove(job);
                            }
                            break;
                        }
                    }

                    jobs = JobCommands.GetJobsByProjectID(projectid);
                    if (jobs.Count != 0)
                    {
                        lstCurrenftJobs.Items.Clear();

                        foreach (Job j in jobs)
                        {
                            lstCurrenftJobs.Items.Add(j);
                        }
                        foreach (Job o in newjobs)
                        {
                            lstCurrenftJobs.Items.Add(o);
                        }
                        jobs.Clear();
                    }
                }
                else
                {
                    AddJobForm edit = new AddJobForm();
                    edit.EditJob(aJob);
                    jobs = JobCommands.GetJobsByProjectID(projectid);
                    if (jobs.Count != 0)
                    {
                        lstCurrenftJobs.Items.Clear();

                        foreach (Job j in jobs)
                        {
                            lstCurrenftJobs.Items.Add(j);
                        }
                        foreach (Job o in newjobs)
                        {
                            lstCurrenftJobs.Items.Add(o);
                        }
                        jobs.Clear();
                    }
                }
            }
        }

        //
        /// <summary>
        /// Handles the Click event of the btnRemoveJob control. Removes a job from a project.
        /// </summary>
        private void btnRemoveJob_Click(object sender, EventArgs e)
        {
            Job aJob = new Job();

            if (Validator.IsSelected(lstCurrenftJobs, lblJobError))
            {
                aJob = (Job)lstCurrenftJobs.SelectedItem;

                DialogResult result;
                result = MessageBox.Show("Are you sure you want to remove " + aJob.Name, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (aJob.JobID == 0)
                    {
                        foreach (Job j in newjobs)
                        {
                            if (aJob.Name == j.Name)
                            {
                                newjobs.Remove(j);
                                break;
                            }
                        }
                        jobs = JobCommands.GetJobsByProjectID(projectid);
                        if (jobs.Count != 0)
                        {
                            lstCurrenftJobs.Items.Clear();
                            foreach (Job o in jobs)
                            {
                                lstCurrenftJobs.Items.Add(o);
                            }
                            jobs.Clear();
                        }
                        foreach (Job o in newjobs)
                        {
                            lstCurrenftJobs.Items.Add(o);
                        }
                    }
                    else
                    {
                        p.RemoveJob(aJob);
                        jobs = JobCommands.GetJobsByProjectID(projectid);
                        if (jobs.Count != 0)
                        {
                            lstCurrenftJobs.Items.Clear();

                            foreach (Job j in jobs)
                            {
                                lstCurrenftJobs.Items.Add(j);
                            }
                            jobs.Clear();
                        }
                        foreach (Job o in newjobs)
                        {
                            lstCurrenftJobs.Items.Add(o);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnRemoveHeadInspector control.
        /// </summary>
        private void btnRemoveHeadInspector_Click(object sender, EventArgs e)
        {
            if (txtHeadInspector.Text == "")
            {
                lblErrorRemove.Text = "Must have an assigned inspector \nin order to remove an inspector";
                lblErrorRemove.ForeColor = Color.Red;
                lblErrorRemove.Visible = true;
            }
            else
            {
                headInspector = null;
                txtHeadInspector.Text = "";
            }
        }

        /// <summary>
        /// Handles the Click click event of the Save Project.
        /// </summary>
        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            string title;
            string address;
            string description;
            bool isComplete = false;

            if (IsValid())
            {
                title = txtProjectTitle.Text;
                address = txtProjectAddress.Text;
                description = txtProjectDescription.Text;
                isComplete = chkProjectComplete.Checked;

                if (projectModified == null) // if projectModified hasn't been set, we are adding a new project.
                {
                    if (headInspector == null)
                    {
                        lblErrorRemove.Text = "You must assign a head\n inspector";
                        lblErrorRemove.Visible = true;
                        lblErrorRemove.ForeColor = Color.Red;
                        return;
                    }

                    if (headInspector != null)
                    {
                        lblErrorRemove.Text = "";
                        lblErrorRemove.Visible = false;
                        projectAdded = new Project(title, description, address);
                        projectAdded.HeadInspector = headInspector;
                    }
                }
                else  // we are modifying an existing project
                {
                    projectModified.Title = title;
                    projectModified.Address = address;
                    projectModified.Description = description;
                    projectModified.IsComplete = isComplete;
                    if (headInspector != null && projectModified.HeadInspector.InspectorID != headInspector.InspectorID)
                    {
                        projectModified.HeadInspector = headInspector;
                        ProjectCommands.AssignHeadInspector(projectModified, headInspector); // need to pass the head inspector id separately to the database
                    }

                    //when Save is clicked it will take the added jobs to the project and place them in the DB
                    if (newjobs.Count != 0)
                    {
                        foreach (Job j in newjobs)
                        {
                            j.ProjectID = projectid;
                            p.AddJob(j);
                        }
                    }

                    ProjectCommands.EditProject(projectModified);
                }
                this.Close();
            }
        }

        #endregion ButtonClickMethods

        #region Methods

        /// <summary>
        /// Adds the project to the database.
        /// </summary>
        public Project AddProject()
        {
            this.ShowDialog();
            if (projectAdded != null)
            {
                projectAdded.ProjectID = ProjectCommands.AddProject(projectAdded);
            }
            return projectAdded;
        }

        /// <summary>
        /// Updates a project.
        /// </summary>
        /// <param name="selectedProject">The selected project.</param>
        public void EditProject(Project selectedProject)
        {
            this.Text = "Edit Project";
            lblTitle.Text = "Edit Project";

            projectModified = selectedProject;

            //this is the projectID that the job needs in order to add, remove, or edit
            projectid = selectedProject.ProjectID;

            txtProjectTitle.Text = projectModified.Title;
            txtProjectAddress.Text = projectModified.Address;
            txtProjectDescription.Text = projectModified.Description;
            chkProjectComplete.Checked = projectModified.IsComplete;
            if (projectModified.HeadInspector != null)
            {
                txtHeadInspector.Text = projectModified.HeadInspector.FirstName + " " + projectModified.HeadInspector.LastName;
            }

            //Shows the jobs if any for the selected project
            jobs = JobCommands.GetJobsByProjectID(selectedProject.ProjectID);
            if (jobs.Count != 0)
            {
                lstCurrenftJobs.Items.Clear();

                foreach (Job j in jobs)
                {
                    lstCurrenftJobs.Items.Add(j);
                }
            }
            else
            {
                lstCurrenftJobs.Items.Add("There are currently no jobs assigned to this project");
            }

            this.ShowDialog();
            return;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the lstCurrenftJobs control. When a job is selected from the list the error message goes away.
        /// </summary>
        private void lstCurrenftJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblJobError.Visible = false;
        }

        //
        /// <summary>
        /// Validates user input.
        /// </summary>
        /// <returns><c>true</c> if this instance is valid; otherwise, <c>false</c>.</returns>
        private bool IsValid()
        {
            return Validator.IsPresent(txtProjectTitle, lblTheTitle) &
                    Validator.IsPresent(txtProjectAddress, lblAddress) &
                    Validator.IsPresent(txtProjectDescription, lblDescription);
        }

        #endregion Methods
    }
}