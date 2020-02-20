using System;
using System.Text;

namespace _10._04_CastingAndVirtualMethods
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
            StringBuilder s = new StringBuilder();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            for (int i = 0; i < 10; i++)
            {
                //s.Append(string.Format("{0} ", base.MakeSound()));  // 93 ms
                //s.Append($"{base.MakeSound()} ");  // 35 ms
                s.Append(base.MakeSound());
                s.Append(" ");  // 15 ms
            }
            sw.Stop();
            //return $"{base.MakeSound()} {base.MakeSound()}";
            return $"{s.ToString().Trim()} ... {sw.ElapsedMilliseconds} ms";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Fish fish = new Fish();
            //Cat cat = new Cat();

            //Console.WriteLine($"Fish sound: {fish.MakeSound()}");
            //Console.WriteLine($"Cat sound: {cat.MakeSound()}");

            //PersianCat persianCat = new PersianCat();
            //// ONE MILLION YOWS
            //Console.WriteLine($"PersianCat sound: {persianCat.MakeSound()}");

            Animal[] animals = new Animal[3];

            animals[0] = (Animal)new Fish();  // Lze: new Fish();
            animals[1] = (Animal)new Cat();  // Lze: new Cat();
            animals[2] = (Animal)new PersianCat();  // Lze: new PersianCat();

            // Pole mame sice typu Animal... Ale vkladame do nej typ "Cat", "Fish", ...

            foreach (Animal item in animals)
            {
                Console.WriteLine(item.MakeSound());
            }
        }

    }
}


