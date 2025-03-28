using System;

namespace FindMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 6 };
            int n = 6; // The size of the array + 1

            Console.WriteLine("The missing number is: " + FindMissingNumber(arr, n));
        }

        static int FindMissingNumber(int[] arr, int n)
        {
            int totalSum = n * (n + 1) / 2;
            int arrSum = 0;

            foreach (int num in arr)
            {
                arrSum += num;
            }

            return totalSum - arrSum;
        }
    }
}
