using GroupBProject.Business;
using GroupBProject.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GroupBProject
{
    internal class InspectorCommands
    {
        /// <summary>
        /// This method returns a list of all inspectors in the database
        /// </summary>
        /// <returns></returns>
        public static List<Inspector> GetAllInspectors()
        {
            List<Inspector> inspectors = new List<Inspector>();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Inspector";
            SqlCommand command = new SqlCommand(statement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //get inspector info
                    Inspector inspector = new Inspector();
                    inspector.InspectorID = (int)reader["InspectorID"];
                    inspector.FirstName = reader["FirstName"].ToString();
                    inspector.LastName = reader["LastName"].ToString();
                    inspector.Email = reader["Email"].ToString();
                    inspector.Phone = reader["Phone"].ToString();
                    inspector.IsActive = (Boolean)reader["IsActive"];

                    //get dailyAvailability info
                    inspector.WeeklyAvailability = DailyAvailabilityCommands.GetDailyAvailabiltyByInspectorID(inspector.InspectorID);

                    //get Assigned jobs info
                    inspector.AssignedJobs = JobCommands.GetJobsByInspectorID(inspector.InspectorID);

                    //Get qualifications
                    inspector.Qualifications = QualificationCommands.GetQualificationsByAssiciatedInspector(inspector.InspectorID);

                    //add inspector object to inspectors list
                    inspectors.Add(inspector);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return inspectors;
        }

        /// <summary>
        /// Returns a list of all active inspectors in the database
        /// </summary>
        /// <returns></returns>
        public static List<Inspector> GetActiveInspectors()
        {
            List<Inspector> inspectors = new List<Inspector>();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Inspector";
            SqlCommand command = new SqlCommand(statement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if ((Boolean)reader["IsActive"])
                    {
                        //get inspector info
                        Inspector inspector = new Inspector();
                        inspector.InspectorID = (int)reader["InspectorID"];
                        inspector.FirstName = reader["FirstName"].ToString();
                        inspector.LastName = reader["LastName"].ToString();
                        inspector.Email = reader["Email"].ToString();
                        inspector.Phone = reader["Phone"].ToString();
                        inspector.IsActive = (Boolean)reader["IsActive"];

                        //get dailyAvailability info
                        inspector.WeeklyAvailability = DailyAvailabilityCommands.GetDailyAvailabiltyByInspectorID(inspector.InspectorID);

                        //get Assigned jobs info
                        inspector.AssignedJobs = JobCommands.GetJobsByInspectorID(inspector.InspectorID);

                        //Get qualifications
                        inspector.Qualifications = QualificationCommands.GetQualificationsByAssiciatedInspector(inspector.InspectorID);

                        //add inspector object to inspectors list
                        inspectors.Add(inspector);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return inspectors;
        }

        /// <summary>
        /// Gets a list of the head inspectors.
        /// </summary>
        /// <returns>List of inspectors.</returns>
        public static List<Inspector> GetHeadInspectors()
        {
            List<Inspector> inspectors = new List<Inspector>();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Inspector";
            SqlCommand command = new SqlCommand(statement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //get inspector info
                    Inspector inspector = new Inspector();
                    inspector.InspectorID = (int)reader["InspectorID"];
                    inspector.FirstName = reader["FirstName"].ToString();
                    inspector.LastName = reader["LastName"].ToString();
                    inspector.Email = reader["Email"].ToString();
                    inspector.Phone = reader["Phone"].ToString();
                    inspector.IsActive = (Boolean)reader["IsActive"];

                    //get dailyAvailability info
                    inspector.WeeklyAvailability = DailyAvailabilityCommands.GetDailyAvailabiltyByInspectorID(inspector.InspectorID);

                    //get Assigned jobs info
                    inspector.AssignedJobs = JobCommands.GetJobsByInspectorID(inspector.InspectorID);

                    //Get qualifications
                    inspector.Qualifications = QualificationCommands.GetQualificationsByAssiciatedInspector(inspector.InspectorID);

                    if (inspector.Qualifications.Any(qualification => qualification.Name == "Head Inspector"))
                    {
                        //add inspector object to inspectors list
                        inspectors.Add(inspector);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return inspectors;
        }

        /// <summary>
        /// This method adds an inspector to the database, as well as that inspector's availability. This method also creates qualification assignments for the inspector
        /// </summary>
        /// <param name="inspector"></param>
        public static int AddInspector(Inspector inspector)
        {
            int id = 0;

            SqlConnection connection = ConnectionString.GetConnection();

            string statement = "INSERT Inspector (FirstName, LastName, Email, Phone, IsActive) values(@FirstName, @LastName, @Email, @Phone, @Active); SELECT CAST(scope_identity() AS int)";

            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@FirstName", inspector.FirstName);
            command.Parameters.AddWithValue("@LastName", inspector.LastName);
            command.Parameters.AddWithValue("@Email", inspector.Email);
            command.Parameters.AddWithValue("@Phone", inspector.Phone);
            command.Parameters.AddWithValue("@Active", inspector.IsActive);

            try
            {
                connection.Open();
                id = (int)command.ExecuteScalar();
            }
            catch (SqlException e)
            {
                id = -1;
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            //set inspector id
            inspector.InspectorID = id;

            //add dailyAvailability objects to database
            foreach (DailyAvailability dailyAvailability in inspector.WeeklyAvailability)
            {
                DailyAvailabilityCommands.AddDailyAvailability(dailyAvailability, inspector.InspectorID);
            }

            //add qualification assignments
            foreach (Qualification qualification in inspector.Qualifications)
            {
                QualificationCommands.AddQualificationAssignment(qualification.ID, inspector.InspectorID);
            }

            return id;
        }

        /// <summary>
        /// Updates an inspector
        /// </summary>
        /// <param name="inspector"></param>
        public static void EditInspector(Inspector inspector)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "UPDATE Inspector SET FirstName = @FirstName, LastName = @LastName, Email = @Email,"
                + "Phone = @Phone, IsActive = @Active WHERE InspectorID = @InspectorID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@FirstName", inspector.FirstName);
            command.Parameters.AddWithValue("@LastName", inspector.LastName);
            command.Parameters.AddWithValue("@Email", inspector.Email);
            command.Parameters.AddWithValue("@Phone", inspector.Phone);
            command.Parameters.AddWithValue("@Active", inspector.IsActive);
            command.Parameters.AddWithValue("@InspectorID", inspector.InspectorID);

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

            //remove previous availability
            DailyAvailabilityCommands.RemoveInspectorAvailability(inspector.InspectorID);

            //remove previous qualifications
            QualificationCommands.RemoveInspectorQualifications(inspector.InspectorID);

            //edit dailyAvailability objects
            foreach (DailyAvailability dailyAvailability in inspector.WeeklyAvailability)
            {
                DailyAvailabilityCommands.AddDailyAvailability(dailyAvailability, inspector.InspectorID);
            }

            //edit qualifications
            foreach (Qualification qualification in inspector.Qualifications)
            {
                QualificationCommands.AddQualificationAssignment(qualification.ID, inspector.InspectorID);
            }
        }

        /// <summary>
        /// Deactivate an inspector as long as they're not currently assigned to an incomplete job.
        /// </summary>
        /// <param name="inspector"></param>
        public static void DeactivateInspector(Inspector inspector)
        {
            SqlConnection connection = ConnectionString.GetConnection();

            // Deactivation statement stuff
            string deactivateStatement = "UPDATE Inspector Set IsActive = @IsActive WHERE InspectorID = @InspectorID";
            SqlCommand deactivateCommand = new SqlCommand(deactivateStatement, connection);

            deactivateCommand.Parameters.AddWithValue("@IsActive", inspector.IsActive);
            deactivateCommand.Parameters.AddWithValue("@InspectorID", inspector.InspectorID);

            if (DeactivateInspectorValidation(inspector))
            {
                // If the validation command finds no results the inspector is deactivated
                try
                {
                    connection.Open();
                    deactivateCommand.ExecuteNonQuery();
                }
                catch (Exception deactivationFailed)
                {
                    MessageBox.Show(deactivationFailed.Message, "Deactivation Failed");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Returns inpector based on given ID
        /// </summary>
        /// <param name="inspectorID"></param>
        /// <returns></returns>
        public static Inspector GetInspectorByID(int inspectorID)
        {
            Inspector inspector = new Inspector();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Inspector WHERE InspectorID = @InspectorID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@InspectorID", inspectorID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                //get inspector info
                inspector.InspectorID = (int)reader["InspectorID"];
                inspector.FirstName = reader["FirstName"].ToString();
                inspector.LastName = reader["LastName"].ToString();
                inspector.Email = reader["Email"].ToString();
                inspector.Phone = reader["Phone"].ToString();
                inspector.IsActive = (bool)reader["IsActive"];

                //get dailyAvailability info
                inspector.WeeklyAvailability = DailyAvailabilityCommands.GetDailyAvailabiltyByInspectorID(inspector.InspectorID);

                //get Assigned jobs info
                inspector.AssignedJobs = JobCommands.GetJobsByInspectorID(inspector.InspectorID);

                //Get qualifications
                inspector.Qualifications = QualificationCommands.GetQualificationsByAssiciatedInspector(inspector.InspectorID);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return inspector;
        }

        /// <summary>
        /// Get Inspector ID based on several fields in the class
        /// </summary>
        /// <param name="inspector"></param>
        /// <returns>Returns -1 if there is an error</returns>
        public static int GetInspectorID(Inspector inspector)
        {
            int inspectorID;

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT InspectorID FROM Inspector " +
                "WHERE FirstName = @FirstName AND LastName = @LastName AND Email = @Email AND Phone = @Phone";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@FirstName", inspector.FirstName);
            command.Parameters.AddWithValue("@LastName", inspector.LastName);
            command.Parameters.AddWithValue("@Email", inspector.Email);
            command.Parameters.AddWithValue("@Phone", inspector.Phone);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                inspectorID = (int)reader["InspectorID"];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                inspectorID = -1;
            }
            finally
            {
                connection.Close();
            }

            return inspectorID;
        }

        /// <summary>
        /// Tests if an inspector can be deactivated based on if they're working on an incomplete job
        /// </summary>
        /// <param name="inspector"></param>
        /// <returns><c>true</c> iif the inspector can be deactivated; otherwise, <c>false</c>.</returns>
        public static Boolean DeactivateInspectorValidation(Inspector inspector)
        {
            Boolean valid = true;
            SqlConnection connection = ConnectionString.GetConnection();

            // Validation statement stuff
            string validationStatement = "SELECT count(jobID) from Job WHERE InspectorID = @InspectorID AND IsComplete = @False";
            SqlCommand validationCommand = new SqlCommand(validationStatement, connection);

            validationCommand.Parameters.AddWithValue("@InspectorID", inspector.InspectorID);
            validationCommand.Parameters.AddWithValue("@False", false);

            try
            {
                connection.Open();
                // First runs the validation to determine if the inspector is assigned to an uncompleted job
                // If the command returns a number greater than 0, the inspector stays activated and an alert is shown
                SqlDataReader validationReader = validationCommand.ExecuteReader();
                if (!validationReader.Read())
                {
                    valid = false;
                    // Potentially make this message more helpful, maybe give a list of jobs.
                    MessageBox.Show("Inspector " + inspector.FirstName + " " + inspector.LastName + " " + "cannot be deactivated while assigned to a job.");
                }
                else
                {
                    valid = true;
                }
            }
            catch (Exception validationFailed)
            {
                MessageBox.Show(validationFailed.Message, "Validation Failed");
            }
            finally
            {
                connection.Close();
            }

            return valid;
        }
    }
}