using System;
using System.Windows.Forms;

namespace GroupBProject
{
    /// <summary>
    ///The DailyAvailability class is used to create a block of time an inspector is available to be assigned
    /// a job.
    /// </summary>
    public class DailyAvailability
    {
        #region Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the day of week.
        /// </summary>
        /// <value>The day of the week assigned to the block of time.</value>
        public string DayOfWeek { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        /// <value>The start time of the inspector's availability.</value>
        public int StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        /// <value>The end time of the inspector's availability.</value>
        public int EndTime { get; set; }

        /// <summary>
        /// Gets or sets the is available.
        /// </summary>
        /// <value>Used to determine if the current time block has already been assigned.</value>
        public Boolean IsAvailable { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Empty constructor. Initializes a new instance of the <see cref="DailyAvailability"/> class.
        /// </summary>
        public DailyAvailability()
        {
        }

        /// <summary>
        /// Overloaded constructor. Initializes a new instance of the <see cref="DailyAvailability"/> class.
        /// </summary>
        /// <param name="theDay">The day.</param>
        /// <param name="theStartTime">The start time.</param>
        /// <param name="theEndTime">The end time.</param>
        /// <param name="isAvailable">The is available.</param>
        public DailyAvailability(string theDay, int theStartTime, int theEndTime, Boolean isAvailable)
        {
            this.DayOfWeek = theDay;
            this.StartTime = theStartTime;
            this.EndTime = theEndTime;
            this.IsAvailable = isAvailable;
        }

        #endregion Constructors

        #region Methods
                
        #endregion Methods
    }
}