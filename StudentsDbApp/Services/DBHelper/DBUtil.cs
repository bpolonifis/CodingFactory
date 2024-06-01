using System.Data.SqlClient;

namespace StudentsDbApp.Services.DBHelper
{
    public static class DBUtil // static kalytera apo private sthn C#
    {
        //private DBUtil() { } // java proseggisi 

        public static SqlConnection? GetSqlConnection()
        {
            var configurationBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var configuration = configurationBuilder.Build();
            string? connString = configuration.GetConnectionString("DefaultConnection");

            try
            {
                SqlConnection conn = new(connString);
                return conn;

            } catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return null;
            }
        }






    }


}
