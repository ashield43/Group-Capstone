using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupBProject
{
    /// <summary>
    /// Class ProjectCommands.
    /// </summary>
    internal class ProjectCommands
    {
        /// <summary>
        /// Gets the projects.
        /// </summary>
        /// <returns>Return list of all projects.</returns>
        public static List<Project> GetProjects()
        {
            List<Project> projects = new List<Project>();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Project";
            SqlCommand command = new SqlCommand(statement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Project project = new Project();
                    project.ProjectID = (int)reader["ProjectID"];
                    if (!(reader["HeadInspectorID"] is DBNull))
                    {
                        project.HeadInspector = InspectorCommands.GetInspectorByID((int)reader["HeadInspectorID"]);
                    }
                    project.Address = reader["Address"].ToString();
                    if ((bool)reader["IsComplete"])
                    {
                        project.IsComplete = true;
                    }
                    else
                    {
                        project.IsComplete = false;
                    }
                    project.Title = reader["Title"].ToString();
                    project.Description = reader["Description"].ToString();

                    // get jobs
                    project.Jobs = JobCommands.GetJobsByProjectID(project.ProjectID);

                    projects.Add(project);
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

            return projects;
        }

        /// <summary>
        /// Gets the project by identifier.
        /// </summary>
        /// <param name="projectID">The project identifier.</param>
        /// <returns>Project.</returns>
        public static Project GetProjectByID(int projectID)
        {
            Project project = new Project();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Project WHERE ProjectID = @ProjectID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@ProjectID", projectID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                project.ProjectID = (int)reader["ProjectID"];
                if (reader["InspectorID"] != null)
                {
                    project.HeadInspector = InspectorCommands.GetInspectorByID((int)reader["InspectorID"]);
                }
                project.Address = reader["Address"].ToString();
                if ((int)reader["IsComplete"] == 1)
                {
                    project.IsComplete = true;
                }
                else
                {
                    project.IsComplete = false;
                }
                project.Title = reader["Title"].ToString();
                project.Description = reader["Description"].ToString();

                // get jobs
                project.Jobs = JobCommands.GetJobsByProjectID(project.ProjectID);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return project;
        }

        /// <summary>
        /// Add Project to database.
        /// </summary>
        /// <param name="newProject">The new project.</param>
        /// <returns>System.Int32.</returns>
        public static int AddProject(Project newProject)
        {
            int id;

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "INSERT Project (Address, IsComplete, Title, Description, HeadInspectorID)"
                + " values(@Address, @IsComplete, @Title, @Description, @HeadInspectorID); SELECT CAST(scope_identity() AS int)";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@Address", newProject.Address);
            command.Parameters.AddWithValue("@Title", newProject.Title);
            command.Parameters.AddWithValue("@Description", newProject.Description);

            command.Parameters.AddWithValue("@HeadInspectorID", newProject.HeadInspector.InspectorID);

            //Automatically marks job as incomplete
            command.Parameters.AddWithValue("@IsComplete", 0);

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

        /// <summary>
        /// Edits the project.
        /// </summary>
        /// <param name="project">The project.</param>
        public static void EditProject(Project project)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "UPDATE Project SET Address = @Address, IsComplete = @IsComplete, "
                + "Title = @Title, Description = @Description WHERE ProjectID = @ProjectID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@Address", project.Address);
            command.Parameters.AddWithValue("@IsComplete", project.IsComplete);
            command.Parameters.AddWithValue("@Title", project.Title);
            command.Parameters.AddWithValue("@Description", project.Description);
            command.Parameters.AddWithValue("@ProjectID", project.ProjectID);

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
        /// Deletes a project from the database.
        /// </summary>
        /// <param name="deletedProject">The project to delete.</param>
        public static void DeleteProject(Project deletedProject)
        {
            //Deletes all jobs with a matching projectID before deleting the project
            JobCommands.DeleteJobsByProjectID(deletedProject.ProjectID);

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "DELETE FROM Project WHERE ProjectID = @ProjectID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@ProjectID", deletedProject.ProjectID);

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
        /// Assigns the head inspector to a project.
        /// </summary>
        /// <param name="project">The project.</param>
        /// <param name="inspector">The inspector.</param>
        public static void AssignHeadInspector(Project project, Inspector inspector)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "UPDATE Project SET HeadInspectorID = @HeadInspectorID WHERE ProjectID = @ProjectID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@HeadInspectorID", inspector.InspectorID);
            command.Parameters.AddWithValue("@ProjectID", project.ProjectID);

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
        /// Removes the head inspector from a project.
        /// </summary>
        /// <param name="project">The project.</param>
        public static void RemoveHeadInspector(Project project)
        {
            SqlConnection connection = ConnectionString.GetConnection();

            string statement = "UPDATE Project Set HeadInspectorID = @Null WHERE ProjectID = @ProjectID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@Null", DBNull.Value);
            command.Parameters.AddWithValue("@ProjectID", project.ProjectID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Removal Failed");
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Get Project ID based on several fields in the class
        /// </summary>
        /// <param name="project">The project.</param>
        /// <returns>-1 if there is an error.</returns>
        public static int GetProjectID(Project project)
        {
            int projectID;

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT ProjectID FROM Project WHERE Title = @Title AND Address = @Address";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@Title", project.Title);
            command.Parameters.AddWithValue("@Address", project.Address);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                projectID = (int)reader["ProjectID"];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                projectID = -1;
            }
            finally
            {
                connection.Close();
            }

            return projectID;
        }
    }
}