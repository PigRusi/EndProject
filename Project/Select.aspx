<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Select.aspx.cs" Inherits="Project.Select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Choose Type</label>
            <asp:DropDownList ID="WhatTable" runat="server">
                <asp:ListItem>Pilots</asp:ListItem>
                <asp:ListItem>Travelers</asp:ListItem>
            </asp:DropDownList><br />

            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
