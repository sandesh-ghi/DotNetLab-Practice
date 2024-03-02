//4. Write a C# program to compute multiplication of two 3x3 matrix and display resultant matrix.
using System;

namespace lab3
{
    internal class multymat
    {
        public static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            int row = 3;
            int col = 3;

            int[,] Matrix1 = new int[row, col];
            int[,] Matrix2 = new int[row, col];
            int[,] Matrix3 = new int[row, col];

            Console.Write("Enter the elements of matrix1" +":\n");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\nEnter the elements of matrix2"+":\n");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Matrix3[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        Matrix3[i, j] += Matrix1[i, k] * Matrix2[k, j];
                    }
                }
            }


            Console.WriteLine("\nMatrix1: ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(Matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatrix2: ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(Matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n Result Matrix3: ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(Matrix3[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
