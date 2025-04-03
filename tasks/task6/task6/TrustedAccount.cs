using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    public class TrustedAccount : SavingAccount
    {

        //   The Trust account withdrawal should only allow 3 withdrawals per year and each of these must be less than 20% of the account balance

        private const double TRUSTED_WITHDRAW_LIMIT = 0.20;
        public TrustedAccount(string name = "Unnamed Account", double balance = 0, double interestRate = 0) : base(name, balance, interestRate)
        {
            Count = 0;
        }
        public int Count { get; set; }

        DateTime End = DateTime.Now.AddYears(1);
        public bool CheckDate()
        {
            if (DateTime.Now >= End)
            {
                End = End.AddYears(1);
                Count = 0;
                return true;
            }
            return false;
        }

        public new bool Withdraw(double amount)
        {
            CheckDate();
            if (DateTime.Now < End && Count < 3 && amount < Balance * (TRUSTED_WITHDRAW_LIMIT))
            {
                Count++;
                return base.Withdraw(amount);
            }
            Console.WriteLine("your limit are acheved, try to decrese your amount  ");

            return false;

        }
        public new bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else if (amount >= 5000)
            {
                Balance += amount + 50;
                Console.WriteLine("bounas added");
                return true;
            }
            else
            {
                Balance += amount ;
                return true;
            }
            return false;
        }

    }
}
