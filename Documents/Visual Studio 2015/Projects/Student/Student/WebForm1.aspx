<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Student.WebForm1" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CC9966"
            BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        </asp:GridView>
        <br />
        <asp:Button ID="Connected" runat="server" OnClick="Connected_Click" Text="Connected" />
        <asp:Button ID="Disconnected" runat="server" EnableTheming="False" OnClick="Disconnected_Click"
            Text="Disconnected" />
    </div>
    </form>
</body>
</html>

