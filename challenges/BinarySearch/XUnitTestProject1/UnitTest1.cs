using System;
using Xunit;
using static BinarySearch.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Happy()
        {
            int[] numbers = new int []  {1, 2, 3, 4, 5 };
            Assert.Equal(2, BSearch(numbers, 3));
        }

        [Fact]
        public void ExpectedFail()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            Assert.NotEqual(1, BSearch(numbers, 3));
        }

        [Fact]
        public void Double()
        {
            int[] numbers = new int[] {1,2,3,3,4};
            Assert.Equal(2, BSearch(numbers, 3));
        }


    }
}
