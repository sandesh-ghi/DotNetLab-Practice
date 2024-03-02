using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{

    internal class SingleCastDelegateEx
    {
        public static int square(int num)
        {
            return num * num;
        }
        public delegate int squareDelegate(int x);
        public static void Main(String[] args)
        {
            squareDelegate del = new squareDelegate(square);
            Console.WriteLine("Square of 4 is: " + del.Invoke(4));
            Console.ReadKey();
        }
    }
}