using System;

namespace AllOfCSharp
{
    abstract class Shape
    {
        public double width;
        public double height;
        public abstract double Area();
    }

    class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return 0.5 * (width * height);
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return width * height;
        }
    }

    class Abstraction
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction Example");
            Triangle triangle = new Triangle(10, 20);
            Console.WriteLine("Area of triangle = {0}", triangle.Area());

            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine("Area of rectangle = {0}", rectangle.Area());

            Console.ReadLine();
        }
    }
}
