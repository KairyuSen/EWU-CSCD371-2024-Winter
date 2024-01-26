using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;



namespace Logger.Tests;

[TestClass]
    public class FileLoggerTests
    {
    private object FileLoggger;

    [TestMethod]
        public void FileLoggerLog_AffixMessageToFile_SuccessAppended()
        {
            string testPath = "testFile.txt";
            string testMessage = "Test Message";

            BaseLogger fileLogger = new FileLogger(testPath);

            FileLoggger.Log(LogLevel.Warning, testMessage);

            Assert.IsTrue(File.ReadAllText(testPath).Contains($"FileLogger Warning: Test Message"));
        }
    }