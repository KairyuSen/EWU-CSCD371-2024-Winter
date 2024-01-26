using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
    [TestMethod]
    public void CreateLogger_CheckName_Pass()
    {
        var logFactory = new LogFactory();

        string pathName = "TestPath.txt";
        logFactory.ConfigureFileLogger(pathName);

        Assert.IsNotNull(logFactory.createLogger());


    }

    [TestMethod]
    public void CreateLogger_InvalidPath_Null()
    {
        LogFactory logFactory = new();

        Assert.IsNull(logFactory.CreateLogger());
    }
}
