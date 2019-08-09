using BenchmarkDotNet.Running;

namespace EnumMapper.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<EnumBenchmark>();
        }
    }
}
