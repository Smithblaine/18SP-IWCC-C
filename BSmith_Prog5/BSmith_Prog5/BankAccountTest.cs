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
using static System.Console;

namespace BSmith_Prog5
{
    class BankAccountTest
    {
            public static void Main(string[] args)
        {
            WriteLine("\nWelcome to the Bank Account Program");


            Write("\nWhat is the customer's name:  ");
            string name = ReadLine();
            BankAccount bAccount1 = new BankAccount(name, 12345);

            Write("What is the balance?  ");
            decimal amount = decimal.Parse(ReadLine());
            bAccount1.SetBalance(amount);

            Write("\nWhat is the next customer's name:  ");
            name = ReadLine();


            Write("What is the balance?  ");
            amount = decimal.Parse(ReadLine());

            BankAccount bAccount2 = new BankAccount(name, 12346, amount);


            WriteLine("\n\nAccount 1:");
            WriteLine("Account Number:  {0}", bAccount1.GetAccount());
            WriteLine("Account Owner:  {0}", bAccount1.GetOwner());
            WriteLine("Account Balance:  {0:C}", bAccount1.GetBalance());
            WriteLine("\n\nAccount 2:");
            WriteLine("Account Number:  {0}", bAccount2.GetAccount());
            WriteLine("Account Owner:  {0}", bAccount2.GetOwner());
            WriteLine("Account Balance:  {0:C}", bAccount2.GetBalance());

            WriteLine();
        }
    }
}
