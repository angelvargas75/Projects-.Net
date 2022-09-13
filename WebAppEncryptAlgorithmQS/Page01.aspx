<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page01.aspx.cs" Inherits="WebApplication5.Page01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>Name:
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Text="Mudassar Khan" />
                </td>
            </tr>
            <tr>
                <td>Technology:
                </td>
                <td>
                    <asp:DropDownList ID="ddlTechnology" runat="server">
                        <asp:ListItem Text="ASP.Net" Value="ASP.Net" />
                        <asp:ListItem Text="PHP" Value="PHP" />
                        <asp:ListItem Text="JSP" Value="JSP" />
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <hr />
        <asp:Button ID="Button1" Text="Submit" runat="server" OnClick="Submit" />
    </form>
</body>
</html>
