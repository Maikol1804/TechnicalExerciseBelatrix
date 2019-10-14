using Logger.Exceptions;
using Logger.Factory;
using Logger.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logger.Transverse.Enumerators.Enums;

namespace Logger.UnitTests
{
    [TestClass]
    public class LoggerFileTests
    {
        [TestMethod]
        [ExpectedException(typeof(LoggerFileException))]
        public void AddMessage_WithInformationMessageTypeAndEmptyMessage_ShouldThrownLoggerFileException()
        {
            // Arrange
            ILogger fileLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);

            // Act
            fileLogger.AddMessage(MessageTypes.Information, "");

            // Assert
            // Expected LoggerFileException 
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerFileException))]
        public void AddMessage_WithInformationMessageTypeAndNullMessage_ShouldThrownLoggerFileException()
        {
            // Arrange
            ILogger fileLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);

            // Act
            fileLogger.AddMessage(MessageTypes.Information, null);

            // Assert
            // Expected LoggerFileException 
        }

        [TestMethod]
        public void AddMessage_WithInformationMessageTypeAndSomeMessage_ShouldAddLog()
        {
            // Arrange
            ILogger fileLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);

            // Act
            fileLogger.AddMessage(MessageTypes.Information, "Information Message");

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerFileException))]
        public void AddMessage_WithWarningMessageTypeAndEmptyMessage_ShouldThrownLoggerFileException()
        {
            // Arrange
            ILogger fileLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);

            // Act
            fileLogger.AddMessage(MessageTypes.Warning, "");

            // Assert
            // Expected LoggerFileException 
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerFileException))]
        public void AddMessage_WithWarningMessageTypeAndNullMessage_ShouldThrownLoggerFileException()
        {
            // Arrange
            ILogger fileLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);

            // Act
            fileLogger.AddMessage(MessageTypes.Warning, null);

            // Assert
            // Expected LoggerFileException 
        }

        [TestMethod]
        public void AddMessage_WithWarningMessageTypeAndSomeMessage_ShouldAddLog()
        {
            // Arrange
            ILogger fileLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);

            // Act
            fileLogger.AddMessage(MessageTypes.Warning, "Warning Message");

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerFileException))]
        public void AddMessage_WithErrorMessageTypeAndEmptyMessage_ShouldThrownLoggerFileException()
        {
            // Arrange
            ILogger fileLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);

            // Act
            fileLogger.AddMessage(MessageTypes.Error, "");

            // Assert
            // Expected LoggerFileException 
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerFileException))]
        public void AddMessage_WithErrorMessageTypeAndNullMessage_ShouldThrownLoggerFileException()
        {
            // Arrange
            ILogger fileLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);

            // Act
            fileLogger.AddMessage(MessageTypes.Error, null);

            // Assert
            // Expected LoggerFileException
        }

        [TestMethod]
        public void AddMessage_WithErrorMessageTypeAndSomeMessage_ShouldAddLog()
        {
            // Arrange
            ILogger fileLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);

            // Act
            fileLogger.AddMessage(MessageTypes.Error, "Error Message");

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerFileException))]
        public void ReadLogs_WithEmptyPath_ShouldThrownLoggerFileException()
        {
            // Arrange
            LoggerFile fileLogger = (LoggerFile)LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);

            // Act
            fileLogger.ReadLogs("");

            // Assert
            // Expected LoggerFileException
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerFileException))]
        public void ReadLogs_WithNullPath_ShouldThrownLoggerFileException()
        {
            // Arrange
            LoggerFile fileLogger = (LoggerFile)LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);

            // Act
            fileLogger.ReadLogs(null);

            // Assert
            // Expected LoggerFileException
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerFileException))]
        public void WriteLogs_WithEmptyPathAndSomeLog_ShouldThrownLoggerFileException()
        {
            // Arrange
            LoggerFile fileLogger = (LoggerFile)LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);

            // Act
            fileLogger.WriteLogs("","Content Log");

            // Assert
            // Expected LoggerFileException
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerFileException))]
        public void WriteLogs_WithNullPathAndSomeLog_ShouldThrownLoggerFileException()
        {
            // Arrange
            LoggerFile fileLogger = (LoggerFile)LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.File);

            // Act
            fileLogger.WriteLogs(null, "Content Log");

            // Assert
            // Expected LoggerFileException
        }

    }
}
