using System;

namespace Insertion_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] NewArr = new int[] { 8, 4, 23, 42, 16, 15 };
            InsertionSort(NewArr);
            PrintNums(NewArr);
        }

        public static int [] InsertionSort(int [] Arr)
        {
            for (int i = 0; i < Arr.Length -1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (Arr[j - 1] > Arr[j])
                    {
                        int temp = Arr[j - 1];
                        Arr[j - 1] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            return Arr;
        }

        public static void PrintNums(int [] Arr2)
        {
            foreach (int item in Arr2)
            {
                Console.WriteLine(item.ToString() + " ");
            }
        }
    }
}
