using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Logging;

namespace LoggerBenchmarks;

[MemoryDiagnoser]
[RPlotExporter]
[CsvMeasurementsExporter]
public class Benchmarks
{
    private readonly ILogger _logger = LoggerFactory.Create(builder => 
        builder.SetMinimumLevel(LogLevel.Information))
        .CreateLogger<Program>();

    private readonly DateTime _dateTimeParam = DateTime.Now;
    private readonly int _intParam = 100;

    [Benchmark]
    public void E0() //ExtensionMethodNoVariables()
    {
        _logger.LogInformation(LogMessages.LogMessageNoVar);
    }

    [Benchmark]
    public void E1() //ExtensionMethodOneVariable()
    {
        _logger.LogInformation(LogMessages.LogMessageOneVar, _dateTimeParam);
    }

    [Benchmark]
    public void E2() //ExtensionMethodTwoVariables()
    {
        _logger.LogInformation(LogMessages.LogMessageTwoVars, _intParam, _dateTimeParam);
    }

    [Benchmark]
    public void E0d() //ExtensionMethodNoVariablesDisabled()
    {
        _logger.LogDebug(LogMessages.LogMessageNoVar);
    }

    [Benchmark]
    public void E1d() //ExtensionMethodOneVariableDisabled()
    {
        _logger.LogDebug(LogMessages.LogMessageOneVar, _dateTimeParam);
    }

    [Benchmark]
    public void E2d() //ExtensionMethodTwoVariablesDisabled()
    {
        _logger.LogDebug(LogMessages.LogMessageTwoVars, _intParam, _dateTimeParam);
    }

    [Benchmark]
    public void Sg0() //SourceGeneratedNoVariables()
    {
        _logger.InfoNoVarLog();
    }

    [Benchmark]
    public void Sg1() //SourceGeneratedOneVariable()
    {
        _logger.InfoOneVarLog(_dateTimeParam);
    }

    [Benchmark]
    public void Sg2() //SourceGeneratedTwoVariables()
    {
        _logger.InfoTwoVarsLog(_intParam, _dateTimeParam);
    }

    [Benchmark]
    public void Sg0d() //SourceGeneratedNoVariablesDisabled()
    {
        _logger.DebugNoVarLog();
    }

    [Benchmark]
    public void Sg1d() //SourceGeneratedOneVariableDisabled()
    {
        _logger.DebugOneVarLog(_dateTimeParam);
    }

    [Benchmark]
    public void Sg2d() //SourceGeneratedTwoVariablesDisabled()
    {
        _logger.DebugTwoVarsLog(_intParam, _dateTimeParam);
    }
}