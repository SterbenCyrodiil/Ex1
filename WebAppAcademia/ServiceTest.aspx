<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceTest.aspx.cs" Inherits="WebAppAcademia.ServiceTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:Button ID="btnCallServiceMethod" runat="server" Text="Example" OnClick="btnCallServiceMethod_Click" />
            <asp:Label ID="lblReturn" runat="server" ></asp:Label>
    </div>
    </form>
</body>
</html>
