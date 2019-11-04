using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class stack
    {
        public node Top { get; set; }

        public stack()
        {
            Top = null;
        }

        public void Push(int value)
        {
            node newnode = new node(value);
            if (Top == null)
            {
                Top = newnode;
                Top.Previous = null;
            }
            else
            {
                Top = null;
            }
        }

        public object Pop()
        {
            if (Top is node)
            {
                var tempNode = Top;
                Top = tempNode.Previous;
              


                Console.WriteLine($"This is what we got from the top of the stack {tempNode.Value}");
                return tempNode;
            }
            else
            {
                return null;
            }
        }

        public object Peek()
        {
            if (Top is node)
            {
                Console.WriteLine($"Top of the stack node: {Top.Value}");
                return Top.Value;
            }
            else
            {
                Console.WriteLine("error");
                return null;
            }
        }

        public bool isEmpty()
        {
            if (Top is node)
            {
                return true;
            }

            else
            {
                return false;
            }
        }




    }
}
