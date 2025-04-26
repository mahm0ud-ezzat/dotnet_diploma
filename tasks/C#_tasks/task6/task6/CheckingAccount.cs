using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace task6
{
    public class CheckingAccount : Account
    {
        private const double CHECKING_WITHDRAW_FEE = 1.5;
        public CheckingAccount(string name = "Unnamed Account", double balance = 0) : base(name, balance)
        {
           
        }

        //    2. Add a Checking account class to the Account hierarchy
        //    A Checking account has a name and a balance and has a fee of $1.50 per withdrawal transaction.
        //Every withdrawal transaction will be assessed this flat fee.




        public new bool Withdraw(double amount)
        {
            return base.Withdraw(amount + CHECKING_WITHDRAW_FEE);

        }


    }
}
