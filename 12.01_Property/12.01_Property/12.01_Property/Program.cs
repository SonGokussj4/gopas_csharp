using System;

namespace _12._01_Property
{
    class Fish
    {
        public int Weight;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish();
            fish.Weight = -20;
            Console.WriteLine($"Fish weight: {fish.Weight}");
        }
    }
}
