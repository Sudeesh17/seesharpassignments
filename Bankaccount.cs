using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT2
{
    class BankAccount
    {
        double balance;
        public BankAccount()
        {
            balance = 500;
        }
        public BankAccount(double balance)
        {
            this.balance = balance;
        }
        public double getBalance()
        {
            return balance;
        }
        class BankTest
        {
            public static void Main(string[] args)
            {
                BankAccount b1 = new BankAccount();
                Console.WriteLine("defaultbalance=" + b1.getBalance());
                BankAccount b2 = new BankAccount(1000);
                Console.WriteLine("mainbalance=" + b2.getBalance());
            }
        }



    }

}
