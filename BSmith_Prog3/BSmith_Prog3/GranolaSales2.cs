/* Blaine Smith 
 * Program 3 Due: Jan-30-2018
 * None 
 * None 
 * This code will produce end of sales report for the IWCC Nerd Squad.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BSmith_Prog3
{
    class GranolaSales2
    {
        static void Main(string[] args)
        {
           const double STUDENT_GOVERN_PERCENT = .1275;
           decimal costPerCase = 110.00M;
           decimal costPerGranola = 1.50M;
           int barsPerCase = 100;

           Greeting();
           int casesSold = GetCases();
           int totalBars = BarsSold(barsPerCase,casesSold);
           decimal totalCost = TotalCost(casesSold,costPerCase);
           decimal grossIn = GrossIncome(totalBars,costPerGranola);
           decimal netIncome = NetIncome(totalCost, grossIn);
           decimal netGov = DonatedAmount(netIncome, STUDENT_GOVERN_PERCENT);
           decimal squadProfit = FinalProfit(netIncome, netGov);
           Write("\nTotal cost incurred:{0,49:C}", totalCost);
           Write("\nNumber of bars in each case:{0,41:D}", barsPerCase);
           Write("\nTotal number of bars were sold:{0,38:D}", totalBars);
           Write("\nCost per bar:{0,56:C}", costPerGranola);
           Write("\nGross income:{0,56:C}", grossIn);
           Write("\nNet income (Gross income - Total Cost incurred):{0,21:C}", netIncome);
           Write("\nPercent to be given to student government:{0,27:P}", STUDENT_GOVERN_PERCENT);
           Write("\nAmount of net income to be given to student government:{0,14:C}", netGov);
           Write("\n\nFinal profit for the Nerd Squad:{0,37:C}\n\n", squadProfit);
        }
        public static void Greeting()
        {
            Write("Welcome to the IWCC Nerd Squad Granola Sales Project Final Report\n");
        }
        public static int GetCases()
        {
            Write("\nEnter the number of cases sold:  ");
            int casesSold = int.Parse(ReadLine());
            return casesSold;
        }
        public static int BarsSold(int barsPerCase1, int casesSold1)
        {
            Write("\nNumber of cases of granola sold:{0,37:D}", casesSold1);
            Write("\nCost per case:{0,55:C}", barsPerCase1);
            int totalBars = casesSold1 * barsPerCase1;
            return totalBars;
        }
        public static decimal TotalCost(int casesSold1, decimal costPerCase1)
        {
            decimal totalCost = casesSold1 * costPerCase1;
            return totalCost;
        }
        public static decimal GrossIncome(int totalBars1, decimal costPerGranola1)
        {
            decimal grossIn = (costPerGranola1 * totalBars1);
            return grossIn;
        }
        public static decimal NetIncome(decimal grossIn1, decimal totalCost1)
        {
            decimal netIncome = (totalCost1 - grossIn1);
            return netIncome;
        }
        public static decimal DonatedAmount(decimal netIncome1, double STUDENT_GOVERN_PERCENT1)
        {
            decimal netGov = (netIncome1 * (decimal)STUDENT_GOVERN_PERCENT1);
            return netGov;
        }
        public static decimal FinalProfit(decimal netGov1, decimal netIncome1)
        {
            decimal squadProfit = (netGov1 - netIncome1);
            return squadProfit;
        }
    }
}
