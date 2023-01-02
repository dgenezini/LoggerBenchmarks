using BenchmarkDotNet.Attributes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;

namespace LoggerBenchmarks;

public static partial class LogMessages
{
    public const string LogMessageNoVar = "Log message";

    public const string LogMessageOneVar = "Log at {time}";

    public const string LogMessageTwoVars = "Log number {number} at {time}";

    [LoggerMessage(Level = LogLevel.Information, Message = LogMessageNoVar)]
    public static partial void InfoNoVarLog(this ILogger logger);

    [LoggerMessage(Level = LogLevel.Information, Message = LogMessageOneVar)]
    public static partial void InfoOneVarLog(this ILogger logger, DateTime time);

    [LoggerMessage(Level = LogLevel.Information, Message = LogMessageTwoVars)]
    public static partial void InfoTwoVarsLog(this ILogger logger, int number, DateTime time);

    [LoggerMessage(Level = LogLevel.Debug, Message = LogMessageNoVar)]
    public static partial void DebugNoVarLog(this ILogger logger);

    [LoggerMessage(Level = LogLevel.Debug, Message = LogMessageOneVar)]
    public static partial void DebugOneVarLog(this ILogger logger, DateTime time);

    [LoggerMessage(Level = LogLevel.Debug, Message = LogMessageTwoVars)]
    public static partial void DebugTwoVarsLog(this ILogger logger, int number, DateTime time);
}