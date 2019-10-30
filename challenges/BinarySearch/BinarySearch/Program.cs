using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine("Choose a number to search betweeen 1 - 10. If search number returns -1 your searched number was not found.");

            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your target number was found at index: " + BSearch(numbers, target));
        }


        public static int BSearch(int [] numbers, int target)
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
                else if (numbers[mid] < target)
                {
                    left = mid + 1;
                }

            }
            return -1;


        }
    }
}
