using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class positiveneg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("check positive or negative a number: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
                Console.WriteLine("number is positive " + n);
            else if (n < 0)
                Console.WriteLine("number is negative " + n);
            else
                Console.WriteLine("number is zero ");
            Console.ReadKey();
        }
    }
}
