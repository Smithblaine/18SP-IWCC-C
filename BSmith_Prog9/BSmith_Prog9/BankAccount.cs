/* Blaine Smith
 * Prog 9 Due March 13, 2018
 * Matt Clark
 * The program will allow the user to create a savings or checking account,
 * it will also allow them to modify the account balance's.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BSmith_Prog9
{
    class BankAccount
    {
        private int account;
        private decimal balance;
        private string owner;
        private bool savings;

        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }

        public int Account
        {
            get
            {
                return account;
            }
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        public bool Savings
        {
            get
            {
                return savings;
            }
            set
            {
                savings = value;
            }
        }

        public BankAccount()
        {
            owner = "Need a name";
        }

        public BankAccount(string name, int number, decimal amount, bool sving)
        {
            owner = name;
            savings = sving;
            SetAccount(number);
            UpdateBalance(amount, true);
        }

        public void SetAccount(int num)
        {
            account = num;
            if (account <= 0)
            {
                Write("Not an acceptable account number.  Enter new number:  ");
                account = int.Parse(ReadLine());
            }
        }

        public void UpdateBalance(decimal amount, bool deposit)
        {
            if (deposit == true)
            {
                while (amount < 0.00M)
                {
                    Write("Amount may not be lower than $0.00.  Enter new amount to deposit: ");
                    amount = decimal.Parse(ReadLine());
                }
                balance += amount;
            }
            else
            {
                while (amount > balance)
                {
                    Write("Amount desired is greater than current balance of {0:C}.  Enter new amount to withdraw: ", balance);
                    amount = decimal.Parse(ReadLine());
                }
               balance -= amount;
            }
        }

        public override string ToString()
        {
            string type = "";
            if (savings == false)
            {
                type = "checking";
            }
            else
            {
                type = "saving";
            }
            return "\nAccount Number:  " + account + "\nAccount Owner:  " + owner + "\nBalance:  " + balance.ToString("C") + "\nThis is a " + type + " account.";
        }
    }
}
