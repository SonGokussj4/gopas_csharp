using System;

namespace _08._02_StringAndStringBuilder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string s1 = "ABC";
            string s2 = s1;

            // Objekty jsou jeden a tentyz
            Console.WriteLine(s1 == s2);

            // Toto udela novy objekt, prerusi to referenci
            s2 += "D";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            // Uz nejsou stejne
            Console.WriteLine(s1 == s2);

            string s = "";
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            Console.WriteLine("Start");
            sw.Start();
            // Slow as fuck - 940 ms (skoro sekunda)
            for (int i = 0; i < 100000; i++)
            {
                s += "A";
            }

            sw.Stop();
            Console.WriteLine("Stop");
            Console.WriteLine($"Elapsed: {sw.ElapsedMilliseconds} ms");
        }
    }
}