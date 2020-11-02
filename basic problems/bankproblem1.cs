using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class savingsAccount
    {
        private double amount, balance;

        public double Amount { get { return amount; } set { amount = value; } }
        public double Balance { get { return balance; } set { balance = value; } }

        public savingsAccount(double amount, double balance)
        {
            this.amount = amount;
            this.balance = balance;
        }

        public void Diposit()
        {
            balance = balance + amount;
        }
        public void Withdrow()
        {
            if (amount > balance)
            {
                Console.WriteLine("sorry sir");
            }
            else
                balance = balance - amount;
        }

    }
}