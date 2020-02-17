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
        }
        /// <summary>
        /// Write 'A B C'
        /// </summary>
        /// <param name="args"></param>
        static void SubMain(string args)
        {
            Console.WriteLine(args);
        }


    }
}
