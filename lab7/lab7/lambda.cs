using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{

    internal class LamdaExpression
    {
        public delegate int addDelegate(int x, int y);
        public delegate double areaDelegate(double r);

        public static void Main(string[] args)
        {
            addDelegate del1 = (a, b) => (a + b);
            Console.WriteLine("Sum of two numbers= " + del1.Invoke(4, 6));

            areaDelegate del2 = rad => (3.14 * rad * rad);
            Console.WriteLine("Area of Circle=" + del2.Invoke(4.0));
            Console.ReadKey();
        }
    }
}
