using System;
using System.Collections;

namespace _06._02_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] list = { 10, 20, 30 };
            //Console.WriteLine(list.ToString()); 

            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            list.Remove(20);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
