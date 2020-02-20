using System;

namespace _10._01_Inheritance
{
    class Animal
    {
        public int NumberOfLegs;
        public string Name;

        public Animal(string name)
        {
            this.Name = name;
        }
    }

    class Cat: Animal
    {
        public Cat(string name) :base(name)
        {
            this.NumberOfLegs = 4;
        }
    }

    class Spider: Animal
    {
        public Spider(string name) : base(name)
        {
            this.NumberOfLegs = 8;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Micka");
            Spider spider = new Spider("Odula");

            //cat.Name = "Micka";
            //cat.NumberOfLegs = 4;

            //spider.Name = "Odula";
            //spider.NumberOfLegs = 8;

            Console.WriteLine($"Pocet nohou kocky [{cat.Name}]: {cat.NumberOfLegs}");
            Console.WriteLine($"Pocet nohou pavouka [{spider.Name}]: {spider.NumberOfLegs}");
        }
    }
}
