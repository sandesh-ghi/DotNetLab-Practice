using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }
    }
    class overloading
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Sum of 5 and 10: " + calc.Add(5, 10));
            Console.WriteLine("Sum of 10, 15 and 20: " + calc.Add( 10, 15, 20));
            Console.WriteLine("Sum of 3.5 and 2.5: " + calc.Add(3.5, 2.5));
            Console.WriteLine("Concatenated string: " + calc.Add("sandesh, ", "ghimire"));
        }
    }


}

