using System;
using System.Collections.Generic;
using System.Text;
namespace BankApp;

public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount(string name, double balance, double interestrate)
        : base(name, balance)
        {   if (interestrate > 0)
            InterestRate = interestrate;
        }
        public override bool Deposit(double amount)
        { 
        return base.Deposit(amount + (amount * InterestRate / 100));
        }
    }

    