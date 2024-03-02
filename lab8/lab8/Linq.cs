using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Linq
    {
        static void Main(string[] args)
        {
            // Define a list of numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // LINQ query to select odd and divisible by 3 numbers
            var selectedNumbers = from num in numbers
                                  where num % 2 != 0 && num % 3 == 0
                                  select num;

            // Display the selected numbers
            Console.WriteLine("Odd and divisible by 3 numbers:");
            foreach (var num in selectedNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

