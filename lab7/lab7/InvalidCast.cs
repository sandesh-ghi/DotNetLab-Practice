using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class InvalidCast
    {
        public static void Main(string[] args)
        {
            try
            {
                Object obj = new Object();
                obj = 7;
                System.Console.WriteLine("Unboxing the object");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadKey();
        }
    }
}
