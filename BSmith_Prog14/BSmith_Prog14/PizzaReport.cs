/* Blaine Smith
 * Program 14 Due: April 24, 2018
 * None
 * This program will accept the number of pizzas sold for each day of the week then will output the total number of each type that was sold for the week.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BSmith_Prog14
{
    class PizzaReport
    {
        static void Main(string[] args)
        {
            Greeting();

            string[][] pizzas = new string[7][];

            GetPizzas(pizzas);
            WriteLine();
            RunReport(pizzas);
            WriteLine();
        }
        public static void Greeting()
        {
            WriteLine();
            WriteLine("Mama Jane's Pizza Report");
            WriteLine();
        }


        public static void GetPizzas(string[][] pizza)
        {
            string days = " ";
            string type;
            string type1;
            string piTy;
            for (int r = 0; r < pizza.Length; r++)
            {
                int numPiz = 0;
                switch (r)
                {
                    case 0:
                        days = "Monday";
                        break;
                    case 1:
                        days = "Tuesday";
                        break;
                    case 2:
                        days = "Wednesday";
                        break;
                    case 3:
                        days = "Thursday";
                        break;
                    case 4:
                        days = "Friday";
                        break;
                    case 5:
                        days = "Saturday";
                        break;
                    default:
                        days = "Sunday";
                        break;
                }

                Write("How many total pizzas for {0}?  ", days);
                numPiz = int.Parse(ReadLine());

                while (numPiz < 0)
                {
                    Write("Total pizzas can not be less than 0.  Try again.  ");
                    Write("How many total pizzas for {0}?  ", days);
                    numPiz = int.Parse(ReadLine());
                }
                pizza[r] = new string[numPiz];

                if (numPiz == 0)
                {
                    continue;
                }

                Write("Enter all the pizzas for {0}, separated by spaces:  ", days);
                type = ReadLine();
                type1 = type.ToLower();
                string[] nType = type1.Split(' ');

                while (numPiz != nType.Length)
                {
                    WriteLine("Input does not match number needed. Try again.");
                    Write("Enter all the pizzas for {0}, separated by spaces:  ", days);
                    type = ReadLine();
                    type1 = type.ToLower();
                    nType = type1.Split(' ');
                }

                for (int c = 0; c < pizza[r].Length; c++)
                {
                    piTy = nType[c];
                    pizza[r][c] = piTy;
                }
            }
        }


        public static void RunReport(string[][] pizza)
        {
            int che = 0;
            int pep = 0;
            int haw = 0;
            int sup = 0;
            string pizza1 = "";

            for (int r = 0; r < pizza.Length; r++)
            {
                for (int c = 0; c < pizza[r].Length; c++)
                {
                    pizza1 = pizza[r][c];
                    switch (pizza1)
                    {
                        case "cheese":
                            che++;
                            break;
                        case "pepperoni":
                            pep++;
                            break;
                        case "hawaiian":
                            haw++;
                            break;
                        case "supreme":
                            sup++;
                            break;
                    }
                }
            }
            Write("There were:\n");
            Write("{0} cheese pizzas\n", che);
            Write("{0} pepperoni pizzas\n", pep);
            Write("{0} hawaiian pizzas\n", haw);
            Write("{0} supreme pizzas\n", sup);
        }
    }
}
