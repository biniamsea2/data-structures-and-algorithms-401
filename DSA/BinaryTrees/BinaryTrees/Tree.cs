using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTrees
{
    class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree(T value)
        {
            Root = new Node<T>(value);
        }
        public Tree()
        {

        }
        /// <summary>
        /// PreOrder is one of the depth first traversals, preorder checks the root first, then 
        /// the left child, then the right child. Doing a method overload with preorder. Using recursion
        /// with the second PreOrder method.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>

        public List<T> PreOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();
            // add the node we are looking at to the list
            PreOrder(node, traversal);
            return traversal;
        }

        private void PreOrder(Node<T> node, List<T> traversal)
        {
            traversal.Add(node.Value);

            // check if there is a left child
            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild, traversal);
            }

            if (node.RightChild != null)
            {
                PreOrder(node.RightChild, traversal);
            }
        }

        /// <summary>
        /// Inorder is doing the same thing but instead of starting at the root it starts at the left child, then
        /// goes to the root, then goes to the right child. So we move where we are adding it to the list. We move it
        /// after the first if statement.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        // InOrder

        public List<T> InOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();
            InOrder(node, traversal);
            return traversal;
        }

        private void InOrder(Node<T> node, List<T> traversal)
        {

            // check if there is a left child
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild, traversal);
            }

            traversal.Add(node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild, traversal);
            }
        }

        /// <summary>
        /// Again, we are doing the same thing with the post order. However, we are going from the left child, to the right child, then root
        /// this time. So we move where we are adding the node to the list, to the bottom of our recursion.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        // PostOrder

        public List<T> PostOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();
            PostOrder(node, traversal);
            return traversal;
        }

        private void PostOrder(Node<T> node, List<T> traversal)
        {

            // check if there is a left child
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild, traversal);
            }

            if (node.RightChild != null)
            {
                PostOrder(node.RightChild, traversal);
            }

            traversal.Add(node.Value);

        }
        /// <summary>
        /// Breadth first traversal is a little different. With Breadth first we are using a queue. And instead of post order,
        /// inorder, and preorder we are going level-order. We also don't need a recursion with breadth first; we use
        /// a while loop.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<T> BreadthFirst(Node<T> node)
        {
            Queue<Node<T>> breadth = new Queue<Node<T>>();
            List<T> values = new List<T>();

            breadth.Enqueue(node);

            while (breadth.TryPeek(out node))
            {
                Node<T> front = breadth.Dequeue();
                values.Add(front.Value);

                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }

                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return values;
        }
    }
}

