using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class List
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List<T>:");
            List<int> myList = new List<int>();
            Console.WriteLine("Enter integers (Type 0 to stop): ");
            string input;

          while((input = Console.ReadLine()) != "0")
            {
                if (int.TryParse(input, out int number))
                {
                    myList.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. please entera valid input");

                }
            }
            Console.WriteLine("Enter values in the list: ");
            foreach(int item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }

}
