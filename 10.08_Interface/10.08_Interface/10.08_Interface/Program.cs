using System;

namespace _10._08_Interface
{
    interface IStringConvertible
    {
        string ToUpperCase();
        string ToLowerCase();
    }

    class Employee : IStringConvertible
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
            return $"{this.FirstName} {this.LastName}";
        }

        public string ToUpperCase()
        {
            return this.ToString().ToUpper();
        }

        //public string ToLowerCase()  // IMPLICITNI IMPLEMENTACE
        //{
        //    return this.ToString().ToLower();
        //}

        string IStringConvertible.ToLowerCase()  // EXPLICITNI IMPLEMENTACE
        {
            return this.ToString().ToLower();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jan", "Verner");
            Console.WriteLine(employee.ToString());  // Jan Verner
            //Console.WriteLine(employee.ToLowerCase());  // jan verner  // NelzeZkompilovat, protoze jsme zmenili na explicitni
            // Pretypovani 'employee' na 'IStringConvertible'
            //IStringConvertible convertible = (IStringConvertible)employee; // (IStringConvertible) se nemusi pouzit, je explicitni
            IStringConvertible convertible = employee;  // Implicitni pretypovani
            Console.WriteLine(convertible.ToLowerCase());  // jan verner
            Console.WriteLine(employee.ToUpperCase());  // JAN VERNER
        }
    }
}
