using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logger.Transverse.Enumerators.Enums;

namespace Logger.Interfaces
{
    public interface ILogger
    {
        void AddMessage(MessageTypes type, string message);

    }
}
