using GroupBProject.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GroupBProject.Database
{
    /// <summary>
    /// Class ReportCommands.
    /// </summary>
    internal class ReportCommands
    {
        /// <summary>
        /// Gets the reports.
        /// </summary>
        /// <returns>A list of reports.</returns>
        public static List<ReportType> GetReports()
        {
            List<ReportType> reports = new List<ReportType>();

            SqlConnection connection = ConnectionString.GetConnection();
            string statement = "SELECT * FROM ReportType";
            SqlCommand command = new SqlCommand(statement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReportType report = new ReportType();
                    report.ID = (int)reader["ReportID"];
                    report.Name = reader["Name"].ToString();
                    report.Description = reader["Description"].ToString();

                    reports.Add(report);
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

            return reports;
        }
    }
}