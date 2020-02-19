using System;

namespace _06._03_Debugging
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int cislo = Secti(3, 4);
            int dalsiCislo = cislo - 2;

            Console.WriteLine(dalsiCislo);
        }

        private static int Secti(int a, int b)
        {
            // F9 udelat breakpoint
            int cisloA = a;

            // Tady to ukaze Call Stack, kde vidim, ze jsem vylezl z metody Main
            int cisloB = b;
            int vysledek = cisloA + cisloB;
            return vysledek;
        }
    }
}