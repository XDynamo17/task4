using System;
using System.Collections.Generic;
using System.Text;
namespace BankApp;

public class TrustAccount : Account
    {
        const double BonusThreshold = 5000.0;
        const double BonusAmount = 50.0;
        const int MaxWithdrawals = 3;
        const double MaxWithdrawalPercent = 0.20;
        public int WithdrawalCount { get; set; } = 0;
            
        
       public TrustAccount(string name, double balance) : base(name, balance)
        {
            Name = name;
            Balance = balance;
        }

        public override bool Deposit(double amount)
        {
            if (amount <= 0)
                return false;


            Balance += amount;

            if (amount>= BonusThreshold)
            {
                Balance += BonusAmount;
            }

            return true;
        }
        public override bool Withdraw(double amount)
        {
            if(WithdrawalCount <= MaxWithdrawals && amount <= (Balance * MaxWithdrawalPercent))
            {
                WithdrawalCount++;
                return base.Withdraw(amount);
            }
            return false;
        }

    }



