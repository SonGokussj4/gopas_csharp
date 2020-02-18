using System;

namespace Recursion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Factorial of number {0} is {1}",
                number, Factorial(number));
        }

        private static int Factorial(int currentNumber)
        {
            if (currentNumber <= 1)
                return 1;
            return currentNumber * Factorial(currentNumber - 1);
        }
    }
}