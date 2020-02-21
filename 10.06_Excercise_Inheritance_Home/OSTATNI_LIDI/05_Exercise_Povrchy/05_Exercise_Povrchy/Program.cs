using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Exercise_Povrchy
{
    class Tvar
    {
        public Tvar()
        {

        }

        public virtual int Povrch()
        {
            return 0;
        }
    }

    class Obdelnik : Tvar
    {
        protected int stranaA;
        protected int stranaB;

        public Obdelnik(int a, int b) 
        {

            this.stranaA = a;
            this.stranaB = b;
        }

        public override int Povrch()
        {
            return this.stranaA * this.stranaB;
        }

    }

    class Kvadr : Obdelnik
    {
        int stranaC;

        public Kvadr(int a, int b, int c) : base(a,b)
        {
            this.stranaC = c;
        }

        public override int Povrch()
        {
            return (2 * base.Povrch()) + (2 * this.stranaA * this.stranaC) + (2 * this.stranaB * this.stranaC); 
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Tvar> tvary = new List<Tvar>();

            Obdelnik obdelnik1 = new Obdelnik(10, 20);
            Obdelnik obdelnik2 = new Obdelnik(30, 40);
            Kvadr kvadr = new Kvadr(20, 30, 40);

            tvary.Add(obdelnik1);
            tvary.Add(kvadr);
            tvary.Add(obdelnik2);

            foreach (Tvar item in tvary)
            {
                Console.WriteLine(item.Povrch());
            }
        }
    }
}
