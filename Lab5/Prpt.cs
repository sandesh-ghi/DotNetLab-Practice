using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{  
    public string Name { get; set; }
}
class test
{
    static void Main()
    {     
        Person person = new Person();     
        person.Name = "pashupati sah"; 
        Console.WriteLine("Person's Name: " + person.Name);
        Console.ReadKey();
    }
}
