<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowPilots.aspx.cs" Inherits="Project.ShowPilots" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="PilotsList" runat="server" RepeatColumns="1" OnItemCommand="PilotsList_ItemCommand">
                <ItemTemplate>
                    <table border="1" style="border:groove">
                        <tr>
                            <td>First Name: <br /><asp:Label  runat="server" ID="FN" Text='<%# Eval("MyFirstName") %>'></asp:Label></td>
                            <td>Last Name: <br /><asp:Label runat="server" ID="LN" Text='<%# Eval("MyLastName") %>'></asp:Label></td>
                            <td>Id: <br /><asp:Label runat="server" ID="MId" Text='<%# Eval("MyID") %>'></asp:Label></td>
                            <td>Licence: <br /><asp:Label runat="server" ID="Lic" Text='<%# Eval("MyLicence") %>'></asp:Label></td>
                            <td>Gender: <br /><asp:Label runat="server" ID="Gen" Text='<%# Eval("MyGender") %>'></asp:Label></td>
                            <td>Email: <br /><asp:Label runat="server" ID="Ema" Text='<%# Eval("MyEmail") %>'></asp:Label></td>
                            <td>Phone Number: <br /><asp:Label runat="server" ID="Ph" Text='<%# Eval("MyPhoneNum") %>'></asp:Label></td>
                            <td>Passport: <br /><asp:Label runat="server" ID="Pass" Text='<%# Eval("MyPassport") %>'></asp:Label></td>
                            <td>Nationality: <br /><asp:Label runat="server" ID="Nat" Text='<%# Eval("MyNationality") %>'></asp:Label></td>
                            <td><a href="ShowRes.aspx?res=<%# DataBinder.Eval(Container.DataItem,"MyID")%>">Reservations</a></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
