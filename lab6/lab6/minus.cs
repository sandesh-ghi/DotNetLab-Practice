using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    using System;

    class Number
    {
        private int value;

        public Number(int value)
        {
            this.value = value;
        }
        public static Number operator -(Number num)
        {
            return new Number(-num.value);
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }

    class minus
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int inputValue))
            {
                Number num = new Number(inputValue);
                Number negativeNum = -num;
                Console.WriteLine("Unary minus (-) operator: " + negativeNum);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            
        }
    }

}
