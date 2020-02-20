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

    class PersianCat : Cat
    {
        public override string MakeSound()
        {
            return $"{base.MakeSound()} {base.MakeSound()}";
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

            PersianCat persianCat = new PersianCat();
            Console.WriteLine($"PersianCat zvuk: {persianCat.MakeSound()}");

        }
    }
}
