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
        public decimal Balance { get; set; }

        //constructor
        public BankAccount(string owner) 
        { 
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        
        }

    }
}
