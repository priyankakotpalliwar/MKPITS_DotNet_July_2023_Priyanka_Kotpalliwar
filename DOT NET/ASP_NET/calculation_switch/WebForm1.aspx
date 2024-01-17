<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="calculation_switch.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Enter number1" style="text-align: center"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 203px" Width="164px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter number 2"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 199px" Width="159px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Select Operator"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 200px" Width="158px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 73px" Text="Button" Width="190px" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Width="186px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
    </form>

</body>
</html>
