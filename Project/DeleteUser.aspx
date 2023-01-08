<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteUser.aspx.cs" Inherits="Project.DeleteUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Traveler</asp:ListItem>
                <asp:ListItem>Pilot</asp:ListItem>
            </asp:DropDownList><br /><br />
            <label>Enter ID to delete</label><asp:TextBox ID="InsertID" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="DelBtn" runat="server" Text="Delete" OnClick="DelBtn_Click" />
        </div>
    </form>
</body>
</html>
