using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 /* 
 * Blaine Smith
 * Program 16 Due Tuesday, May 8, 2018
 * None
 * The program will take a users name and which math operation they wish to preform and then return to them the answer.
 */
namespace BSmith_Prog16
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string opp = "";
            double num1;
            bool str1 = double.TryParse(numOne.Text, out num1);
            double num2;
            bool str2 = double.TryParse(numTwo.Text, out num2);
            double num3 = 0.0;
            string strOpp = select.Text.ToLower();
            bool ok = false;

            if (Page.IsPostBack)
            {
                form1.Visible = false;
                switch (strOpp)
                {
                    case "addition":
                        num3 = num1 + num2;
                        ok = true;
                        opp = "+";
                        break;
                    case "subtraction":
                        num3 = num1 - num2;
                        ok = true;
                        opp = "-";
                        break;
                    case "multiplication":
                        num3 = num1 * num2;
                        ok = true;
                        opp = "*";
                        break;
                    case "division":
                        num3 = num1 / num2;
                        ok = true;
                        opp = "/";
                        break;
                }

                if (strOpp != "addition" && strOpp != "subtraction" && strOpp != "multiplication" && strOpp != "division")
                {
                    Response.Write("Sorry, " + name.Text + ", I am unable to determine the opertaion you desire. Hit the back button and try again.");
                }
                else if (str1 == false || str2 == false)
                {
                    Response.Write("Sorry, " + name.Text + ", your numbers are invalid. Hit the back button and try again.");
                }
                else if (ok == true)
                {
                    Response.Write(name.Text + ", here is your result: " + num1 + " " + opp + " " + num2 + " = " + num3);
                    Response.Write("<br /><br />If you have another calculation, please hit the back button and enter your new information.");
                }
            }
        }
    }
}