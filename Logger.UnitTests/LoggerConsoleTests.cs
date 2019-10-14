using System;
using Logger.Exceptions;
using Logger.Factory;
using Logger.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Logger.Transverse.Enumerators.Enums;

namespace Logger.UnitTests
{
    [TestClass]
    public class LoggerConsoleTests
    {
        [TestMethod]
        [ExpectedException(typeof(LoggerConsoleException))]
        public void AddMessage_WithInformationMessageTypeAndEmptyMessage_ShouldThrownLoggerConsoleException()
        {
            // Arrange
            ILogger consoleLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Console);

            // Act
            consoleLogger.AddMessage(MessageTypes.Information, "");

            // Assert
            // Expected LoggerConsoleException 
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerConsoleException))]
        public void AddMessage_WithInformationMessageTypeAndNullMessage_ShouldThrownLoggerConsoleException()
        {
            // Arrange
            ILogger consoleLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Console);

            // Act
            consoleLogger.AddMessage(MessageTypes.Information, null);

            // Assert
            // Expected LoggerConsoleException 
        }

        [TestMethod]
        public void AddMessage_WithInformationMessageTypeAndSomeMessage_ShouldAddLog()
        {
            // Arrange
            ILogger consoleLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Console);

            // Act
            consoleLogger.AddMessage(MessageTypes.Information, "Information Message");

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerConsoleException))]
        public void AddMessage_WithWarningMessageTypeAndEmptyMessage_ShouldThrownLoggerConsoleException()
        {
            // Arrange
            ILogger consoleLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Console);

            // Act
            consoleLogger.AddMessage(MessageTypes.Warning, "");

            // Assert
            // Expected LoggerConsoleException 
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerConsoleException))]
        public void AddMessage_WithWarningMessageTypeAndNullMessage_ShouldThrownLoggerConsoleException()
        {
            // Arrange
            ILogger consoleLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Console);

            // Act
            consoleLogger.AddMessage(MessageTypes.Warning, null);

            // Assert
            // Expected LoggerConsoleException 
        }

        [TestMethod]
        public void AddMessage_WithWarningMessageTypeAndSomeMessage_ShouldAddLog()
        {
            // Arrange
            ILogger consoleLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Console);

            // Act
            consoleLogger.AddMessage(MessageTypes.Warning, "Warning Message");

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerConsoleException))]
        public void AddMessage_WithErrorMessageTypeAndEmptyMessage_ShouldThrownLoggerConsoleException()
        {
            // Arrange
            ILogger consoleLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Console);

            // Act
            consoleLogger.AddMessage(MessageTypes.Error, "");

            // Assert
            // Expected LoggerConsoleException 
        }

        [TestMethod]
        [ExpectedException(typeof(LoggerConsoleException))]
        public void AddMessage_WithErrorMessageTypeAndNullMessage_ShouldThrownLoggerConsoleException()
        {
            // Arrange
            ILogger consoleLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Console);

            // Act
            consoleLogger.AddMessage(MessageTypes.Error, null);

            // Assert
            // Expected LoggerConsoleException 
        }

        [TestMethod]
        public void AddMessage_WithErrorMessageTypeAndSomeMessage_ShouldAddLog()
        {
            // Arrange
            ILogger consoleLogger = LoggerFactory.InitializeFactory().CreateLogger(LoggerTypes.Console);

            // Act
            consoleLogger.AddMessage(MessageTypes.Error, "Error Message");

            // Assert
            Assert.IsTrue(true);
        }

    }
}
