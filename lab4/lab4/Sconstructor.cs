using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Sconstructor
    {



        static class MyStaticClass
        {

            private static int roll = 0;


            static MyStaticClass()
            {
                Console.WriteLine("Static constructor called!");
                roll++;
            }


            public static void PrintRoll()
            {
                Console.WriteLine($"Roll no : {roll}");
            }
        }

        class Test
        {
            static void Main()
            {

                MyStaticClass.PrintRoll();

                MyStaticClass.PrintRoll();
            }
        }

    }
}
