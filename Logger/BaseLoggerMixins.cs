namespace Logger;
using System.Globalization;

public static class BaseLoggerMixins
{
    public static void Error_WithNullLogger_ThrowsException(this BaseLogger? logger, string message, params object[] args)
    {
        if (logger != null)
        {
            logger.Log(LogLevel.Error, message);
        }
        else
        {
            throw new System.ArgumentNullException(null, "Error mixin = null");
        }

    }
    public static void Warning_WithNullLogger_ThrowsException(this BaseLogger? logger, string message, params object[] args)
    {
        if (logger != null)
        {
            logger.Log(LogLevel.Warning, message);
        }
        else
        {
            throw new System.ArgumentNullException(null, "Warning mixin = null");
        }

    }

    public static void Debug_WithNullLogger_ThrowsException(this BaseLogger? logger, string message, params object[] args)
    {
        if (logger != null)
        {
            logger.Log(LogLevel.Debug, message);
        }
        else
        {
            throw new System.ArgumentNullException(null, "Debug mixin = null");
        }

    }

    public static void Information_WithNullLogger_ThrowsException(this BaseLogger? logger, string message, params object[] args)
    {
        if (logger != null)
        {
            logger.Log(LogLevel.Information, message);
        }
        else
        {
            throw new System.ArgumentNullException(null, "Information mixin = null");
        }
    }

}
