using System;
using System.Collections;

namespace _04_Excercise_PrimeNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayList nums = new ArrayList();

            // Ask for a number and check if it's valid
            Console.Write("Enter a number: ");
            string text = Console.ReadLine();
            bool valid = long.TryParse(text, out long num);
            if (!valid)
            {
                Console.WriteLine("Entered text '{0}' is not a valid number...", text);
                System.Environment.Exit(1);
            }

            // Find out if it's a prime number
            if (num == 0 || num == 1)
            {
                Console.WriteLine("{0} is a prime number", num);
                System.Environment.Exit(1);
            }

            for (int i = 2; i <= num - 1; i++)
            {
                
                if (i % 1000000 == 0)
                {
                    Console.WriteLine(i);
                    nums.Add(i);
                }


                if (num % i == 0)
                {
                    Console.WriteLine("Not a prime number. It's divisable by: {0}", i);
                    Console.WriteLine("Prozkoumano '{0}' cisel", nums.Count);
                    System.Environment.Exit(1);
                }
            }

            Console.WriteLine("{0} is a prime number", num);
            Console.WriteLine("Prozkoumano '{0}' cisel", nums.Count * 1000000);
            Console.Read();
        }
    }
}