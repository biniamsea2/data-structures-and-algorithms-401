using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTrees
{
    /// <summary>
    /// creating node class with generic type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Value { get; set; }
        public Node <T> LeftChild { get; set; }
        public Node <T> RightChild { get; set; }
    }
}
