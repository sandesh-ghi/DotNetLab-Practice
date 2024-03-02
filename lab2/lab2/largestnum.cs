using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class largestnum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:  ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:  ");

            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:  ");

            int c = int.Parse(Console.ReadLine());
            if (a > b)
                if (a > c)
                    Console.WriteLine("Given number is largest: " + a);
                else
                    Console.WriteLine("Given number is largest: " + b);
            else
                if (b > c)
                Console.WriteLine("Given number is largest: " + b);
            else
                Console.WriteLine("Given number is largest:  " + c);

        }
    }
}
