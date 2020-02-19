using System;

namespace _06._01_Array_Excercise_CreateArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = CreateArray(5, 3);

            foreach (int item in arr)
            {
                Console.WriteLine("Value: {0}", item);
            }
        }

        private static int[] CreateArray(int size, int defaultValue)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = defaultValue;
            }
            return arr;
        }
    }
}