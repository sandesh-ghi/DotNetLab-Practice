using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check odd or even number: ");
            int a = int.Parse(Console.ReadLine());
            if (a / 2 == 0)
                Console.WriteLine("number is even " + a);
            else
                Console.WriteLine("number is odd " + a);

            Console.WriteLine();
        }
    }
}
