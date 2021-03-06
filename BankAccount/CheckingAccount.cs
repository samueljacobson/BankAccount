﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        //Fields - hard-coded
        protected int accountNumber = 157687;
        protected double balance = 1450.00d;
        protected string accountType = "Checking";

        //Fields - based on user input
        private double deposit;
        private double withdrawal;

        //Constructor
        public CheckingAccount()
        {

        }

        //Methods (inherited from the abstract class)
        public override void GetBalance()
        {
            Console.WriteLine("Your current checking account balance is: $" + balance);
        }

        public override void Deposit()
        {
            Console.WriteLine("Enter the amount of your deposit:");
            deposit = double.Parse(Console.ReadLine());
            Console.WriteLine("Thank you. Your current checking account balance is: $" + (balance + deposit));
        }

        public override void Withdraw()
        {
            Console.WriteLine("Enter the amount of your withdrawal:");
            withdrawal = double.Parse(Console.ReadLine());
            Console.WriteLine("Thank you. Your current checking account balance is: $" + (balance - withdrawal));
        }
    }
}
