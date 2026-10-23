using System;
namespace BankApp;

public class Account
{
    public string Name { get; set; }
    public double Balance { get; set; }

    public Account(string name = "Unnamed Account", double balance = 0.0)
    {
        this.Name = name;
        this.Balance = balance;
    }

    public virtual bool Deposit(double amount)
    {
        if (amount <= 0)
            return false;
        else
        {
            Balance += amount;
            return true;
        }
    }

    public virtual bool Withdraw(double amount)
    {
        if (Balance - amount >= 0)
        {
            Balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}

