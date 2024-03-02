using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Company
 
    {
        private string name;
        private string address;
        private string phone;
        private double salary;

       
        public Company(string n, string addr, string ph, double sal)
        {
            name = n;
            address = addr;
            phone = ph;
            salary = sal;
        }

       
        public void DisplayDetails()
        {
            Console.WriteLine($"Company Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Salary: {salary}"); 
        }

        static void Main()
        {
            Console.WriteLine("Enter Company Details:");
            Console.Write("Name: ");
            string companyName = Console.ReadLine();

            Console.Write("Address: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Phone: ");
            string companyPhone = Console.ReadLine();

            Console.Write("Salary: ");
            double companySalary = double.Parse(Console.ReadLine());

            
            Company myCompany = new Company(companyName, companyAddress, companyPhone, companySalary);

            Console.WriteLine("\nCompany Details:");
            myCompany.DisplayDetails();
        }
    }

}

