using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class DivideByZero
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter any two numbers:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Divison :" + a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadKey();
        }
    }
}