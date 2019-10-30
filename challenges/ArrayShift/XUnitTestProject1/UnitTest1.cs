using System;
using Xunit;
using static ArrayShift.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Happy()
        {
            Assert.Equal(new int[] { 1, 88,2, 3 } , InsertShiftArray ( new int[] { 1, 2, 3 }, 88 ));
        }

        [Fact]
        public void ExpectedFail()
        {
            Assert.NotEqual(new int[] { 1, 2, 3, 88, 4 }, InsertShiftArray(new int[] { 1, 2, 3, 4 }, 88));
        }

        [Fact]
        public void EdgeCase()
        {
            Assert.Equal(new int[] { 88 }, InsertShiftArray(new int[] { }, 88));
        }

    }
}
