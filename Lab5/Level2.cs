using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Sandesh
{
    public void Read()
    {
        Console.WriteLine("Sandesh is reading");
    }
}

class sagar :Sandesh
{
    public void Sleep()
    {
        Console.WriteLine("sagar is sleeping");
    }
}

class ranjan : sagar
{
    public void Cry()
    {
        Console.WriteLine("ranjan is Crying");
    }

    static void Main()
    {
        ranjan ranjan = new ranjan();
        ranjan.Read();   
        ranjan.Sleep(); 
        ranjan.Cry();  
        Console.ReadKey();
    }
}
