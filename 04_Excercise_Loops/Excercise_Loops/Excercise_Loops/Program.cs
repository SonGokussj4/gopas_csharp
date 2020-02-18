using System;

namespace Excercise_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Multiplication of number: ");
            //string response = Console.ReadLine();

            bool valid = int.TryParse(Console.ReadLine(), out int num);

            if (!valid)
            {
                Console.WriteLine("Not a number...");
                System.Environment.Exit(1);
            }

            if (num <= 0 || num > 10)
            {
                Console.WriteLine("Number is num not between 1-10");
                System.Environment.Exit(1);
            }
            
            for (int multiplicator = 1; multiplicator <= 10; multiplicator++)
            {
                Console.WriteLine("{0} * {1} = {2}", multiplicator, num, multiplicator * num);
            }   
        }
    }
}
