using GroupBProject.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupBProject.Database
{
    /// <summary>
    /// Class QualificationCommands.
    /// </summary>
    public class QualificationCommands
    {
        /// <summary>
        /// Gets all qualifications.
        /// </summary>
        /// <returns>A list of all qualifications.</returns>
        public static List<Qualification> GetAllQualifications()
        {
            List<Qualification> qualificaitons = new List<Qualification>();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Qualification";
            SqlCommand command = new SqlCommand(statement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Qualification qualification = new Qualification();

                    qualification.ID = (int)reader["QualificationID"];
                    qualification.Name = reader["Name"].ToString();
                    qualification.IsJobQualification = (Boolean)reader["IsJobQualification"];

                    qualificaitons.Add(qualification);
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

            return qualificaitons;
        }

        /// <summary>
        /// Gets the qualifications by assiciated inspector.
        /// </summary>
        /// <param name="inspectorID">The inspector identifier.</param>
        /// <returns>A list of all qualifications associated with a given inspector.</returns>
        public static List<Qualification> GetQualificationsByAssiciatedInspector(int inspectorID)
        {
            List<Qualification> qualificaitons = new List<Qualification>();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Qualification AS q JOIN InspectorXQualificationAssignment AS a on q.QualificationID = a.QualificationID WHERE a.InspectorID = @InspectorID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@InspectorID", inspectorID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Qualification qualification = new Qualification();
                    qualification.ID = (int)reader["QualificationID"];
                    qualification.Name = reader["Name"].ToString();
                    qualification.IsJobQualification = (Boolean)reader["IsJobQualification"];

                    qualificaitons.Add(qualification);
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

            return qualificaitons;
        }

        /// <summary>
        /// Gets the job qualifications.
        /// </summary>
        /// <returns>A list of job qualifications.</returns>
        public static List<Qualification> GetJobQualifications()
        {
            List<Qualification> qualificaitons = new List<Qualification>();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Qualification WHERE IsJobQualification = 1";
            SqlCommand command = new SqlCommand(statement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Qualification qualification = new Qualification();
                    qualification.ID = (int)reader["QualificationID"];
                    qualification.Name = reader["Name"].ToString();
                    qualification.IsJobQualification = (Boolean)reader["IsJobQualification"];

                    qualificaitons.Add(qualification);
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

            return qualificaitons;
        }

        /// <summary>
        /// Gets the qualification by identifier.
        /// </summary>
        /// <param name="qualificationID">The qualification identifier.</param>
        /// <returns>Qualification.</returns>
        public static Qualification GetQualificationByID(int qualificationID)
        {
            Qualification qualification = new Qualification();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Qualification WHERE QualificationID = @QualificationID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@QualificationID", qualificationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                qualification.ID = (int)reader["QualificationID"];
                qualification.Name = reader["Name"].ToString();
                qualification.IsJobQualification = (Boolean)reader["IsJobQualification"];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return qualification;
        }

        /// <summary>
        /// Get a specific qualification by the given name.
        /// </summary>
        /// <param name="name">The qualification name.</param>
        /// <returns>Qualification.</returns>
        public static Qualification GetQualificationByName(string name)
        {
            Qualification qualification = new Qualification();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Qualification WHERE Name = @Name";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@Name", name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                qualification.ID = (int)reader["QualificationID"];
                qualification.Name = reader["Name"].ToString();
                qualification.IsJobQualification = (Boolean)reader["IsJobQualification"];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return qualification;
        }

        /// <summary>
        /// Add a qualificaiton/inspector assignment
        /// </summary>
        /// <param name="qualificationID">The qualification identifier.</param>
        /// <param name="inspectorID">The inspector identifier.</param>
        public static void AddQualificationAssignment(int qualificationID, int inspectorID)
        {
            SqlConnection connection = ConnectionString.GetConnection();

            string statement = "INSERT InspectorXQualificationAssignment (InspectorID, QualificationID) values(@InspectorID, @QualificationID)";

            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@InspectorID", inspectorID);
            command.Parameters.AddWithValue("@QualificationID", qualificationID);

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
        /// Removes the inspector qualifications.
        /// </summary>
        /// <param name="inspectorID">The inspector identifier.</param>
        public static void RemoveInspectorQualifications(int inspectorID)
        {
            SqlConnection connection = ConnectionString.GetConnection();

            string statement = "DELETE from InspectorXQualificationAssignment WHERE InspectorID = @inspectorID";

            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@inspectorID", inspectorID);

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