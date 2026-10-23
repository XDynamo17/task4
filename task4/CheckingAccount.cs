using System;
using System.Collections.Generic;
using System.Text;
namespace BankApp;

public class CheckingAccount: Account
    {
        const double fee = 1.50;
        public CheckingAccount(string name , double balance): base(name, balance)
        {
            Name = name;
            Balance = balance;
        }
        
       public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + 1.50);
        }

    }



