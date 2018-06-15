/* Blaine Smith
 * Program 6 due February 20, 2018
 * NONE
 * NONE
 * This program will accept a place of travel along and will calculate a total cost of gas for the travels,
 * it will then help you with another place of travel.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BSmith_Prog6
{
    class TripCalculator
    {
        private string destination = "";
        private double distance = 0.0;
        private decimal costGas = 0.0M;
        private double mpg = 0.0;

        public TripCalculator()
        {
            costGas = 0.0M;
        }

        public TripCalculator(string dest, decimal CG)
        {
            destination = dest;
            costGas = CG;
        }

        public decimal CostGas
        {
            get
            {
                return costGas;
            }
            set
            {
                costGas = value;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }

        public void SetDistance(double miles)
        {
            distance = miles;
        }

        public void SetMpg(double gas)
        {
            mpg = gas;
        }

        public double GetDistance()
        {
            return distance;
        }

        public double GetMpg()
        {
            return mpg;
        }

        public double GalsUsed()
        {
            double used = distance / mpg;
            return used;
        }

        public decimal CostPerMile()
        {
            decimal cost = TotalCost();
            decimal mile = cost / (decimal)distance;
            return mile;
        }

        public decimal TotalCost()
        {
            decimal used = (decimal)GalsUsed();
            decimal cost = used * costGas;
            return cost;
        }

        public override string ToString()
        {
            return string.Format("Destination:  {0}\nTotal Miles:  {1}\nMiles per Gallon:  {2}\nCost of Gas:  {3}\n", destination, distance, mpg, costGas);
        }
    }
}
