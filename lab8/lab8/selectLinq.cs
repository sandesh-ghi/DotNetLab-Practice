using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name, Address, College;
}

class selectLinq
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "John", Address = "Kirtipur", College = "Patan Multiple Campus" },
            new Student { Name = "Alice", Address = "Kathmandu", College = "Patan Multiple Campus" },
            new Student { Name = "Bob", Address = "Kirtipur", College = "XYZ College" },
            // Add more student records as needed
        };

        var selectedStudents = students
            .Where(s => s.Address == "Kirtipur" && s.College == "Patan Multiple Campus")
            .ToList();

        Console.WriteLine("Selected Students who lived in Kirtipur and studied in Patan Multiple Campus:");
        foreach (var student in selectedStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Address: {student.Address}, College: {student.College}");
        }
    }
}
