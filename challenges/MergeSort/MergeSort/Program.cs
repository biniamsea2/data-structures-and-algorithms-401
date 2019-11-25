using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] test = new int[] { 8, 4, 23, 42, 16, 15 };

            Console.WriteLine("Sorted array: "+string.Join(",", MergeSort1(test)));
        }

        public static int [] MergeSort1(int[] array)
        {
            //create a variable 'n' and set it to the length of the array.
            int n = array.Length;
            //check if the array has more than one number in order to be sorted.
            if (n > 1)
            {
                //create a variable called mid to be an indicator of the mid point of the array.
                int mid = n / 2;
                //the left array will hold all the numbers of the left side of mid. The right will do the same thing but will hold all numbers on the right side of mid.
                int[] left = new int[mid];
                int[] right = new int[n - mid];

                for (int i = 0; i < n; i++)
                {
                    if (i < mid)
                    {
                        left[i] = array[i];

                    }
                    else
                    {
                        right[i - mid] = array[i];

                    }
                }
                    //sort the left side
                    MergeSort1(left);
                    //sort the right side
                    MergeSort1(right);
                    //merge the sorted left and right sides together
                    Merge(left, right, array);
                }
            
            return array;
        }
        /// <summary>
        /// created a method called merge that takes in three arrays which will be used to sort out the values.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="array"></param>
        public static void Merge(int[] left, int[] right, int[] array)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int lLength = left.Length;
            int rLength = right.Length;

            while (i < left.Length && j < right.Length)
            {
                    if (left[i] <= right[j])
                    {
                        array[k] = left[i];
                        i++;
                    }
                    else
                    {
                        array[k] = right[j];
                        j++;
                    }
                    k++;
                }
                if (i == lLength)
                {
                    while (j < rLength)
                    {
                        array[k] = right[j];
                        j++;
                        k++;
                    }
                }
                else
                {
                    while (i < lLength)
                    {
                        array[k] = left[i];
                        i++;
                        k++;
                    }
                }
            
        }


    }

}
