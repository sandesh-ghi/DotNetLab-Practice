using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Shape
    {  
        public virtual double CalculateArea()
        {
            return 0;
        }
    }
    class Rectangle : Shape
    { 
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

    class Circle : Shape
    { 
        public double Radius { get; set; }  
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class overriding
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 4);
            Circle circle = new Circle(5);           
            Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
            Console.WriteLine("Area of Circle: " + circle.CalculateArea());
        }
    }

}

