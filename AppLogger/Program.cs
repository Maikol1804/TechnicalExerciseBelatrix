using Logger.Exceptions;
using Logger.Factory;
using Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logger.Transverse.Enumerators.Enums;

namespace AppLogger
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                ILogger consoleLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Console);
                consoleLogger.AddMessage(MessageTypes.Information, "Message Information");
                consoleLogger.AddMessage(MessageTypes.Warning, "Message Warning");
                consoleLogger.AddMessage(MessageTypes.Error, "Message Error");
            }
            catch (LoggerConsoleException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                ILogger fileLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);
                fileLogger.AddMessage(MessageTypes.Information, "Message Information");
                fileLogger.AddMessage(MessageTypes.Warning, "Message Warning");
                fileLogger.AddMessage(MessageTypes.Error, "Message Error");
            }
            catch (LoggerFileException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try 
            {
                ILogger databaseLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Database);
                databaseLogger.AddMessage(MessageTypes.Information, "Message Information");
                databaseLogger.AddMessage(MessageTypes.Warning, "Message Warning");
                databaseLogger.AddMessage(MessageTypes.Error, "Message Error");
            }
            catch (LoggerDatabaseException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
