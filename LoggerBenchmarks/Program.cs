using BenchmarkDotNet.Running;
using Microsoft.Extensions.Logging;

namespace LoggerBenchmarks;

internal class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchmarks>();
    }
}
