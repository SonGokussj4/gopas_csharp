using System;

namespace _07._02_Static
{
    class MyClass
    {
        public int InstanceMember;
        public static int StaticMember;

        public int GetStaticValue()
        {
            return MyClass.StaticMember;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            mc.InstanceMember = 42;
            //mc.StaticMember = 100;
            MyClass.StaticMember = 100;

            MyClass mc1 = new MyClass();
            MyClass mc2 = new MyClass();

            mc1.InstanceMember = 1;
            mc2.InstanceMember = 2;

            Console.WriteLine("mc1: InstanceMember = {0}, staticMember = {1}",
                mc1.InstanceMember, mc1.GetStaticValue());
            Console.WriteLine("mc2: InstanceMember = {0}, staticMember = {1}",
                mc2.InstanceMember, mc2.GetStaticValue());
        }
    }
}