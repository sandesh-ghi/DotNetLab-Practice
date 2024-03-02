// 2. Write a C# program to find minimum and maximum element from 1-D array of size n

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class minmax
    {

        public static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter the array elements: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int min = FindMinElement(array);
            int max = FindMaxElement(array);

            Console.WriteLine("\nMinimum element: " + min);
            Console.WriteLine("Maximum element: " + max);
        }

        static int FindMinElement(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        static int FindMaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
