/* Blaine Smith 
 * Program 2 Due: Jan-23-2018
 * None 
 * None 
 * This code will produce a money report for the IWCC Nerd Squad at the end of their sales.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BSmith_Prog2
{
    class GranolaSales
    {
        static void Main(string[] args)
        {
            const int CASESSOLD = 32;
            const double STUDENTGOVERNPERCENT = .1275;
            decimal costPerCase = 110.00M;
            decimal costPerGranola = 1.50M;
            int barsPerCase = 100;

            decimal totalCost = (decimal)CASESSOLD * costPerCase;
            int totalBars = (CASESSOLD * barsPerCase);
            decimal grossIn = (costPerGranola * (decimal)totalBars);
            decimal netIncome = (grossIn - totalCost);
            decimal netGov = (netIncome * (decimal)STUDENTGOVERNPERCENT);
            decimal squadProfit = (netIncome - netGov);

            Write("Welcome to the IWCC Nerd Squad Granola Sales Project Final Report\n");
            Write("\nNumber of cases of granola sold:{0,37:D}", CASESSOLD);
            Write("\nCost per case:{0,55:C}", costPerCase);
            Write("\nTotal cost incurred:{0,49:C}", totalCost);
            Write("\nNumber of bars in each case:{0,41:D}", barsPerCase);
            Write("\nTotal number of bars were sold:{0,38:D}", totalBars);
            Write("\nCost per bar:{0,56:C}", costPerGranola);
            Write("\nGross income:{0,56:C}", grossIn);
            Write("\nNet income (Gross income - Total Cost incurred):{0,21:C}", netIncome);
            Write("\nPercent to be given to student government:{0,27:P2}", STUDENTGOVERNPERCENT);
            Write("\nAmount of net income to be given to student government:{0,14:C}", netGov);

            Write("\n\nFinal profit for the Nerd Squad:{0,37:C}\n\n", squadProfit);

        }
    }
}
