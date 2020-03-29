<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getDay.aspx.cs" Inherits="WebApplication1.getDay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="year" runat="server"></asp:TextBox>
            年份<br />
            <asp:TextBox ID="month" runat="server"></asp:TextBox>
            月份<br />
            <asp:TextBox ID="date" runat="server"></asp:TextBox>
            日期<br />
            <asp:Button ID="day" runat="server" OnClick="day_Click" Text="输出该年的第几天" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
