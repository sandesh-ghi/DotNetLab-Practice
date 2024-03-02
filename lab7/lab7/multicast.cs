using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{

    internal class MultiCastDelegateEx
    {
        public static void square(int num)
        {
            Console.WriteLine("Square = " + num * num);
        }
        public static void cube(int num)
        {
            Console.WriteLine("Cube = " + num * num * num);
        }
        public delegate void multiDelegate(int x);
        public static void Main(String[] args)
        {
            multiDelegate mdel = new multiDelegate(square);
            mdel += cube;
            mdel.Invoke(3);
            Console.ReadKey();
        }
    }
}
