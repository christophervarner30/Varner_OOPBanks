using System;

namespace LastnameOOPBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(1000m);

            while (true)
            {
                Console.WriteLine("Welcome to the bank!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Quit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter deposit amount: ");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        bank.Deposit(depositAmount);
                        break;
                    case "2":
                        Console.Write("Enter withdrawal amount: ");
                        decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
                        bank.Withdraw(withdrawalAmount);
                        break;
                    case "3":
                        Console.WriteLine($"Current balance: ${bank.Balance:N2}");
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}