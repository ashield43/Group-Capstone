using System.Data.SqlClient;

namespace GroupBProject
{
    internal class ConnectionString
    {
        public static SqlConnection GetConnection()
        {
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Seth\Documents\Source\Repos\groupB\GroupBProject\GroupBProject\Database1.mdf;Integrated Security=True";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sethj\Documents\Source\Repos\groupB\GroupBProject\GroupBProject\Database1.mdf;Integrated Security=True";
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sm479250\Documents\Source\Repos\groupB\GroupBProject\GroupBProject\Database1.mdf;Integrated Security=True";
            //string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\kelsi\Desktop\Repos\groupB\GroupBProject\GroupBProject\Database1.mdf; Integrated Security = True";
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\OneDrive\Desktop\GroupProjectRepo\groupB\GroupBProject\GroupBProject\Database1.mdf;Integrated Security=True";
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\OneDrive\Desktop\GroupProjectRepo\groupB\GroupBProject\GroupBProject\Database1.mdf;Integrated Security=True";
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\daj11\Desktop\groupb\GroupBProject\GroupBProject\Database1.mdf;Integrated Security=True";
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\OneDrive\Documents\Source\Repos\groupB\GroupBProject\GroupBProject\Database1.mdf;Integrated Security=True";
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\OneDrive\Desktop\GroupProjectRepo\groupB\GroupBProject\GroupBProject\Database1.mdf;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}