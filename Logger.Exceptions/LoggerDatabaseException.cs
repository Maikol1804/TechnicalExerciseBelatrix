using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Exceptions
{
    public class LoggerDatabaseException : Exception
    {
        public LoggerDatabaseException(string message)
            : base(string.Format("Logger Database Exception: {0}", message))
        {

        }
    }
}
