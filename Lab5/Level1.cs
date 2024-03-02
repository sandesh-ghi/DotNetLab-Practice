using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Teacher
{
    public void Eat()
    {
        Console.WriteLine("Teachers are eating");
    }
}

class Student :Teacher
{
    public void Sleep()
    {
        Console.WriteLine("Students are sleeping");
    }

    static void Main()
    {
       Student student = new Student();
        student.Eat();  
        student.Sleep(); 
        Console.ReadKey();
    }
}
