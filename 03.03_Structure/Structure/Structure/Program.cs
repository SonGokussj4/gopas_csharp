using System;

namespace Structure
{
    struct Company
    {
        public string CompanyName;
        public int NumEmployees;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Structure!");
            
            Company Evektor;
            Evektor.CompanyName = "Evektor s r.o.";
            Evektor.NumEmployees = 300;

            string text = string.Format("Jmeno nasi spolecnosti je: {0}", Evektor.CompanyName);
            Console.WriteLine(text);


        }
    }
}
