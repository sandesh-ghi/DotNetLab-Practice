using System;
using System.Collections.Generic;

namespace lab6
{
    class StackExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack<T>:");

            // Create a new stack
            Stack<string> myStack = new Stack<string>();

            // Get input from the user
            Console.WriteLine("Enter elements to push onto the stack (type 'done' to finish):");

            // Keep taking input until the user types 'done'
            string input;
            while ((input = Console.ReadLine().ToLower()) != "done")
            {
                // Push the input onto the stack
                myStack.Push(input);
            }

            // Pop and display elements from the stack
            Console.WriteLine("Popping elements from the stack:");

            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }
        }
    }
}
