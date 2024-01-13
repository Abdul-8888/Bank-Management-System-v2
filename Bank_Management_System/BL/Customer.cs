using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Management_System.DL;

namespace Bank_Management_System.BL
{
    public class Customer : Credential, iCustomer
    {
        private string name;
        private double accountBalance;
        private bool highest;

        public double AccountBalance { get => accountBalance; set => accountBalance = value; }
        public string Name { get => name; set => name = value; }
        public bool Highest { get => highest; set => highest = value; }

        public Customer(string username, string password, string name, double accountBalance) : base(username, password)
        {
            Name = name;
            AccountBalance = accountBalance;
            Highest = false;
        }

        public double depositCash(double deposit)
        {
            AccountBalance += deposit;
            return AccountBalance;
        }

        public double withdrawCash(double withdraw)
        {
            if(AccountBalance > withdraw)
            {
                AccountBalance -= withdraw;
            }

            return AccountBalance;
        }

        public double calculateInterest()
        {
            double interest = 0;

            if (Highest)
            {
                if(BankDL.Bank.isProfit())
                {
                    interest = 0.001 * BankDL.Bank.calculateProfitLoss();
                }
            }

            return interest;
        }

        public double calculateAccountBalance()
        {
            accountBalance += calculateInterest();

            return accountBalance;
        }
    }

    interface iCustomer
    {
        double calculateInterest();
        double calculateAccountBalance();
    }
}
