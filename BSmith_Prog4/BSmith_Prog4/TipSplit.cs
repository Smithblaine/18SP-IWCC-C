/* Blaine Smith 
 * Program 4 Due: Feb-06-2018
 * None 
 * None 
 * This code will give a party the total tip for a bill and how it is split per person in group.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BSmith_Prog4
{
    class TipSplit
    {
        static void Main(string[] args)
        {
            const double TIP_15 = .15;
            const double TIP_20 = .20;
            decimal tip15;
            decimal tip20;
            decimal share1;
            decimal share2;
            decimal totalShare1;
            decimal totalShare2;
            Greeting();
            decimal billTotal = GetTotal();
            CalcTip(TIP_15, TIP_20, billTotal, out tip15, out tip20);
            CalcTotal(billTotal, tip15, tip20, out share1, out share2);
            int totalPeople = GetPeople();
            SplitBill(totalPeople, share1, share2, out totalShare1, out totalShare2);
            PrintReceipt(tip15, tip20, share1, share2, totalShare1, totalShare2);
        }
        public static void Greeting()
        {
            Write("Welcome to Smith's Cafe Tip Calculator\n");
        }
        public static decimal GetTotal()
        {
            Write("\nEnter the bill total:   ");
            decimal bTotal = decimal.Parse(ReadLine()); 
            return bTotal;
        }
        public static void CalcTip(double tip1, double tip2, decimal bTotal, out decimal tipTotal1, out decimal tipTotal2)
        {
            tip1 = (double)bTotal * .15; 
            tip2 = (double)bTotal * .20; 
            tipTotal1 = (decimal)tip1;   
            tipTotal2 = (decimal)tip2;
        }
        public static void CalcTotal(decimal bTotal, decimal tip151, decimal tip201, out decimal share3, out decimal share4)
        {
            share3 = bTotal + tip151;
            share4 = bTotal + tip201;
        }
        public static int GetPeople()
        {
            Write("How many people in your party:   ");
            int people = int.Parse(ReadLine());
            return people;
        }
        public static void SplitBill(int pTotal, decimal share3, decimal share4, out decimal totalShare3, out decimal totalShare4)
        {
            totalShare3 = share3 / pTotal;
            totalShare4 = share4 / pTotal;
        }
        public static void PrintReceipt(decimal tip151, decimal tip201, decimal share3, decimal share4, decimal totalShare3, decimal totalShare4)
        {
            Write("\n15% tip would be: {0,18:C2}", tip151);
            Write("\n20% tip would be: {0,18:C2}\n", tip201);
            Write("\nTotal tip for 15% would be: {0,8:C2}", share3);
            Write("\nEach person's share is: {0,12:C2}\n", totalShare3);
            Write("\nTotal tip for 20% would be: {0,8:C2}", share4);
            Write("\nEach person's share is: {0,12:C2}\n\n", totalShare4);
        }
    }
}
