using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class amstrongnum
    {
        public static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.Write("Check the Number is Armstrong or not:  ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Given number is Armstrong number.\n ");
            else
                Console.Write("Given number is Not Armstrong Number. \n");
        }
    }
}


