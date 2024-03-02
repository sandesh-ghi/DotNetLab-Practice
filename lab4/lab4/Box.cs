using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Box
   
        {
            private double width1;
            private double height1;
            private double depth1;
            private double length1;


            public Box(double width, double height, double depth, double length)
            {
                width1 = width;
                height1 = height;
                depth1 = depth;
                length1 = length;
            }

            public double CalculateVolume()
            {
                return width1 * height1 * depth1;
            }

            public double CalculateSurfaceArea()
            {
                // Surface area = 2*(lw + lh + wh)
                return 2 * (width1 * height1 + length1 * height1 + width1 * depth1);
            }
        }

        class test
        {
            static void Main()
            {
                Box box1 = new Box(5, 3, 4, 5);
                Box box2 = new Box(7, 2, 6, 4);

                double volume1 = box1.CalculateVolume();
                double surfaceArea1 = box1.CalculateSurfaceArea();

                double volume2 = box2.CalculateVolume();
                double surfaceArea2 = box2.CalculateSurfaceArea();

                Console.WriteLine($"Box 1 - Volume: {volume1}, Surface Area: {surfaceArea1}");
                Console.WriteLine($"Box 2 - Volume: {volume2}, Surface Area: {surfaceArea2}");
            }
        }
    }


