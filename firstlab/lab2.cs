using System;
public class asmd{
public static void Main(string[] args){
Console.WriteLine("enter two integer");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
int add=a+b;
int sub=a-b;
int multi=a*b;
int div=a/b;
Console.WriteLine("add of "+a+" and "+b+"="+add );
Console.WriteLine("subtract of "+a+" and "+b+"="+sub );
Console.WriteLine("multiply of "+a+" and "+b+"="+multi );
Console.WriteLine("Divide of "+a+" and "+b+"="+div );
}
}