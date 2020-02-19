using System;
using System.Collections;

namespace _06_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("deset");

            Console.WriteLine("{0} .. {1}", list[0], list[1]);

        }
    }
}
