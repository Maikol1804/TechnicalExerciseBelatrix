using static Logger.Transverse.Enumerators.Enums;
using Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Util;
using Logger.Exceptions;

namespace Logger
{
    public class LoggerConsole : ILogger
    {
        private readonly Dictionary<MessageTypes, ConsoleColor> _consoleColors = new Dictionary<MessageTypes, ConsoleColor>
        {
            { MessageTypes.Information, ConsoleColor.White },
            { MessageTypes.Warning, ConsoleColor.Yellow },
            { MessageTypes.Error, ConsoleColor.Red }
        };

        public void AddMessage(MessageTypes type, string message)
        {
            Validations(message);

            Console.ForegroundColor = _consoleColors[type];
            Console.WriteLine(Formats.LoggerConsoleMessage(message));
        }

        private void Validations(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new LoggerConsoleException("The message cannot be empty.");
            }
        }

    }
}
