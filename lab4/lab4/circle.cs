using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class circle
    {
        class Circle
        {
            private float radius;
            public Circle()
            {
                radius = 1.0f;
            }
            public Circle(float r)
            {
                radius = r;
            }
            public float FindArea()
            {
                return (float)(Math.PI * radius * radius);
            }

            public float FindCircumference()
            {
                return (float)(2 * Math.PI * radius);
            }
        }
        class Myclass
        {
            static void Main()
            {
                Circle circle1 = new Circle(5.7f);
                Console.WriteLine($"Area: {circle1.FindArea():F2}");
                Console.WriteLine($"Circumference: {circle1.FindCircumference():F2}");


                Circle circle2 = new Circle(3.0f);   
                Console.WriteLine($"Area: {circle2.FindArea():F2}");
                Console.WriteLine($"Circumference: {circle2.FindCircumference():F2}");
            }
        }
    }
}
