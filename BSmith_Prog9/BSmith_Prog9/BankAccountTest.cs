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
    class BankAccountTest
    {
        static void Main(string[] args)
        {
            BankAccount newAccount = new BankAccount();
            string typeAcc;
            int choice;
            decimal amtDorW;
            bool update = false;
            int num2;
            bool cL;

            Greeting();
            DisplayMenu();
            choice = GetChoice();
            CheckChoice(choice, out num2, out cL);
            do
            {
                switch (num2)
                {
                    case 1:
                        newAccount = CreateAccount();
                        break;
                    case 2:
                        typeAcc = "Deposit";
                        update = true;
                        amtDorW = GetAmount(typeAcc);
                        newAccount.UpdateBalance(amtDorW, update);
                        break;
                    case 3:
                        typeAcc = "Withdraw";
                        update = false;
                        amtDorW = GetAmount(typeAcc);
                        newAccount.UpdateBalance(amtDorW, update);
                        break;
                    case 4:
                        WriteLine("\nYour balance is:  {0:C}", newAccount.Balance);
                        break;
                    case 5:
                        WriteLine(newAccount.ToString());
                        break;
                }
                DisplayMenu();
                choice = GetChoice();
                CheckChoice(choice, out num2, out cL);
            } while (cL == true);

        }

        public static void Greeting()
        {
            WriteLine("Welcome to Smith Swindler's & CO.");
        }

        public static void DisplayMenu()
        {
            WriteLine();
            WriteLine("1) Create New Account");
            WriteLine("2) Deposit");
            WriteLine("3) Withdrawl");
            WriteLine("4) Check Balance");
            WriteLine("5) Print Account");
            WriteLine("6) End Program");
            WriteLine();
        }

        public static int GetChoice()
        {
            Write("Enter the number for your action:  ");
            int choose = int.Parse(ReadLine());
            return choose;
        }

        public static BankAccount CreateAccount()
        {
            Write("\nWhat is the customer's name:  ");
            string name = ReadLine();
            Write("What is the account number:  ");
            int account = int.Parse(ReadLine());
            Write("What is the balance?  ");
            decimal balance = decimal.Parse(ReadLine());
            Write("Is this a savings or checking account?  ");
            string b = ReadLine();
            bool sving = false;
            if (b == "saving" || b == "Saving" || b == "savings" || b == "Savings")
            {
                sving = true;
            }
            BankAccount tempAcc = new BankAccount(name, account, balance, sving);
            return tempAcc;
        }

        public static decimal GetAmount(string a)
        {
            decimal amt = 0;
            if (a == "Deposit")
            {
                Write("How much do you want to deposit?  ");
                amt = decimal.Parse(ReadLine());
                while (amt < 0)
                {
                    WriteLine("\nAmount needs to be larger than $0.00.");
                    Write("How much do you want to deposit?  ");
                    amt = decimal.Parse(ReadLine());
                }
            }
            else
            {
                Write("\nHow much do you want to withdraw?  ");
                amt = decimal.Parse(ReadLine());
            }
            return amt;
        }

        public static void CheckChoice(int numChoice, out int num2, out bool cL)
        {
            cL = false;
            while (numChoice < 1 || numChoice > 6)
            {
                Write("Not a valid choice.  Try again.\n");
                DisplayMenu();
                numChoice = GetChoice();
            }
            
            if (numChoice == 1 || numChoice == 2 || numChoice == 3 || numChoice == 4 || numChoice == 5)
            {
                cL = true;
            }
            num2 = numChoice;
        }
    }
}
