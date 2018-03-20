using GroupBProject.Business;
using System;
using System.Linq;

namespace GroupBProject
{
    /// <summary>
    /// The job class is used to create a new job.
    /// </summary>
    public class Job
    {
        #region Properties

        /// <summary>
        /// Gets or sets the job id.
        /// </summary>
        /// <value>The Job's id.</value>
        public int JobID { get; set; }

        /// <summary>
        /// Gets or sets the job's name.
        /// </summary>
        /// <value>The job's name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the job's description.
        /// </summary>
        /// <value>The job's description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date of the job.
        /// </summary>
        /// <value>The date of the job.</value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the start time for the job.
        /// </summary>
        /// <value>The job's start time.</value>
        public int StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time for the job.
        /// </summary>
        /// <value>The job's end time.</value>
        public int EndTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the job is complete.
        /// </summary>
        /// <value><c>true</c> if this job is complete; otherwise, <c>false</c>.</value>
        public bool IsComplete { get; set; }

        /// <summary>
        /// Gets or sets the inspector id.
        /// </summary>
        /// <value>The inspector's id.</value>
        public int InspectorID { get; set; }

        /// <summary>
        /// Gets or sets the required qualification for the job.
        /// </summary>
        /// <value>The required job qualification.</value>
        public Qualification RequiredQualification { get; set; }

        /// <summary>
        /// Gets or sets the project id associated with the job.
        /// </summary>
        /// <value>The project's id.</value>
        public int ProjectID { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Empty constructor. Initializes a new instance of the <see cref="Job"/> class.
        /// </summary>
        public Job()
        {
        }

        /// <summary>
        /// Overloaded constructor. Initializes a new instance of the <see cref="Job"/> class.
        /// </summary>
        /// <param name="theName">The job name.</param>
        /// <param name="theDescription">The job description.</param>
        /// <param name="theDate">The job's date.</param>
        /// <param name="theStartTime">The job's start time.</param>
        /// <param name="theEndTime">The job's end time.</param>
        /// <param name="theRequiredQualification">The job's required qualification.</param>
        public Job(string theName, string theDescription, DateTime theDate, int theStartTime, int theEndTime, Qualification theRequiredQualification)
        {
            Name = theName;
            Description = theDescription;
            Date = theDate;
            StartTime = theStartTime;
            EndTime = theEndTime;
            RequiredQualification = theRequiredQualification;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Checks to see if the inspector can be added to the job.
        /// </summary>
        /// <param name="inspector">The inspector needing to be added to the job.</param>
        /// <returns>Boolean.</returns>
        public Boolean AddInspector(Inspector inspector)
        {
            if (CheckInspectorAvailability(inspector))
            {
                this.InspectorID = inspector.InspectorID;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks the inspector's availability.
        /// </summary>
        /// <param name="inspector">The inspector whose availability you want to check.</param>
        /// <returns>Boolean.</returns>
        public Boolean CheckInspectorAvailability(Inspector inspector)
        {
            if (CheckInspectorQualifications(inspector) && CheckInspectorWeeklyAvailability(inspector) && CheckInspectorAssignments(inspector))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks to see if the inspector has the required qualification for the job.
        /// </summary>
        /// <param name="inspector">The inspector whose qualifications needs to be checked.</param>
        /// <returns>True if the inspector has the required qualificaiton. False if the inspector doesn't.</returns>
        public Boolean CheckInspectorQualifications(Inspector inspector)
        {
            if (inspector.Qualifications.Any(qualification => qualification.Name == this.RequiredQualification.Name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks the inspector's weekly availability to see if they are available to be assigned to the job.
        /// </summary>
        /// <param name="inspector">The inspector whose weekly availability needs to be checked.</param>
        /// <returns>Returns true if the inspector is available. False if the inspector is unavailable.</returns>
        public Boolean CheckInspectorWeeklyAvailability(Inspector inspector)
        {
            if (this.Date.DayOfWeek.ToString() == "Saturday" || this.Date.DayOfWeek.ToString() == "Sunday")
            {
                return false;
            }

            foreach (DailyAvailability dailyAvailability in inspector.WeeklyAvailability)
            {
                if (dailyAvailability.DayOfWeek == this.Date.DayOfWeek.ToString())
                {
                    if (!dailyAvailability.IsAvailable || this.StartTime < dailyAvailability.StartTime || this.EndTime > dailyAvailability.EndTime)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Checks the list of the inspector's current assignments to see if they are available during
        /// any assignment falls between the start and end time of this job.
        /// </summary>
        /// <param name="inspector">The inspector whose job assignments need to be checked.</param>
        /// <returns>Boolean.</returns>
        public Boolean CheckInspectorAssignments(Inspector inspector)
        {
            foreach (Job assignedJob in inspector.AssignedJobs)
            {
                if (assignedJob.Date == this.Date)
                {
                    if ((this.StartTime > assignedJob.StartTime && this.StartTime < assignedJob.EndTime) || (this.EndTime > assignedJob.StartTime && this.EndTime < assignedJob.EndTime))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this job.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this job.</returns>
        public override string ToString()
        {
            string complete = "";
            Inspector inspector;
            string s = "";

            if(InspectorID == 0)
            {
                s = "Not Assigned";
            }
            else
            {
                inspector = InspectorCommands.GetInspectorByID(InspectorID);
                s = inspector.FirstName + " " + inspector.LastName;
            }

            if(IsComplete == false)
            {
                complete = "Incomplete";
            }
            else
            {
                complete = "Completed";
            }

            return String.Format("{0,-10}  |  {1, -10}  |  {2, -10}  |  {3, -10}  |  {4, -10}", Date.ToShortDateString(), Name, RequiredQualification, s, complete);
        }

        #endregion Methods
    }
}