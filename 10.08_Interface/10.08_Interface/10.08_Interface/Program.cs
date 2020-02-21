﻿using System;

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

        public string ToLowerCase()
        {
            return this.ToString().ToLower();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
