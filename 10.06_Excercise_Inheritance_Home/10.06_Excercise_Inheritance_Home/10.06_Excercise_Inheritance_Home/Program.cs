using System;
using System.Collections.Generic;

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

        public virtual int Povrch()
        {
            return 0;
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
            //this.Area = this.A * this.B;  
            // pouzivat jen kdyz by to byl mrte komplikovany vypocet, 
            // bude zabirat VIC pameti, 
            // kdyz zmenim stav objektu, musim pamatovat na zmenu this.Area - prepocitat
        }

        public override string Report()
        {
            return $"Rectangle plocha: {this.Povrch()} mm";
        }

        public override int Povrch()
        {
            //return this.A * this.B;
            return Rectangle.Povrch(this.A, this.B);  // vyuziju staticke metody
        }

        public static int Povrch(int a, int b)
        {
            return a * b;
        }
    }
    /// <summary>
    /// Class of 3D Box, inheriting (A, B) from 'Rectangle', overriding 'Report()' method
    /// </summary>
    internal class Box: Shape
    {
        public int A;
        public int B;
        public int C;
        public List<Shape> rectangles = new List<Shape>();

        public Box(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;

            this.rectangles.Add(ShapeManager.MakeRectange(this.A, this.B));
            this.rectangles.Add(ShapeManager.MakeRectange(this.A, this.B));
            this.rectangles.Add(ShapeManager.MakeRectange(this.A, this.B));
            //List<Shape> rectangles = new List<Shape>
            //{
            //    ShapeManager.MakeRectange(this.A, this.B),
            //    ShapeManager.MakeRectange(this.A, this.C),
            //    ShapeManager.MakeRectange(this.B, this.C),
            //};
            //this.Area = (2 * this.A * this.B) + (2 * this.A * this.C) + 2 * (this.B * this.C);
        }

        public override string Report()
        {
            return $"Box plocha: {this.Povrch()} mm2";
        }

        public override int Povrch()
        {
            return 2 * (this.rectangles[0].Povrch() + this.rectangles[1].Povrch() + this.rectangles[2].Povrch());
            //int povrch = 0;
            //foreach (Rectangle item in rectangles)
            //{
            //    Console.WriteLine(item.Povrch());
            //    povrch += item.Povrch();
            //}
            //return povrch;
        }

        public static int Povrch(int a, int b, int c)
        {
            return (2 * a * b) + (2 * a * c) + 2 * (b * c);
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
            List<Shape> shapes = new List<Shape>
            //System.Collections.ArrayList shapes = new System.Collections.ArrayList  // Lepsi List (je typovy) nez ArrayList
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