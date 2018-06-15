/* Blaine Smith
* Prog 12 Due Tuesday, April 10th 2018
* NONE
* Program will allow a person to enter in the students information
* then allow them to look up the students based on the information entered.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace BSmith_Prog12
{
    class IWCCGraduation
    {
        static void Main(string[] args)
        {
            int choice = 0;
            string lname;
            string fname;
            string major;

            Greeting();
            IWCCStudent[] students = new IWCCStudent[4];
            for (int i = 0; i < students.Length; i++)
            {
                WriteLine();
                GetInfo(out lname, out fname, out major);
                int id = GetId();
                double gpa = GetGpa();
                students[i] = new IWCCStudent(lname, fname, major, id, gpa);
            }

            do
            {
                DisplayMenu();
                choice = GetChoice();
                DoChoice(students, choice);
            } while (choice != 4);
        }



        public static void Greeting()
        {
            WriteLine("IWCC Students Inputs");
        }


        public static void GetInfo(out string lnam, out string fnam, out string majo)
        {
            Write("Enter student's last name:  ");
            lnam = ReadLine();
            Write("Enter student's first name:  ");
            fnam = ReadLine();
            Write("Enter student's major:  ");
            majo = ReadLine();
        }



        public static int GetId()
        { 
            Write("Enter student's ID number:  ");
            int id = int.Parse(ReadLine());
            do
            {
                if (id == 0)
                { 
                    Write("Student ID must be greater than 0.");
                    id = int.Parse(ReadLine());
                }
            } while (id == 0);
            return id;
        }



        public static double GetGpa()
        {
            Write("Enter student's GPA:  ");
            double gpa = double.Parse(ReadLine());
            do
            {
                if (gpa < 0.0 || gpa > 4.0)
                {
                    Write("That wasn't a valid grade.  Try again:  ");
                    gpa = double.Parse(ReadLine());
                }
            } while (gpa < 0.0 || gpa > 4.0);
            return gpa;
        }



        public static void DisplayMenu()
        {
            WriteLine();
            WriteLine("1. Search by Last Name");
            WriteLine("2. Search by First Name");
            WriteLine("3. Search by Major");
            WriteLine("4. Quit");
            WriteLine();
        }



        public static int GetChoice()
        {
            Write("Enter your choice:  ");
            int choice = int.Parse(ReadLine());
            do
            {
                if (choice < 1 || choice > 4)
                {
                    Write("That was not a valid choice. Enter again.  ");
                    DisplayMenu();
                    Write("Enter your choice:  ");
                    choice = int.Parse(ReadLine());
                }
            } while (choice < 1 || choice > 4);
            return choice;
        }



        public static void DoChoice(IWCCStudent[] students, int cho)
        {
            if (cho == 1)
            {
                FindLastName(students);
            }
            else if (cho == 2)
            {
                FindFirstName(students);
            }
            else if (cho == 3)
            {
                FindMajor(students);
            }
            else
            {


            }
        }



        public static void FindLastName(IWCCStudent[] students)
        {
            Write("What is the last name:  ");
            string lnam = ReadLine();
            WriteLine();
            int count = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (lnam == students[i].Lname)
                {
                    PrintStudent(students[i]);
                    count++;
                }
            }
            if (count == 0)
            {
                WriteLine("No last name of {0} found", lnam);
            }
        }



        public static void FindFirstName(IWCCStudent[] students)
        {
            Write("What is the first name:  ");
            string fnam = ReadLine();
            WriteLine();
            int count = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (fnam == students[i].Fname)
                {
                    PrintStudent(students[i]);
                    count++;
                }
            }
            if (count == 0)
            {
                WriteLine("No first name of {0} found", fnam);
            }
        }



        public static void FindMajor(IWCCStudent[] students)
        {
            Write("What is the major:  ");
            string majo = ReadLine();
            WriteLine();
            int count = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (majo == students[i].Major)
                {
                    PrintStudent(students[i]);
                    count++;
                }
            }
            if (count == 0)
            {
                WriteLine("No major of {0} found", majo);
            }
        }


        public static void PrintStudent(IWCCStudent stud)
        {
            WriteLine(stud);
        }
    }
}
