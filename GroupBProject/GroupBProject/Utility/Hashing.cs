namespace GroupBProject.Utility
{
    /// <summary>
    /// Class Hashing.
    /// </summary>
    public class Hashing
    {
        /// <summary>
        /// Gets the random salt.
        /// </summary>
        /// <returns>System.String.</returns>
        private static string GetRandomSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(12);
        }

        /// <summary>
        /// Hashes the password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns>System.String.</returns>
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());
        }

        /// <summary>
        /// Validates the password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <param name="correctHash">The correct hash.</param>
        /// <returns><c>true</c> if passwords match, <c>false</c> otherwise.</returns>
        public static bool ValidatePassword(string password, string correctHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, correctHash);
        }
    }
}