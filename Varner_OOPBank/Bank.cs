using System;

public class Bank
{
    private decimal _balance;

    public Bank(decimal initialBalance)
    {
        _balance = initialBalance;
    }

    public decimal Balance
    {
        get { return _balance; }
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"Deposited ${amount:N2}. New balance: ${_balance:N2}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 500)
        {
            amount = 500;
            Console.WriteLine("Withdrawal amount capped at $500.");
        }

        if (_balance - amount < 0)
        {
            _balance = 0;
            Console.WriteLine("Withdrawal denied. Balance set to $0.00.");
        }
        else
        {
            _balance -= amount;
            Console.WriteLine($"Withdrew ${amount:N2}. New balance: ${_balance:N2}");
        }
    }
}