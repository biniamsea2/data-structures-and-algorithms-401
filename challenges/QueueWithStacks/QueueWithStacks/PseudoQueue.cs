using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;



namespace QueueWithStacks
{
    public class PseudoQueue
    {
        public Stack s1 = new Stack();
        public Stack s2 = new Stack();

        public void Enqueue (int value)
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
            s1.Push(value);

            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }
        }

       
        public int Dequeue ()
        {
            int value = (int)s1.Pop();
            return value;
        }
    }
}
