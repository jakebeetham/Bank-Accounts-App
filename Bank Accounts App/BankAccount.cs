using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounts_App
{
    public class BankAccount
    {
        //declaring what defines a bank account
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        //using encapsulation to ensure Balance can not be set outside of this class
        public decimal Balance { get; private set; }

        //constructor
        public BankAccount(string owner) 
        { 
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        
        }

        public string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "You can not deposit £" + amount;
            }
            if (amount > 20000)
            {
                return "You cannot deposit more than £20,000";
            }
            
            Balance += amount;
            return "Deposit completed successfully";
        
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return "You can not withdraw £" + amount;
            }
            if (amount > Balance)
            {
                return "You don't have the funds to withdraw £" +amount;
            }

            Balance -= amount;
            return "Withdraw completed successfully";

        }

    }
}
