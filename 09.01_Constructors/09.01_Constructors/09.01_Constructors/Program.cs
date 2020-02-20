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
        public readonly int DaysInMonth;

        //public Date()
        //{
        //    this.Day = 1;
        //    this.Month = 1;
        //    this.Year = 1970;
        //}
        public Date() : this(1, 1, 1980) { }  // Prazdny body, referuji se ale na jiny konstruktor
        public Date(int Day, int Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
            this.DaysInMonth = DateTime.DaysInMonth(this.Year, this.Month);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            Console.WriteLine(mc.i);

            Date d = new Date(31, 12, 2015);
            Console.WriteLine($"{d.Day:D2}.{d.Month:D2}.{d.Year:D4} ... {d.DaysInMonth} days");
            
            Date d2 = new Date();
            Console.WriteLine($"{d2.Day:D2}.{d2.Month:D2}.{d2.Year:D4} ... {d2.DaysInMonth} days");
        }
    }
}