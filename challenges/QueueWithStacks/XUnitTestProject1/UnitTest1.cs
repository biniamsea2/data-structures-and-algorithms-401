using System;
using Xunit;
using QueueWithStacks;
using System.Collections;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void HappyTest()
        {
            //push into stack
            Stack sTest = new Stack();
            sTest.Push(1); //first one in, should be the first one out
            sTest.Push(2);
            sTest.Push(3);

            PseudoQueue qTest = new PseudoQueue();
            qTest.Enqueue(3); //adding to the queue
            qTest.Enqueue(2);
            qTest.Enqueue(1);
            Assert.Equal(sTest.Pop(), qTest.Dequeue()); //3 should be expected

        }

        [Fact]
        public void ExpectedFailure()
        {
            //push into stack
            Stack sTest = new Stack();
            sTest.Push(1); //first one in, should be the first one out
            sTest.Push(2);
            sTest.Push(3);

            PseudoQueue qTest = new PseudoQueue();
            qTest.Enqueue(13); //not right numbers so, should be wrong
            qTest.Enqueue(12);
            qTest.Enqueue(10);
            Assert.NotEqual(sTest.Pop(), qTest.Dequeue()); 

        }

        [Fact]
        public void EdgeCase()
        {
            Stack sTest = new Stack();  //if 5 is the only thing in the stack it should pop out 5
            sTest.Push(5);
            Assert.Equal(5, sTest.Pop());
        }


    }
}
