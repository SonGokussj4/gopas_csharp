using System;

namespace Exceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Calculate();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nPROPAGOVANA VYJIMKA: {0}", ex.Message);
                Console.WriteLine("DETAIL: {0}", ex.StackTrace);
            }
        }

        private static void Calculate()
        {
            
            try
            {
                Console.Write("Enter A: ");
                int numberA = int.Parse(Console.ReadLine());
                
                Console.Write("Enter B: ");
                int numberB = int.Parse(Console.ReadLine());

                Console.WriteLine("{0} / {1} = {2}",
                    numberA, numberB, numberA / numberB);
            }
            catch (System.DivideByZeroException ex)
            {
                Console.WriteLine("NEJDE DELIT NULOU: {0}", ex);
                throw ex;
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine("NENI INTEGER: {0}. Pouze od '{1:n}' do '{2:n}'", ex, int.MinValue, int.MaxValue);
            }
            Console.WriteLine("Pokracuji...");

        }
    }
}