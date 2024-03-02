using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyCollection
{
    private string[] data = new string[5];

  
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < data.Length)
                return data[index];
            else
                return "Index out of range";
        }
        set
        {
            if (index >= 0 && index < data.Length)
                data[index] = value;
            else
                Console.WriteLine("Index out of range");
        }
    }
}

class Indxr
{
    static void Main()
    { 
        MyCollection collection = new MyCollection();
        collection[0] = "Value 1";
        collection[1] = "Value 2";
        collection[2] = "Value 3";

      
        Console.WriteLine("Value at index 0: " + collection[0]);
        Console.WriteLine("Value at index 1: " + collection[1]);
        Console.WriteLine("Value at index 2: " + collection[2]);
        Console.WriteLine("Value at index 3: " + collection[3]); 
        Console.ReadKey();
    }
}
