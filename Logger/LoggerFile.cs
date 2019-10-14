using Logger.Exceptions;
using Logger.Interfaces;
using Logger.Transverse.Enumerators;
using Logger.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class LoggerFile : ILogger
    {
        public void AddMessage(Enums.MessageTypes type, string message)
        {
            Validations(message);

            string logs = string.Empty;

            string path = ConfigurationManager.AppSettings["LogFileDirectory"];
            var fileName = "LogFile" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
            path = Path.Combine(path, fileName); 

            if (File.Exists(path))
            {
                try
                {
                    logs = File.ReadAllText(path);
                }
                catch(Exception ex) 
                {
                    throw new LoggerFileException("There was an error reading the information in the log file:" + ex.Message);
                }
            }

            logs += Formats.LoggerFileMessage(type, message) + "\n";

            try 
            {
                File.WriteAllText(path, logs);
            }
            catch (Exception ex) 
            {
                throw new LoggerFileException("There was an error writing to the log file: " + ex.Message);
            }
            
        }

        public static void Validations(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new LoggerFileException("The message cannot be empty.");
            }
        }
    }
}
