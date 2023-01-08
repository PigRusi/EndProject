<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Project.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>First Name</label><asp:TextBox ID="InsertFName" runat="server"></asp:TextBox><br /><br />

            <label>Last Name</label><asp:TextBox ID="InsertLName" runat="server"></asp:TextBox><br /><br />

            <label>ID</label><asp:TextBox ID="InsertID" runat="server"></asp:TextBox><br /><br />

            <asp:DropDownList ID="WhatTable" runat="server">
                <asp:ListItem>Travelers</asp:ListItem>
                <asp:ListItem>Pilots</asp:ListItem>
            </asp:DropDownList><br /><br />

            <label>Licence Num</label><asp:TextBox ID="InsertLicence" runat="server"></asp:TextBox><br /><br />

            <label>Passport Num</label><asp:TextBox ID="InsertPassport" runat="server"></asp:TextBox><br /><br />

            <label>Gender</label>
            <asp:RadioButton ID="InsertMale" Text="Male" runat="server" GroupName="Gender" />
            <asp:RadioButton ID="InsertFemale" Text="Female" runat="server" GroupName="Gender" /><br /><br />

            <label>Nationality</label><asp:TextBox ID="InserNationality" runat="server"></asp:TextBox><br /><br />

            <label>Email</label><asp:TextBox ID="InsertEmail" runat="server"></asp:TextBox><br /><br />

            <label>Phone Num</label><asp:TextBox ID="InsertPhone" runat="server"></asp:TextBox><br /><br />

            <label>Birth Date</label><asp:TextBox ID="InsertBDay" runat="server" TextMode="Date"></asp:TextBox><br /><br />

            <label>Password</label><asp:TextBox ID="InsertPassword" runat="server" TextMode="Password"></asp:TextBox><br /><br />



            <asp:Button ID="RegBut" runat="server" Text="Sign Up" OnClick="Submit" />
            
        </div>
    </form>
</body>
</html>
