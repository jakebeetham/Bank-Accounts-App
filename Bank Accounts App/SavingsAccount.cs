using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounts_App
{
    public class SavingsAccount:BankAccount //inheriting from BankAccount class
    {

        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal interestRate):base(owner + " - " + interestRate + "%") //invokes constructor of parent/base class
        {
            InterestRate = interestRate;
            
        }

        //using polymorphism to override deposit method within parent class

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "You can not deposit £" + amount;
            }
            if (amount > 20000)
            {
                return "You cannot deposit more than £20,000";
            }

            //calcualting interest amount value
            decimal interestAmount = (InterestRate / 100) * amount;

            Balance += amount + interestAmount;
            return "Deposit completed successfully";

        }




    }
}
