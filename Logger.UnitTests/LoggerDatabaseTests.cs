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
    public class LoggerDatabaseTests
    {
        [TestMethod]
        [ExpectedException(typeof(LoggerDatabaseException))]
        public void AddMessage_WithInformationMessageTypeAndEmptyMessage_ShouldThrownLoggerDatabaseException()
        {
            // Arrange
            ILogger databaseLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Database);

            // Act
            databaseLogger.AddMessage(MessageTypes.Information, "");

            // Assert
            // Expected LoggerDatabaseException 
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerDatabaseException))]
        public void AddMessage_WithInformationMessageTypeAndNullMessage_ShouldThrownLoggerDatabaseException()
        {
            // Arrange
            ILogger databaseLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Database);

            // Act
            databaseLogger.AddMessage(MessageTypes.Information, null);

            // Assert
            // Expected LoggerDatabaseException 
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerDatabaseException))]
        public void AddMessage_WithWarningMessageTypeAndEmptyMessage_ShouldThrownLoggerDatabaseException()
        {
            // Arrange
            ILogger databaseLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Database);

            // Act
            databaseLogger.AddMessage(MessageTypes.Warning, "");

            // Assert
            // Expected LoggerDatabaseException 
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerDatabaseException))]
        public void AddMessage_WithWarningMessageTypeAndNullMessage_ShouldThrownLoggerDatabaseException()
        {
            // Arrange
            ILogger databaseLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Database);

            // Act
            databaseLogger.AddMessage(MessageTypes.Warning, null);

            // Assert
            // Expected LoggerDatabaseException 
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerDatabaseException))]
        public void AddMessage_WithErrorMessageTypeAndEmptyMessage_ShouldThrownLoggerDatabaseException()
        {
            // Arrange
            ILogger databaseLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Database);

            // Act
            databaseLogger.AddMessage(MessageTypes.Error, "");

            // Assert
            // Expected LoggerDatabaseException 
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerDatabaseException))]
        public void AddMessage_WithErrorMessageTypeAndNullMessage_ShouldThrownLoggerDatabaseException()
        {
            // Arrange
            ILogger databaseLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Database);

            // Act
            databaseLogger.AddMessage(MessageTypes.Error, null);

            // Assert
            // Expected LoggerDatabaseException
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerDatabaseException))]
        public void InsertLogInDatabase_WithEmptyConnectionStringAndSomeMessage_ShouldThrownLoggerDatabaseException()
        {
            // Arrange
            LoggerDatabase databaseLogger = (LoggerDatabase)LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Database);

            // Act
            databaseLogger.InsertLogInDatabase("", MessageTypes.Information, "Content Log");

            // Assert
            // Expected LoggerDatabaseException
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerDatabaseException))]
        public void InsertLogInDatabase_WithNullConnectionStringAndSomeMessage_ShouldThrownLoggerDatabaseException()
        {
            // Arrange
            LoggerDatabase databaseLogger = (LoggerDatabase)LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Database);

            // Act
            databaseLogger.InsertLogInDatabase(null, MessageTypes.Information, "Content Log");

            // Assert
            // Expected LoggerDatabaseException
        }

    }
}
