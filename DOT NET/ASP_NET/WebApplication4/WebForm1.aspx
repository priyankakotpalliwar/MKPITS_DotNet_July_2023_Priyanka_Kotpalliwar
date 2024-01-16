<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            MKPITS</div>
        <p style="margin-left: 240px">
            <asp:Label ID="Label1" runat="server" Text="Enter Number 1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p style="margin-left: 240px">
            <asp:Label ID="Label2" runat="server" Text="Enter Number 2"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="169px"></asp:TextBox>
            &nbsp;</p>
        <p style="margin-left: 240px">
            &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="text-align: center" Text="ADD" Width="122px" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 23px" Text="Substract" Width="146px" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="margin-left: 30px" Text="Divide" Width="126px" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="margin-left: 30px" Text="Multiply" Width="140px" />
        </p>
        <p style="margin-left: 240px">
&nbsp;<asp:TextBox ID="TextBox3" runat="server" Width="169px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
