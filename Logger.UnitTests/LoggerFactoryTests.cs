using Logger.Factory;
using Logger.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Logger.Transverse.Enumerators.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.UnitTests
{
    [TestClass]
    public class LoggerFactoryTests
    {
        [TestMethod]
        public void CreateLogger_WithConsoleLoggerType_ShouldReturnAnInstanceOfLoggerConsole()
        {
            // Arrange
            LoggerFactory loggerFactory = LoggerFactory.InitializeFactory();

            // Act
            ILogger consoleLogger = loggerFactory.CreateLogger(LoggerTypes.Console);

            // Assert
            Assert.IsInstanceOfType(consoleLogger, typeof(LoggerConsole));
        }

        [TestMethod]
        public void CreateLogger_WithFileLoggerType_ShouldReturnAnInstanceOfLoggerFile()
        {
            // Arrange
            LoggerFactory loggerFactory = LoggerFactory.InitializeFactory();

            // Act
            ILogger fileLogger = loggerFactory.CreateLogger(LoggerTypes.File);

            // Assert
            Assert.IsInstanceOfType(fileLogger, typeof(LoggerFile));
        }

        [TestMethod]
        public void CreateLogger_WithDatabaseLoggerType_ShouldReturnAnInstanceOfLoggerDatabase()
        {
            // Arrange
            LoggerFactory loggerFactory = LoggerFactory.InitializeFactory();

            // Act
            ILogger databaseLogger = loggerFactory.CreateLogger(LoggerTypes.Database);

            // Assert
            Assert.IsInstanceOfType(databaseLogger, typeof(LoggerDatabase));
        }

    }
}
