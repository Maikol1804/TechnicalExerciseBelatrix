using Logger.Interfaces;
using static Logger.Transverse.Enumerators.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factory
{
    public class LoggerFactory : ILoggerFactory
    {
        private readonly Dictionary<LoggerTypes, ILogger> _loggersFactory;

        public LoggerFactory() {

            _loggersFactory = new Dictionary<LoggerTypes, ILogger>();

            _loggersFactory.Add(LoggerTypes.Console, new LoggerConsole());
            _loggersFactory.Add(LoggerTypes.File, new LoggerFile());
            _loggersFactory.Add(LoggerTypes.Database, new LoggerDatabase());
        }

        public ILogger CreateLogger(LoggerTypes type)
        {
            return _loggersFactory[type];
        }

        public static LoggerFactory InitializeFactory() {
            return new LoggerFactory();
        }
    }
}
