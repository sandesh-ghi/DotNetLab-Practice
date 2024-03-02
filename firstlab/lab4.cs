using System;
public class asmd{
public static void Main(string[] args){
Console.WriteLine("enter principal ,time and rate");
int p=int.Parse(Console.ReadLine());
int t=int.Parse(Console.ReadLine());
int r=int.Parse(Console.ReadLine());
int i=(p*t*r)/100;
Console.WriteLine("intrest is"+i);

}
}