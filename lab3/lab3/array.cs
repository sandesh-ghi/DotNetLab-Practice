// 1. Write a C# program to find sum of array elements of size n 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class array
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter array elements: " + n);

            for (int i = 0; i < n; i++)
            {
                Console.Write(" Element"  + ( i + 1 )+  ":");
                array[i] = int.Parse(Console.ReadLine());

            }


            int sum = CalculateSum(array);

            Console.WriteLine("Sum of the array element: " + sum);

        }
        public static int CalculateSum(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }
    }
}
