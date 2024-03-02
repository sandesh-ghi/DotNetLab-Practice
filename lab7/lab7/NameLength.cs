using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class NameLength
    {
        public class collageException: ApplicationException
        {
            public static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Enter your collage name: ");
                    string name = Console.ReadLine();

                    if (name.Length > 10)
                    {
                        Console.WriteLine("name of length is more then 10: ");

                    }
                    else
                    {
                        Console.WriteLine("Name: " + name);

                    }
                }
                catch (Exception ex)
                { 
                    Console.WriteLine("Error: " +ex.Message);
                }
                finally { Console.WriteLine("end of name");
                }
            }
        }
    }
}
