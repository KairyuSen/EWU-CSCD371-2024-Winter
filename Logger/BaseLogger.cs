using System;
using System.IO;
using System.Globalization;

namespace Logger;
#nullable enable

public abstract class BaseLogger
{
    public abstract void Log(LogLevel logLevel, string message);

    public string? ClassName { get; set; }
}



public class FileLogger : BaseLogger
{
    public FileLogger(string fileName)
    {
        _fileName = fileName;
    }


    private string className = nameof(FileLogger);
    private string _fileName;
    private readonly object dateTime;

    public void Log(LogLevel logLev, string message)
    {
        string logFix = $"{dateTime} {className} {logLev} {message}";

        File.AppendAllText(_fileName, logFix);
    }

    public override void Log(LogLevel logLevel, string message)
    {
        throw new NotImplementedException();
    }
}

