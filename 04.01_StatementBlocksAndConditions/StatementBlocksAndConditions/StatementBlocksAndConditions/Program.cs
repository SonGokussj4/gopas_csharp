using System;

namespace StatementBlocksAndConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour == 12)
            {
                Console.WriteLine(string.Format("Poledne je: {0} hod", DateTime.Now.Hour));
            }
            else if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine(string.Format("Predpoledne je: {0} hod", DateTime.Now.Hour));
            }
            else
            {
                Console.WriteLine(string.Format("Poledne bylo... Odpoledne je!: {0} hod", DateTime.Now.Hour));
            }

            // Switch variant
            switch (DateTime.Now.Hour)
            {
                case var hodiny when DateTime.Now.Hour < 12:
                    Console.WriteLine(string.Format("Predpoledne je: {0} hod", DateTime.Now.Hour)); break;
                case 12:
                    Console.WriteLine(string.Format("Poledne je: {0} hod", DateTime.Now.Hour)); break;
                case var hodiny when DateTime.Now.Hour > 12:
                    Console.WriteLine(string.Format("Poledne bylo... Odpoledne je!: {0} hod", DateTime.Now.Hour)); break;
                default:
                    Console.WriteLine("Nemelo by nastat..."); break;
            }
        }
    }
}
