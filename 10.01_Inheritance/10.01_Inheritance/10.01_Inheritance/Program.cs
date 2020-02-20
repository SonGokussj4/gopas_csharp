using System;

namespace _10._01_Inheritance
{
    class Animal
    {
        public int NumberOfLegs;
        public string Name;
    }

    class Cat: Animal
    {

    }

    class Spider: Animal
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Spider spider = new Spider();

            cat.Name = "Micka";
            cat.NumberOfLegs = 4;

            spider.Name = "Odula";
            spider.NumberOfLegs = 8;

            Console.WriteLine($"Pocet nohou kocky: {cat.NumberOfLegs}");
            Console.WriteLine($"Pocet nohou pavouka: {spider.NumberOfLegs}");
        }
    }
}
