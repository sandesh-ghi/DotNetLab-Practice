using System;
using System.Collections.Generic;

namespace lab6
{
    class LinkedListExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList<T> Example:");

            // Create a new LinkedList<char>
            LinkedList<char> myLinkedList = new LinkedList<char>();

            // Prompt the user to enter elements for the linked list
            Console.WriteLine("Enter elements for the linked list (type 'exit' to finish):");

            // Read input from the user until they type 'exit'
            string userInput;
            do
            {
                Console.Write("Enter an element: ");
                userInput = Console.ReadLine();

                // Check if the user wants to exit or if the input is not empty
                if (userInput.ToLower() != "exit" && !string.IsNullOrEmpty(userInput))
                {
                    // Add the character to the linked list
                    myLinkedList.AddLast(userInput[0]);
                }
            } while (userInput.ToLower() != "exit");

            // Display the elements in the linked list
            Console.WriteLine("Elements in the linked list:");
            foreach (char item in myLinkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
