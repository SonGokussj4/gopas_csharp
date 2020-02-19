using System;
using System.Collections;
using System.Collections.Generic;

namespace _06._02_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Toto byl stary "Array"
            //int[] list = { 10, 20, 30 };
            //Console.WriteLine(list.ToString()); 

            //// NEW ARRAYLIST
            //ArrayList list = new ArrayList();

            //// JESTE VIC NEW LIST z GENERIC - typove bezpecnejsi
            List<int> list = new List<int>();

            list.Add(10);
            list.Add(20);
            list.Add(30);

            // Odstranim dvacitku
            list.Remove(20);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
            // Pridam cislo
            Console.Write("Enter a number: ");
            list.Add(int.Parse(Console.ReadLine()));  // musel jsem pridat int.Parse, by to str --> int

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


        }
    }
}
