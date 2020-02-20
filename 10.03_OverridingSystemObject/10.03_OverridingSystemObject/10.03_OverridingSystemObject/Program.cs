using System;

namespace _10._03_OverridingSystemObject
{
    //class Employee
    //class Employee : System.Object
    class Employee : Object
    {
        public string FirstName;
        public string LastName;
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ferda", "Mravenec");
            Console.WriteLine(employee.ToString());  // vypise namespace nazev _10._03_OverridingSystemObject
        }
    }
}
