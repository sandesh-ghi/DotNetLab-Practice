using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class sumnegnum
    {
        public static void Main(string[] args)
        {
            int sum = 0,number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i <number; i++)
            {
             int num= Convert.ToInt32(Console.ReadLine());
                if (number >= 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine("Sum of negative numbers: " + sum);
        }
    }
}
