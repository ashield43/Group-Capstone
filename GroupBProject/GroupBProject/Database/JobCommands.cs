using GroupBProject.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupBProject
{
    /// <summary>
    /// Class JobCommands.
    /// </summary>
    public class JobCommands
    {
        /// <summary>
        /// Pulls all jobs from the database, loads each job into a Job object. Stores each object in a List then returns the List
        /// </summary>
        /// <returns>A list of Jobs.</returns>
        public static List<Job> GetJobs()
        {
            List<Job> jobs = new List<Job>();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Job";
            SqlCommand command = new SqlCommand(statement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Job job = new Job();
                    job.JobID = (int)reader["JobID"];
                    job.Name = reader["Name"].ToString();
                    if (reader["Description"] != null)
                    {
                        job.Description = reader["Description"].ToString();
                    }
                    if (reader["InspectorID"] != null)
                    {
                        job.InspectorID = (int)reader["InspectorID"];
                    }
                    job.Date = (DateTime)reader["Date"];
                    if ((int)reader["IsComplete"] == 1)
                    {
                        job.IsComplete = true;
                    }
                    else
                    {
                        job.IsComplete = false;
                    }
                    job.StartTime = (int)reader["StartTime"];
                    job.EndTime = (int)reader["EndTime"];
                    job.RequiredQualification = QualificationCommands.GetQualificationByID((int)reader["RequiredQualificationID"]);
                    job.ProjectID = (int)reader["ProjectID"];

                    jobs.Add(job);
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

            return jobs;
        }

        /// <summary>
        /// Gets the job by the job id.
        /// </summary>
        /// <param name="jobID">The job identifier.</param>
        /// <returns>A job object.</returns>
        public static Job GetJobByID(int jobID)
        {
            Job selectedJob = new Job();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Job WHERE JobID = @JobID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@JobID", jobID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    selectedJob.JobID = jobID;
                    selectedJob.Name = reader["Name"].ToString();
                    selectedJob.Description = reader["Description"].ToString();
                    selectedJob.Date = (DateTime)reader["Date"];
                    selectedJob.StartTime = (int)reader["StartTime"];
                    selectedJob.EndTime = (int)reader["EndTime"];
                    selectedJob.IsComplete = (Boolean)reader["IsComplete"];
                    if (!(reader["InspectorID"] is DBNull))
                    {
                        selectedJob.InspectorID = (int)reader["InspectorID"];
                    }
                    selectedJob.RequiredQualification = QualificationCommands.GetQualificationByID((int)reader["RequiredQualificationID"]);
                    selectedJob.ProjectID = (int)reader["ProjectID"];
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

            return selectedJob;
        }

        /// <summary>
        /// Return of list of jobs assigned to a given inspector
        /// </summary>
        /// <param name="inspectorID">The inspector identifier.</param>
        /// <returns>A list of jobs.</returns>
        public static List<Job> GetJobsByInspectorID(int inspectorID)
        {
            List<Job> assignedJobs = new List<Job>();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Job WHERE InspectoriD = @InspectorID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@InspectorID", inspectorID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Job assignedJob = new Job();

                    assignedJob.JobID = (int)reader["JobID"];
                    assignedJob.Name = reader["Name"].ToString();
                    assignedJob.Description = reader["Description"].ToString();
                    assignedJob.Date = (DateTime)reader["Date"];
                    assignedJob.StartTime = (int)reader["StartTime"];
                    assignedJob.EndTime = (int)reader["EndTime"];
                    assignedJob.IsComplete = (Boolean)reader["IsComplete"];
                    assignedJob.InspectorID = inspectorID;
                    assignedJob.RequiredQualification = QualificationCommands.GetQualificationByID((int)reader["RequiredQualificationID"]);
                    assignedJob.ProjectID = (int)reader["ProjectID"];

                    assignedJobs.Add(assignedJob);
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

            return assignedJobs;
        }

        /// <summary>
        /// Gets the jobs by project identifier.
        /// </summary>
        /// <param name="projectID">The project identifier.</param>
        /// <returns>Returns a list of jobs assigned to a given project</returns>
        public static List<Job> GetJobsByProjectID(int projectID)
        {
            List<Job> assignedJobs = new List<Job>();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM Job WHERE ProjectID = @ProjectID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@ProjectID", projectID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Job assignedJob = new Job();

                    assignedJob.JobID = (int)reader["JobID"];
                    assignedJob.Name = reader["Name"].ToString();
                    assignedJob.Description = reader["Description"].ToString();
                    assignedJob.Date = (DateTime)reader["Date"];
                    assignedJob.StartTime = (int)reader["StartTime"];
                    assignedJob.EndTime = (int)reader["EndTime"];
                    assignedJob.IsComplete = (Boolean)reader["IsComplete"];
                    if (!(reader["InspectorID"] is DBNull))
                    {
                        assignedJob.InspectorID = (int)reader["InspectorID"];
                    }
                    assignedJob.RequiredQualification = QualificationCommands.GetQualificationByID((int)reader["RequiredQualificationID"]);
                    assignedJob.ProjectID = (int)reader["ProjectID"];

                    assignedJobs.Add(assignedJob);
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

            return assignedJobs;
        }

        /// <summary>
        /// Adds the job to the database.
        /// </summary>
        /// <param name="newJob">The new job.</param>
        /// <returns>System.Int32.</returns>
        public static int AddJob(Job newJob)
        {
            int id = 0;

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "INSERT Job (Name, Description, InspectorID, Date, IsComplete, StartTime, EndTime, RequiredQualificationID, ProjectID)"
                + " values(@Name, @Description, @inspector, @Date, @IsComplete, @StartTime, @EndTime, @RequiredQualificationID, @ProjectID); SELECT CAST(scope_identity() AS int)";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@Name", newJob.Name);
            command.Parameters.AddWithValue("@Description", newJob.Description);
            command.Parameters.AddWithValue("@Date", newJob.Date);
            command.Parameters.AddWithValue("@IsComplete", newJob.IsComplete);
            command.Parameters.AddWithValue("@StartTime", newJob.StartTime);
            command.Parameters.AddWithValue("@EndTime", newJob.EndTime);
            command.Parameters.AddWithValue("@RequiredQualificationID", newJob.RequiredQualification.ID);
            command.Parameters.AddWithValue("@inspector", newJob.InspectorID);
            command.Parameters.AddWithValue("@ProjectID", newJob.ProjectID);

            try
            {
                connection.Open();
                id = (int)command.ExecuteScalar();
            }
            catch (Exception e)
            {
                if (id == -1)
                {
                    MessageBox.Show(e.Message);
                }
            }
            finally
            {
                connection.Close();
            }

            return id;
        }

        /// <summary>
        /// Edits the job.
        /// </summary>
        /// <param name="newJob">The job to edit.</param>
        public static void EditJob(Job newJob)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "UPDATE Job SET Name = @Name, Description = @Description, Date = @Date, IsComplete = @IsComplete, StartTime = @StartTime, EndTime = @EndTime, RequiredQualificationID = @RQualification WHERE JobID = @JobID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@JobID", newJob.JobID);
            command.Parameters.AddWithValue("@Name", newJob.Name);
            command.Parameters.AddWithValue("@Description", newJob.Description);
            command.Parameters.AddWithValue("@Date", newJob.Date);
            command.Parameters.AddWithValue("@IsComplete", newJob.IsComplete);
            command.Parameters.AddWithValue("@StartTime", newJob.StartTime);
            command.Parameters.AddWithValue("@EndTime", newJob.EndTime);
            command.Parameters.AddWithValue("@RQualification", newJob.RequiredQualification.ID);

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
        /// Deletes the job.
        /// </summary>
        /// <param name="deletedJob">The job to delete.</param>
        public static void DeleteJob(Job deletedJob)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "DELETE FROM Job WHERE JobID = @JobID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@JobID", deletedJob.JobID);

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
        /// Unassigns the inspector from the job.
        /// </summary>
        /// <param name="job">The job from which the inspector will be removed.</param>
        public static void UnassignInspectorToJob(Job job)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "UPDATE Job SET InspectorID = @Null WHERE JobID = @JobID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@Null", DBNull.Value);
            command.Parameters.AddWithValue("@JobID", job.JobID);

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

        public static void AssignInspectorToJob(Job job)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "UPDATE Job SET InspectorID = @id WHERE JobID = @JobID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@id", job.InspectorID);
            command.Parameters.AddWithValue("@JobID", job.JobID);

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
        /// Get Job ID based on several fields in the class
        /// </summary>
        /// <param name="job">The job.</param>
        /// <returns>Returns -1 if there is an error</returns>
        public static int GetJobID(Job job)
        {
            int jobID;

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT JobID FROM Job WHERE Name = @Name AND Description = @Description";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@Name", job.Name);
            command.Parameters.AddWithValue("@Description", job.Description);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                jobID = (int)reader["JobID"];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                jobID = -1;
            }
            finally
            {
                connection.Close();
            }

            return jobID;
        }

        /// <summary>
        /// Deletes all jobs based on ProjectID
        /// </summary>
        /// <param name="projectID">The project identifier.</param>
        public static void DeleteJobsByProjectID(int projectID)
        {
            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "DELETE FROM Job WHERE ProjectID = @ProjectID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@ProjectID", projectID);

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