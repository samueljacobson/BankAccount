using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        protected int accountNumber = 189007;
        protected double balance = 25000.00d;
        protected string accountType = "Savings";

        private double deposit;
        private double withdrawal;
        private double minBalance = 1000d;

        public double MinBalance { get; }

        public SavingsAccount()
        {

        }

        public override void GetBalance()
        {
            Console.WriteLine("Your current savings account balance is: $" + balance);
        }

        public override void Deposit()
        {
            Console.WriteLine("Enter the amount of your deposit:");
            deposit = double.Parse(Console.ReadLine());
            Console.WriteLine("Thank you. Your current savings account balance is: $" + (balance + deposit));
        }

        public override void Withdraw()
        {
            while (true)
            {
                Console.WriteLine("Enter the amount of your withdrawal:");
                withdrawal = double.Parse(Console.ReadLine());

                if ((balance - withdrawal) < minBalance)
                {
                    Console.WriteLine("Sorry, you cannot withdraw below the minimum balance of $" + minBalance);
                    Console.WriteLine("The maximum withdrawal is $" + (balance - minBalance) + ". Please try again.");
                }

                if ((balance - withdrawal) >= minBalance)
                {
                    Console.WriteLine("Thank you. Your current checking account balance is: $" + (balance - withdrawal));
                    break;
                }
            }   
            
        }
    }
}
