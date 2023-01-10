<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PurchasePlane.aspx.cs" Inherits="Project.PurchasePlane" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Choose Plane:</label><asp:DropDownList ID="PlaneList" runat="server"></asp:DropDownList><br /><br />
            <label>Destenation: </label><asp:TextBox ID="Destenation" runat="server"></asp:TextBox><br /><br />
            <label>Departure Date: </label><asp:TextBox ID="DepartureDate" runat="server" TextMode="Date"></asp:TextBox><br /><br />
            <label>Rerturn Date: </label><asp:TextBox ID="RerturnDate" runat="server" TextMode="Date"></asp:TextBox><br /><br /><br />

            <asp:Button ID="Submit" runat="server" Text="Button" OnClick="Submit_Click" />
        </div>
    </form>
</body>
</html>
