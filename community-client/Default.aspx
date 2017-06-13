<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <h1>Log In</h1>
   <table>
       <tr>
           <td>User Name</td>
             <td><asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox>email</td>
       </tr>
 
        <tr>
           <td>Password</td>
             <td><asp:TextBox ID="PasswordTextBox" runat="server"
                 TextMode="Password">
                   </asp:TextBox></td>
       </tr>
        <tr>
           
             <td>
                 <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="LoginButton1_Click" /></td>
            <td><asp:Label ID="ResultLabel1" runat="server" Text=""></asp:Label></td>
       </tr>
   </table>

    </div>
        <asp:LinkButton ID="Linkbutton1" runat="server" PostBackUrl="~/register.aspx"></asp:LinkButton>
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/NewGrant.aspx">View Grants</asp:LinkButton>
    </form>
</body>
</html>
