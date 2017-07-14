using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account
    {
        //protected int accountNumber;
        //protected double balance;
        //protected string accountType;

        public abstract void GetBalance();
        public abstract void Deposit();
        public abstract void Withdraw();

    }
}
