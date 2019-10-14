using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Exceptions
{
    public class LoggerFileException : Exception
    {
        public LoggerFileException(string message)
            : base(string.Format("Logger File Exception: {0}", message))
        {

        }
    }
}
