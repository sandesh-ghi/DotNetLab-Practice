using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class labB
    {
     

// Single-level inheritance
class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    // Multi-level inheritance
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }

    class Sparrow : Bird
    {
        public void Chirp()
        {
            Console.WriteLine("Chirping...");
        }
    }

    // Hierarchical inheritance
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }
    }

    // Multiple inheritance using interface
    interface ICanRun
    {
        void Run();
    }

    interface ICanSwim
    {
        void Swim();
    }

    class Duck : ICanRun, ICanSwim
    {
        public void Run()
        {
            Console.WriteLine("Duck running...");
        }

        public void Swim()
        {
            Console.WriteLine("Duck swimming...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Single-level inheritance
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Console.WriteLine();

            // Multi-level inheritance
            Sparrow sparrow = new Sparrow();
            sparrow.Eat();
            sparrow.Fly();
            sparrow.Chirp();

            Console.WriteLine();

            // Hierarchical inheritance
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

            Console.WriteLine();

            // Multiple inheritance using interface
            Duck duck = new Duck();
            duck.Run();
            duck.Swim();
        }
    }

}
}
