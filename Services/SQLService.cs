using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Proov.Services
{
    internal class SqlService
    {
        private static string _connectionString;
        public SqlService()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Proov.Properties.Settings.proovConnectionString"].ConnectionString;
        }
        public void RunNonQuery(SqlCommand command)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    command.Connection = connection;
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public object RunScalar(SqlCommand command)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    command.Connection = connection;
                    command.Connection.Open();
                    return command.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
