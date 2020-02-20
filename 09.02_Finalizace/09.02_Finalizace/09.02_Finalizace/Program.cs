using System;

namespace _09._02_Finalizace
{
    internal class FileStream
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
            try
            {
                fs.Open();
                // Pracuji se souborem
                throw new Exception("Invalit file operation");
            }
            finally
            {
                fs.Close();
            }
        }
    }
}