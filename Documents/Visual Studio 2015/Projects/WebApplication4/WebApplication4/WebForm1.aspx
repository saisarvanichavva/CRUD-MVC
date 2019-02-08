<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <table>
            <tr>
                <td>Country:</td>
                <td><asp:DropDownList ID="ddlCountries" runat="server" AutoPostBack = "true" OnSelectedIndexChanged = "Country_Changed">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>State:</td>
                <td>
                    <asp:DropDownList ID="ddlStates" runat="server" AutoPostBack = "true" OnSelectedIndexChanged = "State_Changed">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>City:</td>
                <td>
                    <asp:DropDownList ID="ddlCities" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </ContentTemplate>
</asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
