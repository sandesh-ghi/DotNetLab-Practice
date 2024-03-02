using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Teacher2
{
    public void Eat()
    {
        Console.WriteLine("Teacher2 is eating");
    }
}

class Student2 : Teacher2
{
    public void Sleep()
    {
        Console.WriteLine("student is sleeping");
    }
}

class anand : Student2
{
    public void sit()
    {
        Console.WriteLine("anand is sitting");
    }

    static void Main()
    {
        anand anand = new anand();
        anand.Eat();   
        anand.Sleep();
        anand.sit();  
        Console.ReadKey();
    }
}
