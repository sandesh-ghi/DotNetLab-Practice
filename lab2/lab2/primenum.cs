using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class primenum
    {
        static void Main(string[] args)
        {
            Console.Write("check a Number is prime or not : ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write("Given Number is Prime.");
            }
            else
            {
                Console.Write("Given Number is not Prime.");
            }
            Console.ReadKey();
        }
    }
}
