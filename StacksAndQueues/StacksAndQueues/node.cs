using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class node
    {
        public int Value { get; set; }
        public node Next { get; set; }
        public node Previous { get; set; }

        public node(int value)
        {
            Value = value;
            Next = null;
  
        }
    }
}
