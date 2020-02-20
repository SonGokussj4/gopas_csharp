using System;

namespace _09._02_Finalizace
{
    class FileStream
    {
        public void Open()
        {
            Console.WriteLine("Opening file");
        }

        public void Close()
        {
            Console.WriteLine("Closing file");
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            FileStream fs = new FileStream();
            fs.Open();
        }
    }
}