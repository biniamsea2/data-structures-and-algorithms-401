using System;
using Xunit;
using static MergeSort.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void HappyTest()
        {
            int[] test = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] sorted = new int[] { 4, 8, 15, 16, 23, 42 };

            Assert.Equal(sorted, MergeSort1(test));
        }

        [Fact]
        public void ExpectedFailedTest()
        {
            int[] test = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] sorted = new int[] { 4, 16, 15, 8, 42,23 };

            Assert.NotEqual(sorted, MergeSort1(test));
        }

        [Fact]
        public void EdgeCase()
        {
            int[] test = new int[] { 8, 8, 8, 8, -1 };
            int[] sorted = new int[] { -1, 8, 8,8,8, };

            Assert.Equal(sorted, MergeSort1(test));
        }
    }
}
