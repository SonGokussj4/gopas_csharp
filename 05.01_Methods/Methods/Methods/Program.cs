using System;

namespace Methods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            int b = int.Parse(Console.ReadLine());

            int res = Secti(a, b);
            Console.WriteLine("Result: {0}", res);

            Console.WriteLine("Press any key to close this window");
            Console.Read();
        }

        private static int Secti(int a, int b)
        {
            return a + b;
        }
    }
}