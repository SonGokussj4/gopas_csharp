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
        public Cat() : base()
        {
            this.NumberOfLegs = 4;
        }
    }

    class Spider: Animal
    {
        public Spider() : base()
        {
            this.NumberOfLegs = 8;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Spider spider = new Spider();

            cat.Name = "Micka";
            //cat.NumberOfLegs = 4;

            spider.Name = "Odula";
            //spider.NumberOfLegs = 8;

            Console.WriteLine($"Pocet nohou kocky [{cat.Name}]: {cat.NumberOfLegs}");
            Console.WriteLine($"Pocet nohou pavouka [{spider.Name}]: {spider.NumberOfLegs}");
        }
    }
}
