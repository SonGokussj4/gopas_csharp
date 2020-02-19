using System;

namespace Array
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int[] list;
            int[] list = new int[4];

            list[0] = 10;
            list[1] = 20;
            list[2] = 30;
            list[3] = 40;

            foreach (int item in list)
            {
                Console.WriteLine("Item: {0}", item);
            }
        }
    }
}