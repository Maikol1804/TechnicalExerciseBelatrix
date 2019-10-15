using Logger.Exceptions;
using Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logger.Transverse.Enumerators.Enums;

namespace Logger
{
    public class LoggerDatabase : ILogger
    {
        public void AddMessage(MessageTypes type, string message)
        {
            
            Validations(message);
            message.Trim();

            string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            
            InsertLogInDatabase(connectionString, type, message);

        }

        private void Validations(string message) 
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new LoggerDatabaseException("The message cannot be empty.");
            }
        }

        public void InsertLogInDatabase(string connectionString, MessageTypes type, string message) {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string queryString = "INSERT INTO Log VALUES (@dateTimeNow, '" + type.GetDescription() + "', '" + message + "')";
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

    }
}
