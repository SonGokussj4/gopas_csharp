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

        public override string ToString()
        {
            return $"FirstName --> '{this.FirstName}', LastName --> '{this.LastName}'";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ferda", "Mravenec");
            Console.WriteLine(employee.ToString());  // vypise FirstName --> 'Ferda', LastName --> 'Mravenec'
        }
    }
}
