using System;

namespace Parameters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine("Puvodni: a = {0}", a);
            Calculate(ref a);
            Console.WriteLine("Potom:   a = {0}", a);
        }

        //private static void Calculate(int p)
        private static void Calculate(ref int p)
        {
            p++;
            Console.WriteLine("Uvnitr:  p = {0}", p);
        }
    }
}