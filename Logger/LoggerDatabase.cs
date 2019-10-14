using Logger.Exceptions;
using Logger.Interfaces;
using Logger.Transverse.Enumerators;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class LoggerDatabase : ILogger
    {
        public void AddMessage(Enums.MessageTypes type, string message)
        {
            
            Validations(message);

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            string queryString = "INSERT INTO Log VALUES (@dateTimeNow, '" + type.GetDescription() + "', '" + message + "')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@dateTimeNow", DateTime.Now);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new LoggerDatabaseException("Error inserting the record in the database: " + ex.Message);
                }
                finally 
                {
                    connection.Close();
                }
            }
        }

        public static void Validations(string message) 
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new LoggerDatabaseException("The message cannot be empty.");
            }
        }

    }
}
