/* Blaine Smith
 * Prog 7 Due Tuesday, February 27,2018
 * NONE
 * NONE
 * This program will help you select a movie and give you the total cost for your tickets.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BSmith_Prog7
{
    class MovieTicket
    {
        private string movie;
        private string ageGroup;
        private int numTickets;
        private decimal cost;
        private decimal totalCost;
        private bool card;


        public string AgeGroup
        {
            get
            {
                return ageGroup;
            }
            set
            {
                ageGroup = value;
            }
        }

        public int NumTickets
        {
            get
            {
                return numTickets;
            }
            set
            {
                numTickets = value;
            }
        }

        public MovieTicket(string M)
        {
            movie = M;
            card = false;
        }


        public void SetCard(string credit)
        {
            if (credit.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                card = true;
            }
            else
            {
                card = false;
            }
        }

        public void FindAge()
        {
            WriteLine("\n\nTicket prices are:  ");
            WriteLine(" Child (under 12) - $5.00");
            WriteLine(" Student (with ID) or Educator - $7.00");
            WriteLine(" Adult - $12.00");
            WriteLine(" Senior or Veteran - $4.00");
            Write("\nWhat age group are you purchasing?   ");
            ageGroup = ReadLine();
        }

        public void CalcCost()
        {
            if (ageGroup.Equals("Child", StringComparison.OrdinalIgnoreCase))
            {
                cost = 5.00M;
            }
            else if (ageGroup.Equals("Student", StringComparison.OrdinalIgnoreCase))
            {
                cost = 7.00M;
            }
            else if (ageGroup.Equals("Adult", StringComparison.OrdinalIgnoreCase))
            {
                cost = 12.00M;
            }
            else
            {
                cost = 4.00M;
            }
        }

        public void TotalCost()
        {
            totalCost = numTickets * cost;
        }

        public override string ToString()
        {
            if (card == false)
            {
                string result = "\n" + numTickets + " tickets for " + movie + " at " + cost.ToString("c") + " is " + totalCost.ToString("c") + "\nYou will receive a 10% discount for cash.\n";
                return result;
            }
            else
            {
                string result = "\n" + numTickets + " tickets for " + movie + " at " + cost.ToString("c") + " is " + totalCost.ToString("c") + "\nBe sure to bring your credit card.\n";
                return result;
            }

        }
    }
}
