using System;
using System.Collections.Generic;

namespace lab6
{
    class DictionaryExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary<TKey, TValue>:");

            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            // Take input from the user for the number of elements
            Console.Write("Enter the number of elements to insert: ");
            int numberOfElements;

            // Validate and parse the user input for the number of elements
            while (!int.TryParse(Console.ReadLine(), out numberOfElements) || numberOfElements <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer for the number of elements.");
                Console.Write("Enter the number of elements again: ");
            }

            // Loop to input key-value pairs based on the user's specified number of elements
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write($"Enter key #{i + 1}: ");
                string key = Console.ReadLine();

                Console.Write($"Enter value #{i + 1}: ");
                int value;

                // Validate and parse the user input for the value
                while (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for the value.");
                    Console.Write($"Enter value #{i + 1} again: ");
                }

                // Add the key-value pair to the dictionary
                myDictionary.Add(key, value);
            }

            // Display the dictionary contents
            Console.WriteLine("\nDictionary Contents:");
            foreach (KeyValuePair<string, int> item in myDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
