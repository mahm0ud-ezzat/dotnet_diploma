using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    public class SavingAccount : Account
    {
        public double InterestRate { get; set; }
        //1. Add a Savings Account class to the Account hierarchy and adds an interest rata.

        public SavingAccount(string name = "Unnamed Account", double balance = 0, double interestRate = 0) : base(name, balance)
        {
            InterestRate = interestRate;
        }


        public new bool Withdraw(double amount)
        {
            return base.Withdraw(amount + (amount * InterestRate));
        }
    }
}
