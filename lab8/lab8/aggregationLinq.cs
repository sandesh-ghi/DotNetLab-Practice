using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class aggregationLinq;

class aggregation
        {
            static void Main(string[] args)
            {
                // Ask the user for the number of elements in the list
                Console.Write("Enter the number of elements in the list: ");
                int numElements = int.Parse(Console.ReadLine());

                // Create a list to store the numbers
                List<int> numbers = new List<int>();

                // Input numbers from the user
                for (int i = 0; i < numElements; i++)
                {
                    Console.Write($"Enter element {i + 1}: ");
                    int num = int.Parse(Console.ReadLine());
                    numbers.Add(num);
                }

                // Count: Counts the number of elements in the collection
                int count = numbers.Count();
                Console.WriteLine("Count: " + count);

                // Sum: Computes the sum of the numeric values in the collection
                int sum = numbers.Sum();
                Console.WriteLine("Sum: " + sum);

                // Min: Returns the minimum value in the collection
                int min = numbers.Min();
                Console.WriteLine("Min: " + min);

                // Max: Returns the maximum value in the collection
                int max = numbers.Max();
                Console.WriteLine("Max: " + max);

                // Average: Computes the average of the numeric values in the collection
                double average = numbers.Average();
                Console.WriteLine("Average: " + average);

                // Aggregate: Performs a custom aggregation operation on the collection
                int product = numbers.Aggregate((acc, x) => acc * x);
                Console.WriteLine("Product: " + product);
            }
        }
    }

