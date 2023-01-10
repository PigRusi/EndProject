<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowRes.aspx.cs" Inherits="Project.ShowRes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="ShowR" runat="server" RepeatColumns="1" OnItemCommand="ShowR_ItemCommand">
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>Plane: <br /><asp:Label runat="server" ID="Pl" Text='<%# Eval("Plane") %>'></asp:Label></td>
                            <td>Destenation: <br /><asp:Label runat="server" ID="Des" Text='<%# Eval("MyDestenation") %>'></asp:Label></td>
                            <td>Departure Date: <br /><asp:Label runat="server" ID="DD" Text='<%# Eval("DepDate") %>'></asp:Label></td>
                            <td>Return Date: <br /><asp:Label runat="server" ID="RD" Text='<%# Eval("RetDate") %>'></asp:Label></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
