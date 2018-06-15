/* Blaine Smith
 * Prog 15 Due Tuesday, May 1st 2018
 * Matt Clark
 * This Program will allow a person to enter a number of classes they took for a semester then enter the letter grades for each class,
 * then they will be able to get the total gpa for each semester individually.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace BSmith_Prog15
{
    class StudentGrades
    {
        private char[][] grades;
        private double totalGpa = 0.0;
        private int totalClasses;
        private int semesters;


        public int Semesters
        {
            get
            {
                return semesters;
            }
            set
            {
                semesters = value;
            }
        }


        public double TotalGpa
        {
            get
            {
                return totalGpa;
            }
            set
            {
                totalGpa = value;
            }
        }


        public StudentGrades()
        {
            totalClasses = 0;
            SetSemesters(4);
            grades = new char[semesters][];
        }


        public void SetSemesters(int semest)
        {
            if (semest < 1)
            {
                WriteLine("Error value less than 1, will set to 0");
                semest = 0;
            }
            else
            {
                semesters = semest;
            }
        }


        public void InputSemesters()
        {
            bool fluffy;
            int semNum = 0;
            for (int r = 0; r < grades.Length; r++)
            {
                do
                {
                    fluffy = false;
                    try
                    {
                        Write("How many courses were taken semester {0}:  ", r + 1);
                        semNum = int.Parse(ReadLine());
                        CreateSemesters(r, semNum);
                    }
                    catch (System.Exception e)
                    {
                        fluffy = true;
                        WriteLine("Problem with input");
                        Error.WriteLine(e.Message);
                        WriteLine("Try again.");
                    }
                } while (fluffy);
            }
            WriteLine("All classes per semester have been entered.");
        }


        public void CreateSemesters(int sem, int numClasses)
        {
            grades[sem] = new char[numClasses];
            totalClasses = numClasses;
        }


        public void EnterGrades()
        {
            for (int r = 0; r < grades.Length; r++)
            {
                for (int c = 0; c < grades[r].Length; c++)
                {
                    bool reTry;
                    do
                    {
                        reTry = false;
                        try
                        {
                            Write("Enter letter grade for class {0} of semester {1}:  ", c + 1, r + 1);
                            grades[r][c] = char.Parse(ReadLine());
                            CheckLetterGrade(grades[r][c]);
                        }
                        catch (IncorrectLetterGradeException E)
                        {
                            Error.WriteLine(E.Message);
                            reTry = true;
                        }
                        catch
                        {
                            WriteLine("Please enter a character.  Try again.\nNot an acceptable letter grade of A-D or F");
                            reTry = true;
                        }

                    } while (reTry);
                }
            }
        }


        public void CheckLetterGrade(char G)
        {
            bool let = false;
            switch (G)
            {
                case 'A':
                    let = true;
                    break;
                case 'B':
                    let = true;
                    break;
                case 'C':
                    let = true;
                    break;
                case 'D':
                    let = true;
                    break;
                case 'F':
                    let = true;
                    break;
            }
            if (let == false)
            {
                IncorrectLetterGradeException weewoo = new IncorrectLetterGradeException("That is not an acceptable letter grade.  Try again.\nNot an acceptable letter grade of A-D or F");
                throw weewoo;
            }
        }


        public double SemesterGpa(int semest)
        {
            double semGpa = 0;
            double ugh = 0;
            double semTot = 0.0;
            int count = 0;
            for (int c = 0; c < grades[semest - 1].Length; c++)
            {
                switch (grades[semest - 1][c])
                {
                    case 'A':
                        semGpa = 4.0;
                        break;
                    case 'B':
                        semGpa = 3.0;
                        break;
                    case 'C':
                        semGpa = 2.0;
                        break;
                    case 'D':
                        semGpa = 1.0;
                        break;
                    case 'F':
                        semGpa = 0.0;
                        break;
                }
                count++;
                semTot += semGpa;
            }
            try
            {
                ugh = CalcGpa(semTot, count);
            }
            catch (FloatingPtDivideByZeroException E)
            {
                Error.WriteLine(E.Message);
                ugh = 0.0;
            }

            return ugh;
        }


        public void CumGpa()
        {
            int clCount = 0;
            int rCount = 0;
            double tot = 0.0;
            double semGpa = 0.0;
            double total = 0.0;
            for (int r = 0; r < grades.Length; r++)
            {
                for (int c = 0; c < grades[r].Length; c++)
                {
                    switch (grades[r][c])
                    {
                        case 'A':
                            semGpa = 4.0;
                            break;
                        case 'B':
                            semGpa = 3.0;
                            break;
                        case 'C':
                            semGpa = 2.0;
                            break;
                        case 'D':
                            semGpa = 1.0;
                            break;
                        case 'F':
                            semGpa = 0.0;
                            break;
                    }
                    clCount++;
                    tot += semGpa;
                }
                rCount += clCount;
                total += tot;
            }
            try
            {
                totalGpa = CalcGpa(total, rCount);
            }
            catch (FloatingPtDivideByZeroException E)
            {
                Error.WriteLine(E.Message);
                totalGpa = 0.0;
            }

        }


        public double CalcGpa(double total, int classes)
        {
            if (classes < 1)
            {
                FloatingPtDivideByZeroException zero = new FloatingPtDivideByZeroException("Exception Type: Dividing by zero\nStudent must take a class before semester GPA can be calculated");
                throw zero;
            }
            double sum = total / classes;
            return sum;
        }


        public override string ToString()
        {
            string things = "";
            int r = 0;
            int c = 0;
            for (r = 0; r < grades.Length; r++)
            {
                things += "\nSemester " + (r + 1) + ": ";
                for (c = 0; c < grades[r].Length; c++)
                {
                    things += grades[r][c] + " ";
                }
            }
            return string.Format("Students grades are: {0}", things);

        }
    }
}
