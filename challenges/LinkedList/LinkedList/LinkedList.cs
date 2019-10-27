using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList2
    {
        public Node Head { get; set; }

        public LinkedList2()
        {
            Head = null;
        }

        #region Append
        /// <summary>
        /// adds a new node with the given value 
        /// to the END of the list
        /// </summary>
        /// <param name="value"></param>
        public void Append(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        #endregion


        #region Insert Before
        /// <summary>
        /// adds a new node with the given newValue 
        /// immediately BEFORE the first value node
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newVal"></param>

        public void InsertBefore(int value, int newVal)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node previous = null;
                Node current = Head;
                while (current.Value != value)
                {
                    current = current.Next;
                    previous = current.Next;
                }
                if (previous == null)
                {
                    Head = new Node(newVal);
                }
                else
                {
                    previous.Next = new Node(newVal);
                }
            }
        }

        #endregion

        #region Insert After

        /// <summary>
        /// adds a new node with the given newValue 
        /// immediately AFTER the first value node
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newVal"></param>
        public void InsertAfter(int value, int newVal)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Value != value)
                {
                    current = current.Next;
                }
                current.Next = new Node(newVal);
            }
        }

        #endregion




        #region llkthfromend

        public void llkthFromend(int K)
        {
            Node newNode = new Node(K);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                int counter = 0;
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                    counter++;
                    int final = counter - K;
                }
                current.Next = newNode;
            }
        }





        #endregion



        #region LL Merge

        #endregion


    }
}
