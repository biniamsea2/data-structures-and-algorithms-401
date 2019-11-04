using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue
    {
        public node Front { get; set; }
        public node Back { get; set; }

        public Queue()
        {
            Front = null;
            Back = null;
        }


        /// <summary>
        /// Front is the first node, so if front has a node then 
        /// display its value otherwise display the message.
        /// </summary>
        public object Peek()
        {
            if (Front is node)
            {
                Console.WriteLine($"Front value is {Front.Value}");
                return Front.Value;
            }
            else
            {
                Console.WriteLine("Nothing to see");
                return null;
            }
        }

        /// <summary>
        /// assuming we already have stuff in our queue. Using a temp variable to 
        /// store the new node. This works but, it smells. 
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(int value)
        {
            node addNode = new node(value);
            if (Back is node)
            {
                var temp = addNode;
                Back = temp;
                Back.Previous = null;
                Back.Next = temp.Next
            }
            else
            {
                Front = null;
                Back = null;
            }
        }

        /// <summary>
        /// added front.previous to the if statment b/c I wanted set 
        ///  front to front.previous node. This kind of works, assuming
        ///  that there's more than one node in the queue. Could've done this differently by adding another if statement,
        ///  but I think this will do. Again assumming there is more than one node in the queue.
        /// </summary>
        /// <returns></returns>
        public object Dequeue()
        {
            if (Front is node)
            {
                var temp = Front;
                Front = temp.Previous;
                return temp.Value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// check the Front property, if there is a node
        /// set to front then return true. Otherwise display message and return false.
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            if (Front is node)
            {
                return true;
            }
            else
            {
                Console.WriteLine("The queue is empty");
                return false;
            }
        }

    }

}
