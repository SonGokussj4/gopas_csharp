using System;

namespace Array
{
    internal struct Employee
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

            // VYSLEDEK
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

            //int[,] myArray = { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
            int[][] myArray = {
                new int[] { 10, 20, 30 },
                new int[] { 40, 50, 60, 100 },  // pokud mam pole v poli, mohu mit nesymetricke
                new int[] { 70, 80, 90 },
            };

            for (int r = 0; r < myArray.GetLength(0); r++)
            {
                //for (int c = 0; c < myArray.GetLength(1); c++)
                for (int c = 0; c < myArray[r].GetLength(0); c++)
                {
                    //Console.WriteLine(myArray[r, c] + ", ");
                    Console.WriteLine(myArray[r][c] + ", ");
                }
            }
        }
    }
}