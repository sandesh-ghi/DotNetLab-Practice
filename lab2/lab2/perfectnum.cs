using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class perfectnum
    {
        public static void Main(string[] args)
        {
            int number, sum = 0, n;
            Console.Write("Enter the Number perfect or not: ");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n given number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n given number is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}

