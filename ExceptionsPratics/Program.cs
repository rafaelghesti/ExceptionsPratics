using ExceptionsPratics.Entities;
using ExceptionsPratics.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExceptionsPratics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Enter account data ##");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holer = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Whitdraw limit: ");
            double whitdrawLimit = double.Parse(Console.ReadLine());
            
            Account acc = new Account(number, holer, balance, whitdrawLimit);

            Console.Write("\nEnter amount for whitdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.Withdraw(amount);
                Console.WriteLine($"New balance: ${acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Whitdraw error: {e.Message}");
            }

        }
    }
}
