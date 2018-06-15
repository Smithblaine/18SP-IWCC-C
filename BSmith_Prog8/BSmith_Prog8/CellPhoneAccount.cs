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

namespace BSmith_Prog8
{
    class CellPhoneAccount
    {
        private string plan;
        private bool android;
        private int account;
        private string owner;
        private decimal cost;
        private string phoneType;

        public bool Android
        {
            get
            {
                return android;
            }
            set
            {
                android = value;
            }
        }

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
            set
            {
                account = value;
            }
        }

        public CellPhoneAccount(int acct, string user, string phone)
        {
            Account = acct;
            Owner = user;
            phoneType = phone;

            if (phone == "Samsung" || phone == "LG" || phone == "HTC" || phone == "Motorola" || phone == "samsung" || phone == "lg" || phone == "htc" || phone == "motorola")
            {
                Android = true;
            }
            else
            {
                Android = false;
            }
        }

        public void SetPlanAndCost(char pt)
        {
            switch (pt)
            {
                case ' ':
                case 'A':
                case 'a':
                    plan = "Hermit";
                    cost = 10M;
                    break;
                case 'B':
                case 'b':
                    plan = "Anti-Social";
                    cost = 40M;
                    break;
                case 'C':
                case 'c':
                    plan = "Granny";
                    cost = 60M;
                    break;
                case 'D':
                case 'd':
                    plan = "Socialite";
                    cost = 99M;
                    break;
            }
        }

        public override string ToString()
        {
            return string.Format("\nName: " + owner + "\nAccount: " + account + "\nPlan: " + plan + "\nCost: " + cost.ToString("c") + "\nPhone: " + phoneType + "\nThis Phone {0} an android\n", android ? "is" : "is not");
        }
    }
}
