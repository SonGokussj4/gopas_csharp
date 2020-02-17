using System;

namespace _03._01_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a;
            a = 0;
            Console.WriteLine("a = {0}", a);

            int b = 1;
            Console.WriteLine("b = {0}", b);

            a = 0;
            a++;
            a++;
            Console.WriteLine(a);  // 2

            System.Console.WriteLine("a = {0}, b= {1}", a++, b++);
            System.Console.WriteLine("a = {0}, b= {1}", a, b);
        }
    }
}
