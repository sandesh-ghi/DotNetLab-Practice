using System;
using System.Collections.Generic;

namespace lab6
{
    class queue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue<T>:");

            // Prompt user for the number of elements in the queue
            Console.Write("Enter the number of elements in the queue: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            Queue<double> myQueue = new Queue<double>();

            // Prompt user to enter each element for the queue
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                double element = double.Parse(Console.ReadLine());
                myQueue.Enqueue(element);
            }

            Console.WriteLine("Dequeuing elements from the queue:");
            while (myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
        }
    }
}
