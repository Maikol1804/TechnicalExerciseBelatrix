using static Logger.Transverse.Enumerators.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Util
{
    public static class Formats
    {
        public static string LoggerConsoleMessage(string message) {
            return "[" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "] [" + message + "]";
        }

        public static string LoggerFileMessage(MessageTypes type, string message)
        {
            return "[" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "] [" + type.GetDescription() + "] [" + message + "]";
        }

    }
}
