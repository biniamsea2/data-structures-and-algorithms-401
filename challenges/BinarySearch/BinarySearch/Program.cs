using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine("Choose a number to search betweeen 1 - 10");

            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your target number was found at index: " + BinarySearch(numbers, target));
        }


        private static int BinarySearch(int [] numbers, int target)
        {
            int mid;
            int left = 0;
            int right = numbers.Length;

            while (left <= right)
            {

                mid = (left + right) / 2;

                if (numbers[mid] == target)
                {
                    return mid;
                }
                else if (numbers[mid] > target)
                {
                    right = mid - 1;

                }
                else
                {
                    left = mid + 1;
                }

            }
            return -1;


        }
    }
}
