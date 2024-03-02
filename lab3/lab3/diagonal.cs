//3. Write a C# program to find sum of diagonal element of 3x3 matrix. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class diagonal
 

    {
        public static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            Console.WriteLine("Enter the element of the 3X3 matrix: ");

            for (int i = 0; i<3; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    Console.WriteLine("Element" +(i+1,j+1) +":");
                    matrix[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("\nThe matrix is: ");

            for (int i = 0; i<3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(matrix[i, j] + " \t ");
                }
                Console.WriteLine();
            }

            int diagonalSum = FindDiagonalSum(matrix);
            Console.WriteLine("\nSum of diagonal element:" + diagonalSum);

        }
        public static int FindDiagonalSum(int[,] mat)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += mat[i, i];
            }
            return sum;
        }
    }
}
