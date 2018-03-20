using GroupBProject.Business;
using GroupBProject.Database;
using GroupBProject.Utility;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace GroupBProject.Forms
{
    public partial class AddJobForm : Form
    {
        #region Fields

        private Job aJob = new Job();
        private string flag = "Add";
        private List<Qualification> JobQualification = new List<Qualification>();
        public List<Job> NewlyAdded = new List<Job>();
        public Job editnewjob;
        private Inspector assignedInspector = null;
        private Project project = new Project();
        private int jobid;
        private int inspectorID;
        private Qualification pastQ;
        private Qualification qualification;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddJobForm"/> class.
        /// </summary>
        public AddJobForm()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Populates the combobox with the job qualifications from the db.
        /// </summary>
        private void AddJobForm_Load(object sender, EventArgs e)
        {
            JobQualification = QualificationCommands.GetJobQualifications();

            foreach (Qualification q in JobQualification)
            {
                cboAvailableQualifications.Items.Add(q);
            }
        }

        /// <summary>
        /// Outputs the info from the selected job to the user to edit.
        /// </summary>
        /// <param name="jobs">The selected job.</param>
        public void EditJob(Job jobs)
        {
            this.Text = "Edit Job";
            lblAddEditJob.Text = "Edit Job";
            aJob = jobs;
            jobid = aJob.JobID;
            txtType.Text = aJob.Name;
            txtDescription.Text = aJob.Description;
            if (jobs.InspectorID != 0)
            {
                assignedInspector = InspectorCommands.GetInspectorByID(aJob.InspectorID);
                txtAssignedInspector.Text = assignedInspector.FirstName + " " + assignedInspector.LastName;
            }
            inspectorID = aJob.InspectorID;
            dtpJobDate.Value = Convert.ToDateTime(jobs.Date.ToLongDateString());
            pastQ = aJob.RequiredQualification;
            qualification = pastQ;
            cboAvailableQualifications.Text = aJob.RequiredQualification.ToString();
            dtpStartTime.Value = DateTime.ParseExact(aJob.StartTime.ToString("00"), "HH", CultureInfo.InvariantCulture);
            dtpEndTime.Value = DateTime.ParseExact(aJob.EndTime.ToString("00"), "HH", CultureInfo.InvariantCulture);
            if(jobs.IsComplete == true)
            {
                chkComplete.CheckState = CheckState.Checked;
            }
            btnAdd.Text = "Save Modified Job";
            btnAssignInspector.Enabled = true;
            btnRemoveInspector.Enabled = true;
            flag = "edit";
            this.ShowDialog();
        }

        /// <summary>
        /// Validates input from the user
        /// </summary>
        private bool IsValid()
        {
            bool isValid = false;

            if (txtType.Text == "")
            {
                lblNameError.Text = "Please enter a job name";
            }
            else
            {
                lblNameError.Text = "";
            }

            if (txtDescription.Text == "")
            {
                lblDescriptionError.Text = "Please enter a job description";
            }
            else
            {
                lblDescriptionError.Text = "";
            }

            if (qualification == null)
            {
                lblRequiredQualificaitonError.Text = "Please choose a required qualification";
            }
            else
            {
                lblRequiredQualificaitonError.Text = "";
            }
            if (txtType.Text != "" && txtDescription.Text != "" && qualification != null)
            {
                isValid = true;
            }

            return isValid;
        }

        #endregion Methods

        #region ButtonClickEventMethods

        /// <summary>
        /// Adds a new job or adds a modified job.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name;
            string description;
            DateTime date;
            int start;
            int end;
            bool complete = false;

            if (IsValid())
            {
                name = txtType.Text;
                description = txtDescription.Text;
                date = dtpJobDate.Value.Date;
                qualification = (Qualification)cboAvailableQualifications.SelectedItem;
                start = Convert.ToInt32(dtpStartTime.Value.Hour);
                end = Convert.ToInt32(dtpEndTime.Value.Hour);
                if(chkComplete.Checked == true)
                {
                    complete = true;
                }
                

                if (flag == "Add")
                {
                    if (Validator.IsSelectedComboBox(cboAvailableQualifications))
                    {
                        if (inspectorID != 0)
                        {
                            aJob = new Job(name, description, date, start, end, qualification);
                            aJob.InspectorID = inspectorID;
                            aJob.IsComplete = complete;
                            JobCommands.AssignInspectorToJob(aJob);
                            NewlyAdded.Add(aJob);
                        }
                        this.Close();
                    }
                }
                else
                {
                    if (aJob.JobID == 0)
                    {
                        if (cboAvailableQualifications.SelectedIndex == -1)
                        {
                            editnewjob = new Job(name, description, date, start, end, pastQ);
                            aJob.IsComplete = complete;
                            if (inspectorID != 0)
                            {
                                //***Seth commented this out***
                                //editnewjob.InspectorID = inspectorID;
                                //JobCommands.AssignInspectorToJob(editnewjob);

                                if (editnewjob.CheckInspectorAvailability(InspectorCommands.GetInspectorByID(inspectorID)))
                                {
                                    editnewjob.InspectorID = inspectorID;
                                    JobCommands.AssignInspectorToJob(editnewjob);
                                }
                                else
                                {
                                    JobCommands.UnassignInspectorToJob(editnewjob);                                    
                                    MessageBox.Show("The assigned inspector is not qualified for this job. The inspector has been unassigned.");
                                }

                            }
                        }
                        else
                        {
                            editnewjob = new Job(name, description, date, start, end, qualification);
                            aJob.IsComplete = complete;
                            if (inspectorID != 0)
                            {
                                //***Seth commented this out***
                                //editnewjob.InspectorID = inspectorID;
                                //JobCommands.AssignInspectorToJob(editnewjob);

                                if (editnewjob.CheckInspectorAvailability(InspectorCommands.GetInspectorByID(inspectorID)))
                                {
                                    editnewjob.InspectorID = inspectorID;
                                    JobCommands.AssignInspectorToJob(editnewjob);
                                }
                                else
                                {
                                    JobCommands.UnassignInspectorToJob(editnewjob);
                                    MessageBox.Show("The assigned inspector is not qualified for this job. The inspector has been unassigned.");
                                }
                            }
                        }
                        this.Close();
                    }
                    else
                    {
                        if (cboAvailableQualifications.SelectedIndex == -1)
                        {
                            aJob = new Job(name, description, date, start, end, pastQ);
                            aJob.JobID = jobid;
                            aJob.IsComplete = complete;

                            if (inspectorID != 0)
                            {
                                //***Seth commented this out***
                                //aJob.InspectorID = inspectorID;
                                //JobCommands.AssignInspectorToJob(aJob);

                                if (aJob.CheckInspectorAvailability(InspectorCommands.GetInspectorByID(inspectorID)))
                                {
                                    aJob.InspectorID = inspectorID;
                                    JobCommands.AssignInspectorToJob(aJob);
                                }
                                else
                                {
                                    JobCommands.UnassignInspectorToJob(aJob);
                                    MessageBox.Show("The assigned inspector is not qualified for this job. The inspector has been unassigned.");
                                }
                            }
                            JobCommands.EditJob(aJob);
                            this.Close();
                        }
                        else
                        {
                            if (Validator.IsSelectedComboBox(cboAvailableQualifications))
                            {
                                aJob = new Job(name, description, date, start, end, qualification);
                                aJob.JobID = jobid;
                                aJob.IsComplete = complete;

                                if (inspectorID != 0)
                                {
                                    //***Seth commented this out***
                                    //aJob.InspectorID = inspectorID;
                                    //JobCommands.AssignInspectorToJob(aJob);

                                    if (aJob.CheckInspectorAvailability(InspectorCommands.GetInspectorByID(inspectorID)))
                                    {
                                        aJob.InspectorID = inspectorID;
                                        JobCommands.AssignInspectorToJob(aJob);
                                    }
                                    else
                                    {
                                        JobCommands.UnassignInspectorToJob(aJob);
                                        MessageBox.Show("The assigned inspector is not qualified for this job. The inspector has been unassigned.");
                                    }
                                }
                                JobCommands.EditJob(aJob);
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Assigns an inspector to a job.
        /// </summary>
        private void btnAssignInspector_Click(object sender, EventArgs e)
        {
            if (flag == "Add")
            {
                if (cboAvailableQualifications.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose a qualification before choosing an inspector", "Qualifications Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    assignedInspector = new Inspector();
                    var availableInspectors = new AvailableInspectorForm();
                    aJob.Date = dtpJobDate.Value.Date;
                    aJob.StartTime = Convert.ToInt32(dtpStartTime.Value.Hour);
                    aJob.EndTime = Convert.ToInt32(dtpEndTime.Value.Hour);

                    assignedInspector = availableInspectors.AssignJobInspector(aJob);
                    if (assignedInspector != null)
                    {
                        inspectorID = assignedInspector.InspectorID;
                        txtAssignedInspector.Text = assignedInspector.FirstName + " " + assignedInspector.LastName;
                        btnRemoveInspector.Enabled = true;
                    }
                }
            }
            else
            {
                if (cboAvailableQualifications.SelectedIndex == -1 && pastQ == null)
                {
                    MessageBox.Show("Please choose a qualification before choosing an inspector", "Qualifications Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }                
                else if(cboAvailableQualifications.SelectedIndex == -1)
                {                    
                    aJob.Date = dtpJobDate.Value.Date;
                    aJob.StartTime = Convert.ToInt32(dtpStartTime.Value.Hour);
                    aJob.EndTime = Convert.ToInt32(dtpEndTime.Value.Hour);
                    aJob.RequiredQualification = pastQ;

                    assignedInspector = new Inspector();
                    Job selectedJob = aJob;
                    var availableInspectors = new AvailableInspectorForm();
                    assignedInspector = availableInspectors.AssignJobInspector(selectedJob);
                    if (assignedInspector != null)
                    {
                        inspectorID = assignedInspector.InspectorID;
                        txtAssignedInspector.Text = assignedInspector.FirstName + " " + assignedInspector.LastName;
                    }
                }
                else
                {
                    aJob.Date = dtpJobDate.Value.Date;
                    aJob.StartTime = Convert.ToInt32(dtpStartTime.Value.Hour);
                    aJob.EndTime = Convert.ToInt32(dtpEndTime.Value.Hour);
                    aJob.RequiredQualification = (Qualification)cboAvailableQualifications.SelectedItem;

                    assignedInspector = new Inspector();
                    Job selectedJob = aJob;
                    var availableInspectors = new AvailableInspectorForm();
                    assignedInspector = availableInspectors.AssignJobInspector(selectedJob);
                    if (assignedInspector != null)
                    {
                        inspectorID = assignedInspector.InspectorID;
                        txtAssignedInspector.Text = assignedInspector.FirstName + " " + assignedInspector.LastName;
                    }
                }
                
                
            }
        }

        /// <summary>
        /// Removes an inspector from a job.
        /// </summary>
        private void btnRemoveInspector_Click(object sender, EventArgs e)
        {
            if (this.jobid == 0)
            {
                this.inspectorID = 0;
                txtAssignedInspector.Text = "";
            }
            else
            {
                Job selectedJob = JobCommands.GetJobByID(this.jobid);
                JobCommands.UnassignInspectorToJob(selectedJob);
                inspectorID = 0;
                txtAssignedInspector.Text = "";
            }

        }

        /// <summary>
        /// Closes out the form.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion ButtonClickEventMethods

        //when a qualification is chosen from the combo box it will enable the add inspector button
        private void cboAvailableQualifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAvailableQualifications.SelectedIndex != -1)
            {
                qualification = (Qualification)cboAvailableQualifications.SelectedItem;
                aJob.RequiredQualification = qualification;
                btnAssignInspector.Enabled = true;
            }
        }
    }
}