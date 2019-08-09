using System;
using Xunit;

namespace EnumMapper.Tests
{
    public class UnitTest1
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


        [Fact]
        public void EnumConversionMadeByName()
        {
            var testEnum2 = TestEnum1.First.To<TestEnum2>();

            Assert.Equal(TestEnum2.First, testEnum2);
        }
    }
}
