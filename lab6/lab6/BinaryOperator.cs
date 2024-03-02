using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Binary
    {  
class Number
    {
        private int value;

        public Number(int value)
        {
            this.value = value;
        }
        public static Number operator *(Number num1, Number num2)
        {
            return new Number(num1.value * num2.value);
        }
        public static Number operator /(Number num1, Number num2)
        {
            if (num2.value == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return new Number(num1.value / num2.value);
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
            Number num1 = new Number(30);
            Number num2 = new Number(2);
            Number product = num1 * num2;
            Console.WriteLine("Binary operator (*) overloading: " + product);
            Number quotient = num1 / num2;
            Console.WriteLine("Binary operator (/) overloading: " + quotient);
        }
    }

}
}
