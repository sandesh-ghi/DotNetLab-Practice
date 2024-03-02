using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Shape
{ 
    public abstract double CalculateArea();
    public void Display()
    {
        Console.WriteLine("This is a shape.");
    }
}

public class Rectangle : Shape
{
    private double length , bredth;
    public Rectangle(double l, double b)
    {
        length=l;
        bredth=b;
    }
    public override double CalculateArea()
    {  
        return length*bredth;
    }
}
public class Square : Shape
{
    private double side;
    public Square(double s)
    {
        side = s;
    }
    public override double CalculateArea()
    {
        
        return side * side;
    }
}
 public class AbsClsMthd
{
    public static void Main(string[] args)
    {
       
        Rectangle rectangle = new Rectangle(5,7);
        Square square = new Square(4);

       rectangle.Display();
        Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());

        square.Display();
        Console.WriteLine("Area of Square: " + square.CalculateArea());
        Console.ReadKey();
    }
}
