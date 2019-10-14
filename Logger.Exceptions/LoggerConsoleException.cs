using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Exceptions
{
    public class LoggerConsoleException : Exception
    {
        public LoggerConsoleException(string message)
            : base(string.Format("Logger Console Exception: {0}", message))
        {

        }       
    }
}
