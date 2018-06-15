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

namespace BSmith_Prog12
{
    class IWCCStudent
    {
        private string lname;
        private string fname;
        private double gpa;
        private string major;
        private int id;


        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }

        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }

        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }

        public IWCCStudent(string ln, string fn, string maj, int ident, double grade)
        {
            lname = ln;
            fname = fn;
            major = maj;
            id = ident;
            gpa = grade;
        }


        public override string ToString()
        {
            return string.Format("{0}, {1}; {2} {3} {4:F2}", lname, fname, id, major, gpa);
        }
    }
}
