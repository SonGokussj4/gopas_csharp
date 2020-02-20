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

            // BOXING
            int a = 1;
            
            // Implicit Boxing
            object o1 = a;

            // Explicit Boxing
            object o2 = (object)a;

            //// Implicit UnBoxing
            //int b = o1;  // Cannot implicitly convert type... Missing cast?

            // Explicit UnBoxing
            int b = (int)o2;  // All ok

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            System.Collections.ArrayList listRef = new System.Collections.ArrayList();
            sw.Start();
            for (int i = 0; i < 100000000; i++)
            {
                listRef.Add("A");
            }
            sw.Stop();  // 1.5 second
            Console.WriteLine($"Add('A') ... {sw.ElapsedMilliseconds} ms");
            
            sw.Reset();

            System.Collections.ArrayList listVal = new System.Collections.ArrayList();
            sw.Start();
            for (int i = 0; i < 100000000; i++)
            {
                listVal.Add(0);  // HAS TO BE BOXED (Value type) .... SLOWER
            }
            sw.Stop();  // 8.5 second
            Console.WriteLine($"Add(0) ... {sw.ElapsedMilliseconds} ms");

            sw.Reset();
        }
    }
}
