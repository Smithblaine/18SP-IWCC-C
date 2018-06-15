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

namespace BSmith_Prog15
{
    class FloatingPtDivideByZeroException : System.ApplicationException
    {
        public FloatingPtDivideByZeroException(string exceptionMsg) : base(exceptionMsg)
        {

        }
    }
}
