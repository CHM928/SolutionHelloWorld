<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExampleGetMax.aspx.cs" Inherits="WebApplication1.ExampleGetMAx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            请输入三个数，求最大值<br />
            <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            ,<asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
            ,<asp:TextBox ID="txtNum3" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="求最大值" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
