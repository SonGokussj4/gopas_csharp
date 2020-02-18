using System;

namespace Parameters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int a = 1;
            int a;
            //Console.WriteLine("Puvodni: a = {0}", a);
            Console.WriteLine("Puvodni: a = neprirazena hodnota");
            Calculate(out a);
            Console.WriteLine("Potom:   a = {0}", a);
        }

        //private static void Calculate(int p)
        //private static void Calculate(ref int p)
        private static void Calculate(out int p)
        {
            //p++;
            p = 2;
            Console.WriteLine("Uvnitr:  p = {0}", p);
        }
    }
}