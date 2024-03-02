using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
   public int Id;
   public string Name;
   public  string Address;
   public double Salary;

    public Employee(int i, string n, string a, double s)
    {
        Id = i;
        Name = n;
        Address = a;
        Salary = s;
    }
}

class linqDescending
{
    public static void Main(string[] args)
    {
        List<Employee> employeeList = new List<Employee>();
        employeeList.Add(new Employee(101, "Hari", "ktm", 2000));
        employeeList.Add(new Employee(102, "Ram", "kirtipur", 3000));

        var sortedEmployees = employeeList.OrderByDescending(e => e.Name);

        Console.WriteLine("Employee Records in Descending Order by Name:");
        foreach (var employee in sortedEmployees)
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary}");
        }
    }
}
