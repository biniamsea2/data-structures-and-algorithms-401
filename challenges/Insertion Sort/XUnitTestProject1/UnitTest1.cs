using System;
using Xunit;
using static Insertion_Sort.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void HappyTest()
        {
            int[] NewArr = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] Answer = new int[] { 4, 8, 15, 16, 23, 42 }; 

            Assert.Equal(Answer, InsertionSort(NewArr));
        }

        [Fact]
        public void FailedTest()
        {
            int[] NewArr = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] Answer = new int[] { 42, 8, 23, 16, 15, 4 };

            Assert.NotEqual(Answer, InsertionSort(NewArr));
        }

        [Fact]
        public void EdgeCase()
        {
            int[] NewArr = new int[] { 8, 4, 4, 4, 16, 15 };
            int[] Answer = new int[] { 4,4,4,8,15,16 };

            Assert.Equal(Answer, InsertionSort(NewArr));
        }
    }
}
