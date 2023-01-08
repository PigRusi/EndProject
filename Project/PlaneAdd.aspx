<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaneAdd.aspx.cs" Inherits="Project.PlaneAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="PlaneList" runat="server"></asp:DropDownList>

            <asp:TextBox ID="Quantity" runat="server"></asp:TextBox>

            <asp:Button ID="Submit" runat="server" Text="Button" OnClick="Submit_Click" />
        </div>
    </form>
</body>
</html>
