/* Blaine Smith
 * Program 5 due February 13, 2018
 * NONE
 * NONE
 * This program will accept two names and balances and return those item for the output.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSmith_Prog5
{
    class BankAccount
    {
        private int account;
        private string owner;
        private decimal balance;

        public BankAccount(string owner1, int account1)
        {
            balance = 0.0M;
            account = account1;
            owner = owner1;
        }

        public BankAccount(string owner2, int account2, decimal amount1)
        {
            owner = owner2;
            account = account2;
            balance = amount1;
        }

        public void SetAccount(int account1)
        {
            account = account1;
        }
        public int GetAccount()
        {
            return account;
        }
        public void SetOwner(string owner1)
        {
            owner = owner1;
        }
        public string GetOwner()
        {
            return owner;
        }
        public void SetBalance(decimal amount1)
        {
            balance = amount1;
        }
        public decimal GetBalance()
        {
            return balance;
        }
    }
}
