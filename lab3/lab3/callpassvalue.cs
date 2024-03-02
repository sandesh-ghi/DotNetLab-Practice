// 6. Write a C# program to illustrate the concept of parameter pass by value and pass by reference.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class callpassvalue
    {
        public static void Main(string[] args)
        {
            int valueParameter = 10;
            Console.WriteLine("Original value before method call (Pass by Value): " + valueParameter);

            // Pass by Value
            PassByValue(valueParameter);
            Console.WriteLine("Value after method call (Pass by Value): " + valueParameter);

            int referenceParameter = 20;
            Console.WriteLine("\nOriginal value before method call (Pass by Reference): " + referenceParameter);

            // Pass by Reference
            PassByReference(ref referenceParameter);
            Console.WriteLine("Value after method call (Pass by Reference): " + referenceParameter);
        }

        static void PassByValue(int value)
        {
            // Modifying the parameter (does not affect the original value)
            value = 100;
            Console.WriteLine("Inside PassByValue method: " + value);
        }

        static void PassByReference(ref int reference)
        {
            // Modifying the parameter (affects the original value)
            reference = 200;
            Console.WriteLine("Inside PassByReference method: " + reference);
        }
    }
}
    
