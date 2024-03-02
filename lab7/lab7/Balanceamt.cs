using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Balanceamt
{
    static void Main(string[] args)
    {
        try
        {
            double balance;
            double withdrawalAmount;

            //Console.Write("Enter your balance: ");
            //balance = double.Parse(Console.ReadLine());

            balance = 20000;
            Console.Write("Enter withdrawal amount: ");
            withdrawalAmount = double.Parse(Console.ReadLine());

            if (balance >= withdrawalAmount)
            {
                double remainingBalance = balance - withdrawalAmount;

                Console.WriteLine("Remaining balance: " + remainingBalance);
            }
            else
            {
                throw new Exception("Insufficient balance. Cannot withdraw more than the available balance.");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input. Please enter a valid number." + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("your amount.");
        }
    }
}

