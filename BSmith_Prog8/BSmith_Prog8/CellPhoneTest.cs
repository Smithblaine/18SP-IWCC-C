/* Blaine Smith
 * Prog 8 Due Tuesday, March 6,2018
 * NONE
 * NONE
 * This program will allow the user to select a phone plan and will also list if their current phone
 * is android or not.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BSmith_Prog8
{
    class CellPhoneTest
    {
        static void Main(string[] args)
        {
            string owner;
            int acct;


            Greeting();
            GetOwnerAcct(out owner, out acct);
            string phone = GetPhoneType();
            CellPhoneAccount phones = new CellPhoneAccount(acct, owner, phone);
            DisplayMenu();
            char pt = GetPlanType();
            phones.SetPlanAndCost(pt);
            WriteLine(phones);
        }

        public static void Greeting()
        {
            WriteLine("Welcome to Smith's Cell Phone Networking & CO.\n");
        }

        public static void GetOwnerAcct(out string owner, out int acct)
        {
            Write("Enter user's name:  ");
            owner = ReadLine();
            Write("Enter account Number:  ");
            string account1 = ReadLine();
            bool acctVert = int.TryParse(account1, out acct);
            if (acctVert == false)
            {
                Write("Account Number invalid. using 999999.\n");
                acct = 999999;
            }
        }

        public static string GetPhoneType()
        {
            Write("What brand of phone is this?  ");
            string phone = ReadLine();
            return phone;
        }

        public static void DisplayMenu()
        {
            WriteLine("\nPlans Available:");
            WriteLine("A. Hermit Plan - 0GB Data, 0 Texting, 15 minutes Talk, Cost $10");
            WriteLine("B. Anti-Social Plan - 1GB Data, 0 Texting, 60 minutes Talk, Cost $40");
            WriteLine("C. Granny Plan - 2GB Data, Unlimited Text, 120 minutes Talk, Cost $ 60");
            WriteLine("D. Socialite Plan - 20GB Data, Unlimited Text and Talk, Cost $99");
        }

        public static char GetPlanType()
        {
            Write("\nEnter the letter for the plan chosen:  ");
            string plan = ReadLine();
            char pt;
            bool planVert = char.TryParse(plan, out pt);

            if (pt != 'A' && pt != 'B' && pt != 'C' && pt != 'D' && pt != 'a' && pt != 'b' && pt != 'c' && pt != 'd')
            {
                WriteLine("Unable to determine plan chosen, using A, The Hermit Plan.");
                pt = 'A';
            }
            return pt;
        }
    }
 }

