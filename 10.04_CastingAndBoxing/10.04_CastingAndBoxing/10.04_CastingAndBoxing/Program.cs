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

            // Explicit casting up (musi vzdy jit, je to stejne, jen vic rozepsane)
            animal = (Animal)fish;
            animal = (Animal)cat;

            //// Implicit casting down (Implicitni dolu nejde...)
            //cat = animal;
            //fish = animal;

            // Explicit casting down (Explicitni jit muze a nemusi)
            //if (animal is Cat)
            //{
            //    cat = (Cat)animal;
            //    Console.WriteLine("Casted to Cat");
            //}
            //else
            //{
            //    Console.WriteLine("Can't cast to Cat");
            //}

            //if (animal is Fish)
            //{
            //    fish = (Fish)animal;
            //    Console.WriteLine("Casted to Fish");
            //}
            //else
            //{
            //    Console.WriteLine("Can't cast to Fish");
            //}

            cat = animal as Cat;
            if (cat == null)
            {
                Console.WriteLine("Can't cast to Cat");
            }
            
            fish = animal as Fish;
            if (fish == null)
            {
                Console.WriteLine("Can't cast to Fish");
            }
        }
    }
}
