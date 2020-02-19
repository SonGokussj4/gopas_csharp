using System;

namespace Array
{
    struct Employee
    {
        public string FirstName;
        public string LastName;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //int[] list;
            //int[] list = new int[4];
            //list[0] = 10;
            //list[1] = 20;
            //list[2] = 30;
            //list[3] = 40;

            int[] list = { 10, 20, 30, 40 };

            foreach (int item in list)
            {
                Console.WriteLine("Item: {0}", item);
            }

            ////////////////////
            // KOMPLEXNI POLE //
            ////////////////////

            Employee[] employees = new Employee[2];

            // Naplnit pole
            for (int i = 0; i < employees.Length; i++)
            {
                Console.Write("Enter a First Name: ");
                employees[i].FirstName = Console.ReadLine();
                Console.Write("Enter a Last Name: ");
                employees[i].LastName = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("List of Employees");
            foreach (Employee item in employees)
            {
                Console.WriteLine("FirstName: '{0}'; LastName: '{0}'",
                    item.FirstName, item.LastName);
            }

            //Enter a First Name: Jan
            //Enter a Last Name: Verner
            //Enter a First Name: Petr
            //Enter a Last Name: Tinka

            //List of Employees
            //FirstName: 'Jan '; LastName: 'Jan '
            //FirstName: 'Petr'; LastName: 'Petr'

            ///////////////////////
            // Vicerozmerne pole //
            ///////////////////////
            

        }
    }
}