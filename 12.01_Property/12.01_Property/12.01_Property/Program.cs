using System;

namespace _12._01_Property
{
    class Fish
    {
        private int _weight;

        public int Weight
        {
            get { return this._weight; }
            set 
            { 
                if (value <= 0) {
                    throw new InvalidOperationException("Invalid value");
                }
                _weight = value; 
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish();
            fish.Weight = -020;
            Console.WriteLine($"Fish weight: {fish.Weight}");
        }
    }
}
