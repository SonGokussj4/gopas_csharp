using System;

namespace _07_01_Class
{
    //struct Employee
    class Employee
    {
        public string FirstName;
        public string LastName;
        private decimal Salary;

        public decimal GetSalary()
        {
            return this.Salary;
        }
        public void SetSalary(decimal salary)
        {
            this.Salary = salary;
        }
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
            employee1.SetSalary(10000000);

            Console.WriteLine("Salary of employee '{0}' is '{1}'", 
                employee1.FirstName + " " + employee1.LastName, employee1.GetSalary());
        }
    }
}