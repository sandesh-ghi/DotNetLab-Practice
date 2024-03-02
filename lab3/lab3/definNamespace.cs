// 7. Write a C# program to create user defined namespace and then use it in another namespace
using System;

// User-defined namespace
namespace MyNamespace
{
    // Class inside the user-defined namespace
    public class MyClass
    {
        public void DisplayMessage()
        {
            Console.WriteLine("Hello from MyNamespace!");
        }
    }
}

// Another namespace where the user-defined namespace is used
namespace AnotherNamespace
{
    class Program
    {
        static void Main()
        {
            // Creating an instance of MyClass from MyNamespace
            MyNamespace.MyClass myObject = new MyNamespace.MyClass();

            // Using the method from MyClass
            myObject.DisplayMessage();
        }
    }
}
