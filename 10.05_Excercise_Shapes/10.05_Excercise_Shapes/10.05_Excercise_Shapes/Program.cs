using System;

namespace _10._05_Excercise_Shapes
{
    class Shape
    {

    }

    class Obdelnik : Shape
    {
        private int a;
        private int b;

        public Obdelnik(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int GetPovrch()
        {
            return this.a * this.b;
        }
    }

    class Kvadr : Obdelnik
    {
        private int a;
        private int b;
        private int c;

        public Kvadr(int a, int b, int c) : base(a, b)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int GetPovrch()
        {
            return 2 * (this.a * this.b) + 2 * (this.a * this.c) + 2 * (this.b * this.c);
        }
    }

    class ShapeManager
    {   
        public static void PrintPovrch(Obdelnik shape)
        {
            if (shape == null) return;

            Console.WriteLine($"Shape is... {shape.GetPovrch()}");
        }

        public static void PrintPovrch(Kvadr shape)
        {
            if (shape == null) return;

            Console.WriteLine($"Shape is... {shape.GetPovrch()}");
        }

        public static Obdelnik MakeObdelnik(int a, int b)
        {
            Obdelnik obdelnik = new Obdelnik(a, b);

            return obdelnik;
        }

        public static Kvadr MakeKvadr(int a, int b, int c)
        {
            Kvadr kvadr = new Kvadr(a, b, c);

            return kvadr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList shapes = new System.Collections.ArrayList();

            shapes.Add(ShapeManager.MakeObdelnik(2, 3));
            shapes.Add(ShapeManager.MakeKvadr(2, 5, 6));

            foreach (var shape in shapes)
            {
                if (shape is Obdelnik)
                {
                    ShapeManager.PrintPovrch((Obdelnik)shape);
                }
                else
                {
                    ShapeManager.PrintPovrch((Kvadr)shape);
                }
            }
        }
    }
}
