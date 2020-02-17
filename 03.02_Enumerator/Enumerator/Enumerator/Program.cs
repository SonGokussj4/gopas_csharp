using System;

namespace Enumerator
{
    enum Color 
    { 
        Red, 
        Green = 50, 
        Blue
    }

    class Program
    {
        static void Main(string[] args)
        {
            Color ruda = Color.Red;
            Console.WriteLine(string.Format("Hello World! Ruda je: {0}", (int)Color.Green));
        }
    }
}
