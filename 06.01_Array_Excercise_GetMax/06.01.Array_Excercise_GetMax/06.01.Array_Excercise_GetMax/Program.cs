using System;

namespace _06._01.Array_Excercise_GetMax
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = { 1, 5, 2, 4, 6, 7, 2, 4, 6 };
            int result = GetMax(arr);
            Console.WriteLine("Max Positive: '{0}'", result);
            
            int[] arr2 = { -10, -20};
            int result2 = GetMax(arr2);
            Console.WriteLine("Max Negative: '{0}'", result2);
        }

        private static int GetMax(int[] arr)
        {
            int semi_max = arr[0];
            foreach (int item in arr)
            {
                if (item > semi_max) semi_max = item;
            }
            return semi_max;
        }
    }
}