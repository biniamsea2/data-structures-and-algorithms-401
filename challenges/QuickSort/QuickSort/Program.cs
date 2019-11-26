using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 8, 4, 23, 42, 16, 15 };
            int test2 = test.Length - 1;
            Console.WriteLine("Sorted array: " + string.Join(",", QuickSort1(test, 0, test2)));
        }

        public static int [] QuickSort1(int[] array, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(array, left, right);
                //sorts the left
                QuickSort1(array, left, position - 1);
                //sorts the right
                QuickSort1(array, position + 1, right);
            }
            return array;
        }

        public static int Partition(int[] array, int left, int right)
        {
            // sets pivot value as a point of reference
            int pivot = array[right];
            // variable created to track the largest index of numbers lower than the defined pivot
            int low = left - 1;
            for (int i = left; i < right; i++)
            {
                if (array[i] <= pivot)
                {
                    low++;
                    Swap(array, i, low);
                }
            }
            // places the value of the pivot location in the middle.
            // all numbers smaller than the pivot are on the left, larger on the right. 
            Swap(array, right, low + 1);
            // returns the pivot index point
            return low + 1;
        }
        public static void Swap(int[]array, int i, int low)
        {
            int temp = array[i];
            array[i] = array[low];
            array[low] = temp;
        }
    }
}
