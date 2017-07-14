using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //Fields
        protected string name = "John Smith";
        protected string ssn = "145-77-9001";
        protected string location = "San Francisco";

        //Properties
        public string Name { get; }
        public string SSN { get; }
        public string Location { get; }

        //Constructors
        public Client()
        {

        }

        //public Client()
        //{

        //}

        //Methods
        public virtual string GetClientInfo()
        {
            return "Name: " + name + "\nSSN: " + ssn + "\nLocation: " + location;
        }


    }
}
