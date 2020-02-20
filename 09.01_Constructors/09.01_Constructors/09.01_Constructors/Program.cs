using System;

namespace _09._01_Constructors
{
    internal class MyClass
    {
        public int i;
    }

    internal class Date
    {
        public int Year, Month, Day;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            Console.WriteLine(mc.i);

            Date d = new Date();
            d.Day = 1;
            d.Month = 1;
            d.Year = 1970;
            Console.WriteLine($"{d.Day:D2}.{d.Month:D2}.{d.Year:D4}");
        }
    }
}