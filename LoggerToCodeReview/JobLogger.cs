using System;
using System.Linq;
using System.Text;

namespace LoggerToCodeReview
{
    public class JobLogger
    {
        // There are many boolean variables, they can be grouped into two enumerators, one for the type of logger and one for the type of message.
        private static bool _logToFile;
        private static bool _logToConsole;
        private static bool _logMessage;
        private static bool _logWarning;
        private static bool _logError;
        // The LogToDatabase variable does not follow the standard of the other variables. The variable should start with the character _ and the second character should be written in lower case.
        private static bool LogToDatabase;
        // The variable '_initialized' was declared but never was used.
        private bool _initialized;
        // With the different combinations of the boolean variables of the constructor, 3 types of logger can be created, it is better to have an object for each type of logger and implement a design pattern like Factory Method to create some of the logger types.
        public JobLogger(bool logToFile, bool logToConsole, bool logToDatabase, bool logMessage, bool logWarning, bool logError)
        {
            _logError = logError;
            _logMessage = logMessage;
            _logWarning = logWarning;
            LogToDatabase = logToDatabase;
            _logToFile = logToFile;
            _logToConsole = logToConsole;
        }
        // The method has too many responsibilities, it is better to divide the responsibilities into different methods of different classes.
        // There are two parameters that are called the same, It could leave the name of the parameter string as 'message' and the name of the parameter bool as 'information'.
        public static void LogMessage(string message_, bool message, bool warning, bool error)
        {
            // Trim() method should be called after validating that the message is not null.
            message_.Trim();
            if (message_ == null || message_.Length == 0)
            {
                // If the code arrives here, it will not be known why it failed. It would be better to throw an exception with the problem encountered.
                return;
            }
            // Do this validation in a specific class for each logger. This will make the code more understandable.
            if (!_logToConsole && !_logToFile && !LogToDatabase)
            {
                // It would be better to send a custom exception, to have more context about where the error occurred and be able to handle it easier.
                throw new Exception("Invalid configuration");
            }
            // Do this validation in a specific class for each logger. This will make the code more understandable.
            if ((!_logError && !_logMessage && !_logWarning) || (!message && !warning && !error))
            {
                // It would be better to send a custom exception, to have more context about where the error occurred and be able to handle it easier.
                throw new Exception("Error or Warning or Message must be specified");
            }

            // Create an independent method that is only responsible for making the connection to the database.
            // If there is a problem with the connection, the error is not being handled in any way and the code will fail.
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            // The connection opened but never closed.
            connection.Open();
            // The variable 't' is not clear, what does it mean?, it would be better to call the variable 'MessageType'
            // To keep 't' information, it would be better to create an enumerator
            int t = 0;
            if (message && _logMessage)
            {
                t = 1;
            }
            if (error && _logError)
            {
                t = 2;
            }
            if (warning && _logWarning)
            {
                t = 3;
            }
            // Create a 'queryString' variable to save the query to be executed with the SqlCommand.
            // Add the full date in that the event occurred to the log table.
            // Save the type of message with a word (Information, Warning, Error) and not with a number.
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("Insert into Log Values('" + message_ + "', " + t.ToString() + ")");
            command.ExecuteNonQuery();

            // The variable 'l' is not clear, what does it refer to?, it would be better to call the variable 'logs'.
            // The variable 'l' should be initialized with 'string.Empty' to make the code clearer.
            string l = "";
            // Declare the libraries in the header to make the call to the 'File' and 'ConfigurationManager' classes shorter.
            // Change the 'DateTime.Now.ToShortDateString()' variable to 'DateTime.Now.ToString("yyyyMMdd")', this to avoid errors with special characters such as '/' in the file name.
            // Create a 'fileName' variable to save the name of the file that will be read.
            // Create a 'path' variable to save the full path of the file that will be read.
            if (System.IO.File.Exists(System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"] + "LogFile" + DateTime.Now.ToShortDateString() + ".txt"))
            {
                // Create a separate method that is responsible for reading a file given a path.
                // Handle an exception in case the file cannot be read.
                l = System.IO.File.ReadAllText(System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"] + "LogFile" + DateTime.Now.ToShortDateString() + ".txt");
            }
            // All if statements do the same, what should be done is to remove all ifs and add the type of message to the log that is being added.
            if (error && _logError)
            {
                // Use the operation += make the code more understandable.
                // Change the 'DateTime.Now.ToShortDateString()' variable to 'DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")', this to add the time to the log. 'I have not seen the first log that does not have the time'.
                // Add a line break (\n) at the end to make reading the log file clearer.
                // The format in which the log is printed can be improved, square brackets [] can be used to separate the information from the message.
                l = l + DateTime.Now.ToShortDateString() + message_;
            }
            if (warning && _logWarning)
            {
                // Use the operation += make the code more understandable.
                // Change the 'DateTime.Now.ToShortDateString()' variable to 'DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")', this to add the time to the log. 'I have not seen the first log that does not have the time'.
                // Add a line break (\n) at the end to make reading the log file clearer.
                // The format in which the log is printed can be improved, square brackets [] can be used to separate the information from the message.
                l = l + DateTime.Now.ToShortDateString() + message_;
            }
            if (message && _logMessage)
            {
                // Use the operation += make the code more understandable.
                // Change the 'DateTime.Now.ToShortDateString()' variable to 'DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")', this to add the time to the log. 'I have not seen the first log that does not have the time'.
                // Add a line break (\n) at the end to make reading the log file clearer.
                // The format in which the log is printed can be improved, square brackets [] can be used to separate the information from the message.
                l = l + DateTime.Now.ToShortDateString() + message_;
            }
            // Create a separate method that is responsible for writing a file given a path and a message.
            // Handle an exception in case the file cannot be write.
            System.IO.File.WriteAllText(System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"] + "LogFile" + DateTime.Now.ToShortDateString() + ".txt", l);
            // Create an enumerator to keep the types of console colors available.
            if (error && _logError)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (warning && _logWarning)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            if (message && _logMessage)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Change the 'DateTime.Now.ToShortDateString()' variable to 'DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")', this to add the time to the log. 'I have not seen the first log that does not have the time'.
            // The format in which the log is printed can be improved, square brackets [] can be used to separate the information from the message.
            Console.WriteLine(DateTime.Now.ToShortDateString() + message_);
        }

    }

}
