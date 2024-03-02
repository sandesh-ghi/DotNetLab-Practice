using System;
public class asmd{
public static void Main(string[] args){
Console.WriteLine("enter two integer");
int l=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
int area=l*b;
int peri=2*(l+b);
Console.WriteLine("area of restangle  length "+l+" and bredth  "+b+" is "+area );
Console.WriteLine("perimeter of restangle  length "+l+" and bredth  "+b+" is "+peri );
}
}