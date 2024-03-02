using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{

    internal class AnonymousMethodEx
    {
        public delegate int addDelegate(int x, int y);
        public static void Main(string[] args)
        {
            addDelegate del = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine("Sum of two numbers= " + del.Invoke(3, 5));
            Console.ReadKey();
        }
    }
}