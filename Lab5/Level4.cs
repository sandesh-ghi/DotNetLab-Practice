using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface ISwim
{
    void Swim();
}

class ashish
{
    public void Eat()
    {
        Console.WriteLine("ashish is eating");
    }
}

class prevesh : ashish, ISwim
{
    public void Sleep()
    {
        Console.WriteLine("ashish is sleeping");
    }

    public void Swim()
    {
        Console.WriteLine("prevesh is swimming");
    }

    static void Main()
    {
        prevesh prevesh = new prevesh();
        prevesh.Eat();   
        prevesh.Sleep(); 
        prevesh.Swim();  
        Console.ReadKey();
    }
}
