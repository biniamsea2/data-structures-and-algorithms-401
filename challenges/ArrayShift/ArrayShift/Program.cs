using System;

namespace ArrayShift
{
    public class Program
    {
       public static void Main(string[] args)
        {
            int [] challenge = { 4, 5, 6, 7 };
            int value = 88;
            InsertShiftArray(challenge, value);
        }

        public static int [] InsertShiftArray(int[] challenge, int value)
        {
            int mid = challenge.Length / 2;
            int[] newArray = new int[challenge.Length + 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (mid == i)
                {
                    newArray[i] = value;
                }
                else if (i > mid)
                {
                    newArray[i] = challenge[i-1];
                }
                else
                {
                    newArray[i] = challenge[i];
                }
            }

          
            Console.WriteLine("Your new array is: " + String.Join(" , ", newArray));
            return newArray;
        }

    }
}
