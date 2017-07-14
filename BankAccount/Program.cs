using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Client johnSmith = new Client();
            CheckingAccount jsChecking = new CheckingAccount();
            SavingsAccount jsSavings = new SavingsAccount();

            Console.WriteLine("Hello and welcome to Lehman Brothers. \nHere you can view your account information.");
            Console.WriteLine("It is 2008 and we promise that subprime lending is always a wise investment.");
            Console.WriteLine("We also guarantee to never file for bankruptcy.");

            Console.WriteLine("\nPlease select from the following options: \n1. View Client Informationn\n2. View Account Balance\n3. Deposit Funds\n4. Withdraw Funds\n5. Exit");
            int selection = int.Parse(Console.ReadLine());
            char account;
            if (selection == 1)
            {
                Console.WriteLine(johnSmith.GetClientInfo());
            }
            if (selection == 2)
            {
                Console.WriteLine("Which account would you like to view the balance of?");
                Console.WriteLine("Please select:\na. Checking Account\nb. Savings Account");
                account = char.Parse(Console.ReadLine().ToLower());
                if (account == 'a')
                {
                    jsChecking.GetBalance();
                }
                if (account == 'b')
                {
                    jsSavings.GetBalance();
                }
            }
            if (selection == 3)
            {
                Console.WriteLine("To which account would you like to make a deposit?");
                Console.WriteLine("Please select:\na. Checking Account\nb. Savings Account");
                account = char.Parse(Console.ReadLine().ToLower());
                if (account == 'a')
                {
                    jsChecking.Deposit();
                }
                if (account == 'b')
                {
                    jsSavings.Deposit();
                }
            }
            if (selection == 4)
            {
                Console.WriteLine("From which account would you like to make a withdrawal?");
                Console.WriteLine("Please select:\na. Checking Account\nb. Savings Account");
                account = char.Parse(Console.ReadLine().ToLower());
                if (account == 'a')
                {
                    jsChecking.Withdraw();
                }
                if (account == 'b')
                {
                    jsSavings.Withdraw();
                }
            }
        }
    }
}
