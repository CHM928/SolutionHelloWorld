<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonalID.aspx.cs" Inherits="WebApplication1.PersonalID" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" Height="23px"  TextMode="Number" Width="224px" Wrap="False">身份信息</asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BorderStyle="None" OnClick="Button1_Click" Text="输入身份证" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="身份提取" Width="500px"></asp:Label>
    </form>
</body>
</html>
