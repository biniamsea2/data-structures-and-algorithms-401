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

        #region Insert
        #endregion


        #region Includes
        #endregion


        #region toString
        #endregion


        #region llkthfromend

        public int llkthFromend(int k)
        {
            Node current = Head;
            Node argument = null;
            int count = 0;

            while (current.Next != null)
            {
                if (count == k)
                {
                    argument = current;
                }
                current = current.Next;
                count++;
            }

            if (count != 0)
            {
                int countNum = 0;
                while (argument.Next != null)
                {
                    argument = argument.Next;
                    countNum++;
                }

                current = Head;
                for (int i = 0; i < k - countNum; i++)
                {
                    current = current.Next;
                }
                return current.Value;
            }
            return current.Value;
        }
    }


    #endregion



    #region LL Merge





    #endregion



}