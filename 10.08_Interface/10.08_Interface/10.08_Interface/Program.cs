using System;

namespace _10._08_Interface
{
    interface IStringConvertible
    {
        string ToUpperCase();
        string ToLowerCase();
    }

    class MyClass : IStringConvertible
    {
        public string ToLowerCase()
        {
            return "aBcD".ToUpper();
        }

        public string ToUpperCase()
        {
            return "aBcD".ToLower();
        }
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

            //ShowConverted((IStringConvertible)employee);  // explicitne
            ShowConverted(employee);  // implicitne
        }

        /// <summary>
        /// Vezme libovolny objekt implementujici interface IConvertible a pomoci interface ho pouzije
        /// Je jedno, jakou instanci dostane, jedina podminka - instance musi implementovat
        /// pozadovany interface.
        /// </summary>
        /// <param name="StringConvertible"></param>
        static void ShowConverted(IStringConvertible StringConvertible)
        {
            Console.WriteLine($"ShowConverted: {StringConvertible.ToUpperCase()}");
        }
    }
}
