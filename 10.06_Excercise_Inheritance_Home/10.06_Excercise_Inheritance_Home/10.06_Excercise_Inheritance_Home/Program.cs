using System;

namespace _10._06_Excercise_Inheritance_Home
{
    /// <summary>
    /// Base class of Shape
    /// </summary>
    internal class Shape
    {
        public virtual string Report()
        {
            return "Haha";
        }
    }
    /// <summary>
    /// Class of 2D Rectangle, overriding 'Report()' method
    /// </summary>
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
            // pouzivat jen kdyz by to byl mrte komplikovany vypocet, 
            // bude zabirat VIC pameti, 
            // kdyz zmenim stav objektu, musim pamatovat na zmenu this.Area - prepocitat
        }

        public override string Report()
        {
            return $"Rectangle plocha: {this.Area} mm";
        }
    }
    /// <summary>
    /// Class of 3D Box, inheriting (A, B) from 'Rectangle', overriding 'Report()' method
    /// </summary>
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
    /// <summary>
    /// Class for creating and making reports about shapes.
    /// </summary>
    internal class ShapeManager  
    {
        // Toto je object factory
        // 
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
    /// <summary>
    /// Main program
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Fill list with custom shapes
            System.Collections.ArrayList shapes = new System.Collections.ArrayList  // Lepsi List (je typovy) nez ArrayList
            {
                ShapeManager.MakeRectange(2, 3),
                ShapeManager.MakeBox(1, 2, 3),
            };

            foreach (Shape item in shapes)
            {
                Console.WriteLine(ShapeManager.MakeReport(item));
            }
        }
    }
}