using GroupBProject.Business;
using System.Collections.Generic;

namespace GroupBProject
{
    /// <summary>
    /// Inspector class used to create an instance of an instructor.
    /// </summary>
    public class Inspector
    {
        #region Properties

        /// <summary>
        /// Gets or sets the inspector's id.
        /// </summary>
        /// <value>The inspector's id.</value>
        public int InspectorID { get; set; }

        /// <summary>
        /// Gets or sets the inspector's first name.
        /// </summary>
        /// <value>The inspector's first name.</value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the inspector's last name.
        /// </summary>
        /// <value>The inspector's last name.</value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the inspector's email.
        /// </summary>
        /// <value>The inspector's email.</value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the inspector's phone number.
        /// </summary>
        /// <value>The inspector's phone number.</value>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this inspector is active.
        /// </summary>
        /// <value><c>true</c> if this inspector is active; otherwise, <c>false</c>.</value>
        public bool IsActive { get; set; }

        /// <summary>
        /// A list of the inspector's weekly availability.
        /// </summary>
        /// <value>The inspector's weekly availability.</value>
        public List<DailyAvailability> WeeklyAvailability { get; set; }

        /// <summary>
        /// Gets or sets the list of the inspector's currently assigned jobs.
        /// </summary>
        /// <value>The inspector's assigned jobs.</value>
        public List<Job> AssignedJobs { get; set; }

        /// <summary>
        /// Gets or sets the list of the inspector's current qualifications.
        /// </summary>
        /// <value>The inspector's qualifications.</value>
        public List<Qualification> Qualifications { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Empty constructor. Initializes a new instance of the <see cref="Inspector"/> class.
        /// </summary>
        public Inspector() { }

        /// <summary>
        /// Overloaded constructor. Initializes a new instance of the <see cref="Inspector"/> class.
        /// </summary>
        /// <param name="firstName">The inspector first name.</param>
        /// <param name="lastName">The inspector last name.</param>
        /// <param name="email">The inspector email.</param>
        /// <param name="phone">The inspector phone number.</param>
        /// <param name="isActive">if set to <c>true</c> [is active].</param>
        /// <param name="weeklyAvailability">The inspector's weekly availability.</param>
        /// <param name="qualifications">The inspector's qualifications.</param>
        public Inspector(string firstName, string lastName, string email, string phone, bool isActive, List<DailyAvailability> weeklyAvailability, List<Qualification> qualifications)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            IsActive = isActive;
            WeeklyAvailability = weeklyAvailability;
            Qualifications = qualifications;
        }

        /// <summary>
        /// Initializes a new overloaded instance of the <see cref="Inspector"/> class.
        /// This constructor is used to create an inspector object from an inspector pulled from the database.
        /// </summary>
        /// <param name="inspectorId">The inspector identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="email">The email.</param>
        /// <param name="phone">The phone.</param>
        /// <param name="isActive">if set to <c>true</c> [is active].</param>
        /// <param name="weeklyAvailability">The weekly availability.</param>
        /// <param name="qualifications">The qualifications.</param>
        public Inspector(int inspectorId, string firstName, string lastName, string email, string phone, bool isActive, List<DailyAvailability> weeklyAvailability, List<Qualification> qualifications)
        {
            InspectorID = inspectorId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            IsActive = isActive;
            WeeklyAvailability = weeklyAvailability;
            Qualifications = qualifications;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this inspector.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents - Inspector name: 'inspectors name' -.</returns>
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        #endregion Methods
    }
}