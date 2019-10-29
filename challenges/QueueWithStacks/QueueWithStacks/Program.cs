using System;

namespace QueueWithStacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            PseudoQueue myQueue = new PseudoQueue();
            myQueue.Enqueue(5); //this is the first value
            myQueue.Enqueue(10);
            myQueue.Enqueue(15);
            myQueue.Enqueue(20);


            Console.WriteLine(myQueue.Dequeue()); // should make the first value first, which should be 5
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue()); // should be the last value, which is 20
        }
    }
}
