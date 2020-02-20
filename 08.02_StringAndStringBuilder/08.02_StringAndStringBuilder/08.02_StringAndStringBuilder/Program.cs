using System;
using System.Text;

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

            //string s = "";
            StringBuilder sb = new StringBuilder();
         
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            Console.WriteLine("Start");
            sw.Start();
            for (long i = 0; i < 150000000; i++)
            {
                // Slow as fuck - 940 ms (skoro sekunda)
                //s += "A";

                // Fast as fuck - 0ms
                // Abych se dostal na (940 ms, 100,000 iteraci --> 150,000,000
                sb.Append("A");
            }

            string s = sb.ToString();
            sw.Stop();
            Console.WriteLine("Stop");
            Console.WriteLine($"Elapsed: {sw.ElapsedMilliseconds} ms");
        }
    }
}