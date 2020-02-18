using System;

namespace Overloading
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int res1 = Secti(2, 3);
            int res2 = Secti(2, 3, 4);
            int res3 = Secti(1, 2, 3, 4, 5, 6, 7);
            Console.WriteLine("Suma: {0}", res3);
        }

        private static int Secti(int a, int b)
        {
            return a + b;
        }

        //private static int Secti(int args)
        private static int Secti(params int[] args)
        {
            int suma = 0;
            foreach (int item in args)
            {
                suma += item;
            }
            return suma;
        }


        private static int Secti(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}