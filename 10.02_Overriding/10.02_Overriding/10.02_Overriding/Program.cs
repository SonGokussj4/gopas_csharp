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
            //return "Mnaou";
            return "Yow";  // Anglicke Mnaou
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

            Console.WriteLine($"Fish sound: {fish.MakeSound()}");
            Console.WriteLine($"Cat sound: {cat.MakeSound()}");

            PersianCat persianCat = new PersianCat();
            Console.WriteLine($"PersianCat sound: {persianCat.MakeSound()}");

        }
    }
}
