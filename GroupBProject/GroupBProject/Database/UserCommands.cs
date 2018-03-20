using GroupBProject.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupBProject
{
    /// <summary>
    /// Class UserCommands.
    /// </summary>
    internal class UserCommands
    {
        public static int GetUserID(string username)
        {
            int id = -1;

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT UserID FROM [User] WHERE Username = @Username";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@Username", username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                id = (int)reader["UserID"];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return id;
        }

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="newUser">The new user.</param>
        /// <returns>System.Int32.</returns>
        public static int AddUser(User newUser)
        {
            int id;

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "INSERT [User] (UserType, Username, Password)"
                + " values(@UserType, @Username, @Password);"
                + " SELECT CAST(scope_identity() AS int)";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@UserType", newUser.UserType);
            command.Parameters.AddWithValue("@Username", newUser.Username);
            command.Parameters.AddWithValue("@Password", newUser.Password);

            try
            {
                connection.Open();
                id = (int)command.ExecuteScalar();
            }
            catch (Exception e)
            {
                id = -1;
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return id;
        }

        public static void UpdateUser(User user)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "UPDATE [User] SET Username = @Username, Password = @Password, UserType = @UserType" +
                " WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@UserType", user.UserType);
            command.Parameters.AddWithValue("@Username", user.Username);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@UserID", user.UserID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Checks the username exists.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns><c>true</c> if username exists, <c>false</c> otherwise.</returns>
        public static bool CheckUsernameExists(string username)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT Username FROM [User] WHERE Username = @Username";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@Username", username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Checks inputted username and password to see if the password entered matches the username entered.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="userType">Type of the user.</param>
        /// <returns><c>true</c> if username and password match, <c>false</c> otherwise.</returns>
        public static bool CheckPasswordCorrect(string username, string password, string userType)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM [User] WHERE Username = @Username AND UserType = @UserType";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@UserType", userType);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["Username"].ToString();
                    string pw = reader["Password"].ToString();

                    if (username == reader["Username"].ToString() &&
                        Hashing.ValidatePassword(password, reader["Password"].ToString()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static User GetUserByUserName(string username)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM [User] WHERE Username = @Username";
            SqlCommand command = new SqlCommand(statement, connection);

            User user = new User();

            command.Parameters.AddWithValue("@Username", username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    user.UserID = (int)reader["UserID"];
                    user.UserType = reader["UserType"].ToString();
                    user.Username = reader["Username"].ToString();
                    user.Password = reader["Password"].ToString();
                }

                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }

            return user;
        }

        public static List<User> GetGuestUsers(string userType)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM [User] WHERE UserType = @UserType";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@UserType", userType);

            List<User> guestUserList = new List<User>();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    User guestUser = new User();
                    guestUser.UserID = (int)reader["UserID"];
                    guestUser.Username = reader["Username"].ToString();
                    guestUser.Password = reader["Password"].ToString();
                    guestUser.UserType = reader["UserType"].ToString();

                    guestUserList.Add(guestUser);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Close();
            }

            return guestUserList;
        }

        public static void DeleteUser(User user)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "DELETE FROM [User] WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@UserID", user.UserID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void UpdateAdminPassword(User user)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "UPDATE [User] SET Password = @Password" +
                               " WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@UserID", user.UserID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}