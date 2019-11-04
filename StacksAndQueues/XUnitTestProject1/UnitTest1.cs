using System;
using Xunit;
using StacksAndQueues;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PushtoStack()
        {
            stack test = new stack();
            test.Push(5);
            Assert.Equal(5, test.Top.Value);
        }

        [Fact]
        public void MultiplePush()
        {
            stack test = new stack();
            test.Push(5);
            test.Push(4);
            test.Push(3);
            Assert.Equal(3, test.Top.Value);
        }

        [Fact]
        public void PopOffStack()
        {
            stack test = new stack();
            test.Push(4);
            test.Push(3);
            test.Push(2);
            object popOff = test.Pop();
            Assert.NotEqual(3, popOff);
        }

        [Fact]
        public void EmptyTheStackAfterMultiplePops()
        {
            stack test = new stack();
            test.Push(5);
            test.Push(4);
            test.Push(3);
            object popOff = test.Pop();
            object popOff2 = test.Pop();

            Assert.NotEqual(3, popOff);
        }

        [Fact]
        public void Peek()
        {
            stack test = new stack();
            test.Push(5);
            test.Push(4);
            test.Push(3);
            object peeking = test.Peek();

            Assert.Equal(3, peeking);
        }

        [Fact]
        public void EmptyStack()
        {
            stack test = new stack();
            object testing = test.isEmpty();
            Assert.Equal(false, testing);
        }

        [Fact]
        public void Dequeue()
        {
            Queue test = new Queue();
            test.Enqueue(5);
            test.Enqueue(6);
            test.Enqueue(7);
            test.Enqueue(8);
            test.Dequeue();
            Assert.NotEqual(6, test.Dequeue());
        }

        [Fact]
        public void PeekQueue()
        {
            Queue test = new Queue();
            test.Enqueue(5);
            test.Enqueue(6);

            Assert.NotEqual(6, test.Peek());
        }

        [Fact]
        public void MultipleDequeue()
        {
            Queue test = new Queue();
            test.Enqueue(5);
            test.Enqueue(6);
            test.Enqueue(7);
            test.Dequeue();
            test.Dequeue();
            Assert.NotEqual(5, test.Peek());
        }

        [Fact]
        public void EmptyQueue()
        {
            Queue test = new Queue();
            object testing = test.isEmpty();
            Assert.Equal(false, testing);
        }


    }
}
