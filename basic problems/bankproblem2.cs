using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class craditAccount
    {
        private double amount, balance,cradit;

        public double Amount { get { return amount; } set { amount = value; } }
        public double Balance { get { return balance; } set { balance = value; } }

        public craditAccount(double amount,double balance,double cradit)
        {
            this.amount = amount;
            this.balance = balance;
            this.cradit = cradit;
        }

        public void Diposit() {
            balance = balance + amount;
        }
        public void Withdrow() {
            if (amount > balance && amount<1000)
            { 
                Console.WriteLine("you are taking Cradit money");
            }
            else
            balance = balance - amount;
        }

    }
}