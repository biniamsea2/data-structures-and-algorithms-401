using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    class Node <Object>
    {
        public Object Value { get; set; }
        public Node <Object> LeftChild { get; set; }
        public Node <Object> RightChild { get; set; }

        public Node(Object value)
        {
            Value = value;
        }
    }
}
