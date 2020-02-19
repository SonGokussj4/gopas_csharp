using System;

namespace _07_01_Class
{
    //struct Employee
    class Employee
    {
        public string FirstName;
        public string LastName;
        public decimal Salary;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Employee employee1;
            //employee1 = new Employee();
            Employee employee1 = new Employee();

            employee1.FirstName = "Jan";
            employee1.LastName = "Verner";
            employee1.Salary = 100000000;
        }
    }
}