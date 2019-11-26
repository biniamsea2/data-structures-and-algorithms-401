using System;
using Xunit;
using static QuickSort.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void HappyTest()
        {
            int[] test = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] sorted = new int[] { 4, 8, 15, 16, 23, 42 };
            int test2 = test.Length - 1;

            Assert.Equal(sorted, QuickSort1(test,0,test2));
        }

        [Fact]
        public void ExpectedFail()
        {
            int[] test = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] sorted = new int[] { 4, 8, 42, 23, 16, 15 };
            int test2 = test.Length - 1;

            Assert.NotEqual(sorted, QuickSort1(test, 0, test2));
        }

        [Fact]
        public void EdgeCase()
        {
            int[] test = new int[] { 8, 8,8,8,8,8,-2 };
            int[] sorted = new int[] { -2,8,8,8,8,8,8 };
            int test2 = test.Length - 1;

            Assert.Equal(sorted, QuickSort1(test, 0, test2));
        }
    }
}
