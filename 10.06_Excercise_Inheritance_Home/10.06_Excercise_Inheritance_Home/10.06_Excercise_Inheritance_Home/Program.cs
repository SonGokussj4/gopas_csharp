using System;

namespace _10._06_Excercise_Inheritance_Home
{
    internal class Shape
    {
        public virtual string Report()
        {
            return "Haha";
        }
    }

    internal class Rectangle : Shape
    {
        public int A;
        public int B;
        public int Area;

        public Rectangle(int a, int b)
        {
            this.A = a;
            this.B = b;
            this.Area = this.A * this.B;
        }

        public override string Report()
        {
            return $"Rectangle plocha: {this.Area} mm";
        }
    }

    internal class Box : Rectangle
    {
        public int C;

        public Box(int a, int b, int c) : base(a, b)
        {
            this.C = c;
            this.Area = (2 * this.A * this.B) + (2 * this.A * this.C) + 2 * (this.B * this.C);
        }

        public override string Report()
        {
            return $"Box plocha: {this.Area} mm2";
        }
    }

    internal class ShapeManager
    {
        public static Shape MakeRectange(int a, int b)
        {
            Rectangle rectangle = new Rectangle(a, b);
            return rectangle;
        }

        public static Shape MakeBox(int a, int b, int c)
        {
            Box box = new Box(a, b, c);
            return box;
        }

        public static string MakeReport(Shape shape)
        {
            return shape.Report();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Collections.ArrayList shapes = new System.Collections.ArrayList
            {
                ShapeManager.MakeRectange(2, 3),
                ShapeManager.MakeBox(1, 2, 3),
            };

            foreach (Shape item in shapes)
            {
                //Console.WriteLine(item.Report());
                Console.WriteLine(ShapeManager.MakeReport(item));
            }
        }
    }
}