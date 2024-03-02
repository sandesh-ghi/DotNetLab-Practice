using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
   
    internal class IndexOutOfRange
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1, 2, 3, 4, 5,6 };
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadKey();
        }
    }
}