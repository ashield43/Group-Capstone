namespace GroupBProject
{
    /// <summary>
    /// User class.
    /// </summary>
    internal class User
    {
        #region Properties

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>The user's id.</value>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the type of the user.
        /// </summary>
        /// <value>The user type.</value>
        public string UserType { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The user's username.</value>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The user's password.</value>
        public string Password { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="theUserType">Type of the user.</param>
        /// <param name="theUsername">The username.</param>
        /// <param name="thePassword">The user password.</param>
        public User(string theUserType, string theUsername, string thePassword)
        {
            this.UserType = theUserType;
            this.Username = theUsername;
            this.Password = thePassword;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Determines whether this user is an administrator.
        /// </summary>
        /// <returns><c>true</c> if this user is an administrator; otherwise, <c>false</c>.</returns>
        public bool IsAdmin()
        {
            if (this.UserType == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this user.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this user.</returns>
        public override string ToString()
        {
            return "User: " + this.UserType + ": " + this.Username;
        }

        #endregion Methods
    }
}