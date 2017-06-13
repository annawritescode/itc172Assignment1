<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewGrant.aspx.cs" Inherits="NewGrant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Grants</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="GrantDropDownList" runat="server" AutoPostBack="True" ></asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    </div>
    </form>
</body>
</html>
