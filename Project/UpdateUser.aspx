<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="Project.UpdateUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:DropDownList ID="WhatTable" runat="server">
                <asp:ListItem>travelers</asp:ListItem>
                <asp:ListItem>pilots</asp:ListItem>
            </asp:DropDownList><br /><br />
            <label>Enter your ID</label><asp:TextBox ID="InsertID" runat="server"></asp:TextBox><br /><br />
            <label>Enter your Password</label><asp:TextBox ID="InsertPass" runat="server"></asp:TextBox><br /><br />

            <asp:Button runat="server" ID="CheckBtn" Text="Check User" OnClick="CheckBtn_Click" /><br /><br />

            <label>Change Email</label><asp:TextBox ID="InsertEmail" runat="server"></asp:TextBox><br /><br />
            <label>Change Phone</label><asp:TextBox ID="InsertPhone" runat="server"></asp:TextBox><br /><br />
            <label>Change Password</label><asp:TextBox ID="InsertNewPass" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="UpBtn" runat="server" Text="Update" OnClick="Update" />
        </div>
    </form>
</body>
</html>
