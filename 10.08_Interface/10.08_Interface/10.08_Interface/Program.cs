using System;

namespace _10._08_Interface
{
    interface IStringConvertible
    {
        string ToUpperCase();
        string ToLowerCase();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
