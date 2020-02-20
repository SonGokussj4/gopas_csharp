using System;

namespace _10._02_Overriding
{
    class Animal
    {
        public virtual string MakeSound()
        {
            return "";
        }

    }

    class Fish : Animal
    {

    }

    class Cat : Animal
    {
        public override string MakeSound()
        {
            return "Mnaou";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish();
            Cat cat = new Cat();

            Console.WriteLine($"Fish zvuk: {fish.MakeSound()}");
            Console.WriteLine($"Cat zvuk: {cat.MakeSound()}");

        }
    }
}
