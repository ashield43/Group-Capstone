using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupBProject.Database
{
    /// <summary>
    /// Class DailyAvailabilityCommands.
    /// </summary>
    internal class DailyAvailabilityCommands
    {
        /// <summary>
        /// This method returns a list of DailyAvailability objects for the given inspector's ID
        /// </summary>
        /// <param name="inspectorID"></param>
        /// <returns></returns>
        public static List<DailyAvailability> GetDailyAvailabiltyByInspectorID(int inspectorID)
        {
            List<DailyAvailability> weeklyAvailability = new List<DailyAvailability>();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM DailyAvailability WHERE InspectoriD = @InspectorID";
            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@InspectorID", inspectorID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DailyAvailability dailyAvailability = new DailyAvailability();

                    dailyAvailability.ID = (int)reader["DailyAvailabilityID"];
                    dailyAvailability.DayOfWeek = (string)reader["DayOfWeek"];
                    dailyAvailability.StartTime = (int)reader["StartTime"];
                    dailyAvailability.EndTime = (int)reader["EndTime"];
                    dailyAvailability.IsAvailable = (bool)reader["IsAvailable"];

                    weeklyAvailability.Add(dailyAvailability);
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

            return weeklyAvailability;
        }

        /// <summary>
        /// This method adds a DailyAvailability object to the database
        /// </summary>
        /// <param name="dailyAvailability"></param>
        /// <param name="inspectorID"></param>
        public static void AddDailyAvailability(DailyAvailability dailyAvailability, int inspectorID)
        {
            SqlConnection connection = ConnectionString.GetConnection();

            string statement = "INSERT DailyAvailability (DayOfWeek, StartTime, EndTime, InspectorID, IsAvailable) values(@DayOfWeek, @StartTime, @EndTime, @InspectorID, @IsAvailable)";

            SqlCommand command = new SqlCommand(statement, connection);

            command.Parameters.AddWithValue("@DayOfWeek", dailyAvailability.DayOfWeek);
            command.Parameters.AddWithValue("@StartTime", dailyAvailability.StartTime);
            command.Parameters.AddWithValue("@EndTime", dailyAvailability.EndTime);
            command.Parameters.AddWithValue("@InspectorID", inspectorID);
            command.Parameters.AddWithValue("@IsAvailable", dailyAvailability.IsAvailable);

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
        /// Removes the inspector availability.
        /// </summary>
        /// <param name="inspectorID">The inspector id.</param>
        public static void RemoveInspectorAvailability(int inspectorID)
        {
            SqlConnection connection = ConnectionString.GetConnection();

            string statement = "DELETE from DailyAvailability WHERE InspectorID = @inspectorID";

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