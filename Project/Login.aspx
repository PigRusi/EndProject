<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="WhatTable" runat="server">
                <asp:ListItem>Travelers</asp:ListItem>
                <asp:ListItem>Pilots</asp:ListItem>
            </asp:DropDownList><br /><br />

            <asp:TextBox ID="Id1" runat="server"></asp:TextBox><br /><br />
            <asp:TextBox ID="Pass" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />


        </div>
    </form>
</body>
</html>
