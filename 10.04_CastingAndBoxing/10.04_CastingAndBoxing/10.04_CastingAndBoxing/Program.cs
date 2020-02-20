using System;

namespace _10._04_CastingAndBoxing
{
    class Animal { }
    class Fish : Animal { }
    class Cat : Animal { }
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish();
            Cat cat = new Cat();

            Animal animal;

            // Implicit casting up (melo by vzdy jit)
            animal = fish;
            animal = cat;

            
        }
    }
}
