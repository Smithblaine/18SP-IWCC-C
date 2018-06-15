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
    class IWCCStudent
    {
        static void Main(string[] args)
        {
            IWCCGraduation grad = new IWCCGraduation();
            grad.Name = GetStudentName();
            WriteLine();
            grad.EnterGrades();
            grad.CalcGpa();
            grad.PrintGrades();
            WriteLine();
            CanGraduate(grad);
        }


        public static string GetStudentName()
        {
            Write("Enter student's name:  ");
            string name = ReadLine();
            return name;
        }


        public static void CanGraduate(IWCCGraduation graduate)
        {
            bool grad = false;
            grad = graduate.MissingClasses();

            if (grad == true)
            {
                WriteLine("{0} may not graduate due to above missing or failed classes.", graduate.Name);
            }
            else if (graduate.GPA < 2.00)
            {
                WriteLine("{0} may not graduate due to insuffucent GPA of {1:F2}.", graduate.Name, graduate.GPA);
            }
            else
            {
                WriteLine("{0} may graduate with a {1:F2} GPA.", graduate.Name, graduate.GPA);
            }
        }
    }
}
