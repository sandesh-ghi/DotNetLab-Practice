//5. Write a C# program to declare and initialize jagged array and also display the array element. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class jagged
    {
        public static void Main(string[] args)
        {
            // Declare and initialize a jagged array
            int[][] jaggedArray = new int[][]
            {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6, 7 },
            new int[] { 8, 9 }
            };

            // Display the jagged array
            Console.WriteLine("Jagged Array:");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row " + (i + 1) + ": ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
