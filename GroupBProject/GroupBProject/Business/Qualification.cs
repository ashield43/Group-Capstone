using System;

namespace GroupBProject.Business
{
    /// <summary>
    /// This class is used to create a single instance of an inspector qualification.
    /// </summary>
    public class Qualification
    {
        #region Properties

        /// <summary>
        /// Gets or sets the qualification id.
        /// </summary>
        /// <value>The qualification id.</value>
        public virtual int ID { get; set; }

        /// <summary>
        /// Gets or sets the qualification name.
        /// </summary>
        /// <value>The qualificaiton name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the is job qualification.
        /// </summary>
        /// <value>The is job qualification.</value>
        public Boolean IsJobQualification { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Empty constructor. Initializes a new instance of the <see cref="Qualification"/> class.
        /// </summary>
        public Qualification()
        {
        }

        /// <summary>
        /// Overloaded constructor. Initializes a new instance of the <see cref="Qualification"/> class.
        /// </summary>
        /// <param name="name">The qualification name.</param>
        /// <param name="isJobQualification">The is job qualification.</param>
        public Qualification(string name, Boolean isJobQualification)
        {
            Name = name;
            IsJobQualification = isJobQualification;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this qualification.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this qualification.</returns>
        public override string ToString()
        {
            return Name;
        }

        #endregion Methods
    }
}