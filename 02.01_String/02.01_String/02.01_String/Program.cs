using System;

namespace _02._01_String
{
    class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("A");
            Console.WriteLine("B");
            Console.WriteLine("C");

            SubMain("A" + "B" + "C");

            for (int i = 0; i < 10; i++)
            {
                RewriteLine(string.Format("Kompliite: {0} %", i * 10 + 10), 100);
            }
            Console.WriteLine();

            string text = string.Format("This is newline: {0}", Environment.NewLine);
            Console.Write(text);

            Console.WriteLine(string.Format("Float: {0:0.00}", 4.3));
            Console.WriteLine(string.Format("Currency: {0:C}", 4.3));

            double myFloat = 3.1415141514151415D;
            Console.WriteLine(string.Format("{0}", myFloat));


        }

        /// <summary>
        /// Write 'ABC'
        /// </summary>
        /// <param name="args"></param>
        static void SubMain(string args)
        {
            Console.WriteLine(args);
        }

        /// <summary>
        /// Write 'Kompliite: X %' where X is number from 10-100, increasing after <timeout> on the same line
        /// </summary>
        /// <param name="text">Text to show</param>
        /// <param name="timeout">Wait in ms</param>
        static void RewriteLine(string text, int timeout)
        {
            Console.Write(string.Format("\r{0}", text));
            System.Threading.Thread.Sleep(timeout);
        }

    }
}
