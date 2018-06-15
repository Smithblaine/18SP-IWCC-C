/* Blaine Smith
 * Prog 11 Due Tuesday, April 3rd 2018
 * NONE
 * Program will determine if a student is able to graduate based on,
 * the students grades and if they are missing any classes.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BSmith_Prog11
{
    class IWCCGraduation
    {
        private double[] grades;
        private double gpa;
        private string name;

        public double GPA
        {
            get
            {
                return gpa;
            }
            set
            {
                gpa = value;
            }

        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public IWCCGraduation()
        {
            gpa = 0.0;
            grades = new double[6];
            Introduction();
        }


        public void Introduction()
        {
            WriteLine("IWCC Graduation Calculator");
            WriteLine();
        }


        public void EnterGrades()
        {
            WriteLine("Enter the grades, enter a -1.0 to indicate a class not taken.");

            int i = 0;
            for (i = 0; i < grades.Length; i++)
            {
                Write("Enter grade {0}:  ", i + 1);
                grades[i] = double.Parse(ReadLine());

                if (grades[i] < -1.0 || grades[i] > 4.0)
                {
                    do
                    {
                        Write("That wasn't a valid grade.  Try again:  ");
                        grades[i] = double.Parse(ReadLine());
                    } while (grades[i] < -1.0 || grades[i] > 4.0);
                }
            }
            WriteLine("All grades successfully entered");
        }


        public void CalcGpa()
        {
            double sum = 0.0;
            int classes = 0;

            foreach (double num in grades)
            {
                if (num == -1.0)
                {
                    continue;
                }
                else
                {
                    sum += num;
                    classes++;
                }
                gpa = sum / classes;
            }
        }


        public void PrintGrades()
        {
            string str1 = "Class";
            string str2 = "Grades";
            WriteLine("");
            WriteLine("{0}{1,17:1}", str1, str2);
            int i = 0;
            for (i = 0; i < grades.Length; i++)
            {
                WriteLine("{0,1:F0}{1,19:F2}", i + 1, grades[i]);
            }
        }

        public bool MissingClasses()
        {
            bool classes = false;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] == -1.00)
                {
                    WriteLine("Class {0} not taken yet.", i + 1);
                    classes = true;
                }
                else if (grades[i] == 0.00)
                {
                    WriteLine("Class {0} not passed yet.", i + 1);
                    classes = true;
                }
            }
                return classes;
        }
    }
}
