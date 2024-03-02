using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class NaturalNumCube
    {
        public static void Main(string[] args)
        {
            int n;
            int i = 1;
            int result;

            Console.Write("Enter the value of n: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                goto End;
            }

        Start:
            result = i * i * i;
            Console.WriteLine($"Cube of {i} = {result}");

            i++;

            if (i <= n)
                goto Start;

            End:
            Console.WriteLine(" ");
        }
    }
}
