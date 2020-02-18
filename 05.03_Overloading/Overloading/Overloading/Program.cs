using System;

namespace Overloading
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int res1 = Secti(2, 3);
            int res2 = Secti(2, 3, 4);
            long res3 = Secti(465464654646465465, 1);
        }

        private static int Secti(int a, int b)
        {
            return a + b;
        }

        private static long Secti(long a, long b)
        {
            return a + b;
        }

        private static int Secti(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}