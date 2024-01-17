<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Aspneteg1.WebForm1" %>

<!DOCTYPE html>
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int n1 = Convert.ToInt32(TextBox1.Text);
        int n2 = Convert.ToInt32(TextBox2.Text);
        int result = 0;
        char op = Convert.ToChar(TextBox3.Text);
        if(op == '+')
        {
            result = n1 + n2;
        }
        else if(op =='-')
        {
            result = n1 - n2;
        }
        else if(op=='*')
        {
            result = n1 * n2;
        }
        else if(op=='/')
        {
            result = n1 / n2;

        }
        else
        {
            TextBox4.Text = "invalid operator";
        }

        TextBox4.Text = result.ToString();

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
