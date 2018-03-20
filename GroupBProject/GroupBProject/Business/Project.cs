using System.Collections.Generic;

namespace GroupBProject
{
    /// <summary>
    ///Creates an instance of the Project class. An instance of the Projct contains a head inspector
    /// and a list of the jobs currently assigned to the project.
    /// </summary>
    public class Project
    {
        #region Properties

        /// <summary>
        /// Gets or sets the project id.
        /// </summary>
        /// <value>The project's id.</value>
        public int ProjectID { get; set; }

        /// <summary>
        /// Gets or sets the head inspector for the project.
        /// </summary>
        /// <value>The head inspector.</value>
        public Inspector HeadInspector { get; set; }

        /// <summary>
        /// Gets or sets the title of the project.
        /// </summary>
        /// <value>The project's title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the project's description.
        /// </summary>
        /// <value>The project's description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the project's address.
        /// </summary>
        /// <value>The project's address.</value>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the list of jobs for the project.
        /// </summary>
        /// <value>The list of the project's jobs.</value>
        public List<Job> Jobs { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this project is complete.
        /// </summary>
        /// <value><c>true</c> if this project is complete; otherwise, <c>false</c>.</value>
        public bool IsComplete { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Empty constructor. Initializes a new instance of the <see cref="Project"/> class.
        /// </summary>
        public Project() { }

        /// <summary>
        /// Overloaded constructor. Initializes a new instance of the <see cref="Project"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="description">The description.</param>
        /// <param name="address">The address.</param>
        public Project(string title, string description, string address)
        {
            Title = title;
            Description = description;
            Address = address;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Adds a job to the project's job list.
        /// </summary>
        /// <param name="job">The job.</param>
        public void AddJob(Job job)
        {
            if (job != null)
            {
                job.JobID = JobCommands.AddJob(job);
            }
        }

        /// <summary>
        /// Removes a job from the project's job list.
        /// </summary>
        /// <param name="job">The job.</param>
        public void RemoveJob(Job job)
        {
            JobCommands.DeleteJob(job);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return "Project " + this.Title;
        }

        #endregion Methods
    }
}