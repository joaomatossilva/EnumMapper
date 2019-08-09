using BenchmarkDotNet.Attributes;
using System;

namespace EnumMapper.Benchmark
{
    [MemoryDiagnoser]
    public class EnumBenchmark
    {
        public enum TestEnum1
        {
            First = 1,
            Second = 2
        }

        public enum TestEnum2
        {
            First = 2,
            Second = 1
        }


        [Benchmark]
        public TestEnum2 EnumParse()
        {
            return (TestEnum2)Enum.Parse(typeof(TestEnum2), TestEnum1.First.ToString());
        }

        [Benchmark]
        public TestEnum2 EnumMapper()
        {
            return TestEnum1.First.To<TestEnum2>();
        }
    }
}
