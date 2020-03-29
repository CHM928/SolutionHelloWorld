<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeworkchkEmail.aspx.cs" Inherits="WebApplication1.HomeworkchkEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtEmail1" runat="server" Width="611px"></asp:TextBox>
            <asp:Button ID="btnEmail1" runat="server" OnClick="Button1_Click1" Text="Email格式检测" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
