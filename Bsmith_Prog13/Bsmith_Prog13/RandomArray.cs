/* Blaine Smith
 * Prog 13 Due Tuesday, April 17th 2018
 * NONE
 * This Program will allow a person to search a list of numbers and will determine if the number is there or not.
 */
using System;
using static System.Console;


namespace Bsmith_Prog13
{
    class RandomArray
    {
        static void Main(string[] args)
        {
            int row = -1;
            int col = -1;
            int [ , ] weeWoo = new int [3,5];

            FillArray(weeWoo);
            PrintArray(weeWoo);
            SumRows(weeWoo);
            SumCols(weeWoo);
            int sArr = SumArray(weeWoo);
            WriteLine("Total for sum of the array is:  {0}",sArr);
            int userNum = GetNumber();
            bool seek = SearchArray(userNum, weeWoo, ref row, ref col);
            if (seek == true)
            {
                Write("Your number, {0}, was found at row index {1} and column index {2}.", userNum, row, col);
            }
            else
            {
                Write("Your number, {0}, was not found.", userNum);
            }
            WriteLine();
        }

        public static void FillArray(int [ , ] wee)
        {
            Random randm = new Random();
            for (int r = 0; r < wee.GetLength(0); r++)
            {
                for (int c = 0; c < wee.GetLength(1); c++)
                {
                    wee[r, c] = randm.Next(15, 97);
                }
            }
        }

        public static void PrintArray(int [ , ] wee)
        {
            for (int r = 0; r < wee.GetLength(0); r++)
            {
                for (int c = 0; c < wee.GetLength(1); c++)
                {
                    Write("{0} ", wee[r, c]);
                }
                WriteLine();
            }
        }

        public static void SumRows(int [ , ] wee)
        {
            WriteLine();
            int rSum;
            for (int r = 0; r < wee.GetLength(0); r++)
            {
                rSum = 0;
                for (int c = 0; c < wee.GetLength(1); c++)
                {
                    rSum += wee[r, c];
                }
                WriteLine("The total sum for row {0} is:  {1}.",r +1, rSum);
            }
        }

        public static void SumCols(int [ , ] wee)
        {
            WriteLine();
            int cSum;
            for (int c = 0; c < wee.GetLength(1); c++)
            {
                cSum = 0;
                for (int r = 0; r < wee.GetLength(0); r++)
                {
                    cSum += wee[r, c];
                }
                WriteLine("The total sum for column {0} is:  {1}.", c + 1, cSum);
            }
        }

        public static int SumArray(int[,] wee)
        {
            WriteLine();
            int sArr = 0;
            foreach(int num in wee)
            {
                sArr += num;
            }
            return sArr;
        }

        public static int GetNumber()
        {
            WriteLine();
            Write("Enter a number between 15 and 96:  ");
            int userNum = int.Parse(ReadLine());

            while(userNum < 15 || userNum > 96)
            {
                Write("Number not between 15 and 96.  Try again:  ");
                userNum = int.Parse(ReadLine());
            }
            return userNum;
        }

        public static bool SearchArray(int userNum1, int [ , ] wee, ref int rows, ref int cols)
        {
            bool tf = false;
            WriteLine();
            for (int r = 0; r < wee.GetLength(0); r++)
            {
                for (int c = 0; c < wee.GetLength(1); c++)
                {
                    if (userNum1 == wee[r, c])
                    {
                        tf = true;
                        rows = r;
                        cols = c;
                        break;
                    }
                }
            }
            return tf;
        }
    }
}
