<!--
 * 
 * Blaine Smith
 * Program 16 Due Tuesday, May 8, 2018
 * None
 * The program will take a users name and which math operation they wish to preform and then return to them the answer.
 *
 -->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BSmith_Prog16.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to the CIS 139 Calculator App</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <br />
                <h1>Welcome to the CIS 139 Calculator App</h1>
                <br />
                What is your name?<asp:TextBox ID="name" runat="server"></asp:TextBox><br />
                What opertaion would you like to do? Enter addition, subtraction, multiplication, or division:<asp:TextBox ID="select" runat="server"></asp:TextBox><br />
                Enter the first number:<asp:TextBox ID="numOne" runat="server"></asp:TextBox><br />
                Enter the second number:<asp:TextBox ID="numTwo" runat="server"></asp:TextBox><br />
                <br />
                <asp:Button ID="submit" runat="server" Text="Calculate!" />
        </div>
        
    </form>
</body>
</html>
