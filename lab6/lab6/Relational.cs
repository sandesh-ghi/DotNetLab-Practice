using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Relational
    {
    class Number
    {
        private int value;
        public Number(int value)
        {
            this.value = value;
        }
        public static bool operator ==(Number num1, Number num2)
        {
            return num1.value == num2.value;
        }
        public static bool operator !=(Number num1, Number num2)
        {
            return !(num1 == num2);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Number))
            {
                return false;
            }
            return this.value == ((Number)obj).value;
        }
        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }

    class Operator
    {
        static void Main(string[] args)
        {
                // Taking input from the user
                Console.Write("Enter the first number: ");
                int num1Value = int.Parse(Console.ReadLine());
                Number num1 = new Number(num1Value);

                Console.Write("Enter the second number: ");
                int num2Value = int.Parse(Console.ReadLine());
                Number num2 = new Number(num2Value);

                // Using overloaded operators
                Console.WriteLine("Relational operator (==) overloading: " + (num1 == num2));
                Console.WriteLine("Relational operator (!=) overloading: " + (num1 != num2));
            }
        }

    }
}
